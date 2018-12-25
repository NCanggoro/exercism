-- Your SQL goes here
create table students (
    id INT(11) PRIMARY KEY AUTO_INCREMENT,
    `FullName` VARCHAR(25) NOT NULL,
    age INT(3) NOT NULL,
    nickname VARCHAR(25) NOT NULL
)