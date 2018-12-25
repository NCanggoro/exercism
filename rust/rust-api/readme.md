# Installation
If you havent install rust yet u can install it [Here](https://doc.rust-lang.org/book/2018-edition/ch01-01-installation.html)

Use Nightly
```sh
$ rustup default nightly
```

# Install Diesel
```sh
$ cargo install diesel_cli --no-default-features --features mysql
```
make sure you are already install mysql 
# Run
```sh
$ rustup update && cargo update
$ echo DATABASE_URL=mysql://username:password@localhost/studentsDB > .env
$ diesel setup
$ diesel migration run
$ cargo run
```