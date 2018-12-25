use diesel;
use diesel::prelude::*;
use diesel::mysql::MysqlConnection;
use crate::schema::students;


#[table_name = "students"]
#[derive(AsChangeset, Serialize, Deserialize, Queryable, Insertable)]
pub struct Student {
    pub id: Option<i32>,
    pub full_name : String,
    pub age : i32,
    pub nickname : String
}

impl Student {
    pub fn create(student: Student, connection: &MysqlConnection) -> Student {
        diesel::insert_into(students::table)
            .values(&student)
            .execute(connection)
            .expect("Error Creating new student");

        students::table.order(students::id.desc()).first(connection).unwrap()
    }

    pub fn read(connection: &MysqlConnection) -> Vec<Student> {
        students::table.order(students::id.asc()).load::<Student>(connection).unwrap()
    }

    pub fn update(id: i32, student: Student, connection: &MysqlConnection) -> bool {
        diesel::update(students::table.find(id)).set(&student).execute(connection).is_ok()
    }

    pub fn delete(id: i32, connection: &MysqlConnection) -> bool {
        diesel::delete(students::table.find(id)).execute(connection).is_ok()
    }
}