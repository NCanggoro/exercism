use actix::prelude::*;
use actix_web::{http::Method, middleware, App};
use models::DbExecutor;

pub struct AppState {
    pub db: Addr<DbExecutor>,
}

//helper function to create and returns the app after mounting all routes/resources

pub fn create_app(db: Addr<DbExecutor>) -> App<AppState> {
    App::with_state(AppState { db })

    .middleware(middleware::Logger::new("\"%r\" %s  %b %Dms"))

    .resource("/auth", |r|{ })
    .resource("/invitation", |r|{ })
    .resource("/register", |r| { })
}