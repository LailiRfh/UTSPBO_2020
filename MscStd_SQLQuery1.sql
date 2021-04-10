create database MscStdReservation;

create table Reservation
(
ID int NOT Null IDENTITY(1,1) primary key,
Name varchar(50) Not null,
Contact varchar(50) Not null,
RoomType varchar(50) Not null,
RentDate varchar(50) Not null,
RentTime varchar(50) Not null,
RTStart varchar(50) Not null,
);

select * from Reservation;