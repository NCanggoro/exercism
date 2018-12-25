use actix::{ Actor, SyncContext};
use diesel::pg::PgConnection;
use actix::r2d2::{ ConnectionManager, Pool};

pub struct DbExecutor(pub Pool<ConnectionManager<PgConnection>>);

impl Actor for DbExecutor {
    type Context = SyncContext<Self>;
}
