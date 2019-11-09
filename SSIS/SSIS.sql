create database Database1
use Database1

create table Employee1
(
	ID int,
	Name varchar(50),
	Designation varchar(50),
	Department varchar(50),
	Salary float
);

drop table Employee1

select * from Employee1


sp_help Employee1