create database library

create table loginTable(
id int NOT NULL IDENTITY (1,1) primary key,
username varchar(20) not null,
pass varchar(20) not null
)
insert into loginTable (username,pass) values ('hermann','pass');
 select * from loginTable