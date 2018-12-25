#![feature(plugin)]
#![plugin(rocket_codegen)]


extern crate rocket;
#[macro_use] extern crate rocket_contrib;
#[macro_use] extern crate serde_derive;
#[macro_use] extern crate diesel;


use rocket_contrib::{Json, Value};

mod student;
mod db;
mod schema;
use self::student::{Student};

#[post("/", data="<student>")] 
fn create(student: Json<Student>, connection: db::Connection) -> Json<Student> {
    let insert = Student { id: None, ..student.into_inner()};
    Json(Student::create(insert, &connection))
}

#[get("/")]
fn read(connection: db::Connection) -> Json<Value> {
    Json(json!(Student::read(&connection)))
}

#[put("/<id>", data="<student>")]
fn update(id: i32, student: Json<Student>,  connection: db::Connection) -> Json<Value> {
    let update = Student { id: None, ..student.into_inner() };
    Json(json!({"success": Student::update(id, update, &connection)
    
    }))
}

#[delete("/<id>")]
fn delete(id: i32, connection: db::Connection) -> Json<Value> {
    Json(json!({"status": Student::delete(id, &connection)}))
}

fn main(){
    rocket::ignite()
    .manage(db::connect())
    .mount("/student", routes![create, update, delete])
    .mount("/students", routes![read])
    .launch();
}