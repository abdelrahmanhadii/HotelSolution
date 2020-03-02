create database Hotel_db
go
use Hotel_db

 create table Roles(
RoleCode int primary key identity,
RoleName varchar(20) not null
)

create table Users(
UserCode int primary key identity,
UserEmail varchar(40) not null,
UserPassword varchar(20) not null,
RoleId int references Roles(RoleCode) on delete no action on update cascade not null
)
create table Beds(
BedsCode int primary key identity,
NumberOfBeds int not null,
BedsPrice float not null)

create table RoomCategory(
RoomCategoryCode int primary key identity,
RoomCategory varchar (50) not null,
CategoryPrice float not null)

create table RoomDetails(
RoomDetailscode int primary key identity,
RoomNumber int not null,
BedsID int references Beds (BedsCode) on delete no action on update cascade not null,
RoomCategoryID int references RoomCategory (RoomCategoryCode) on delete no action on update cascade not null
)

create table Guest(
GuestCode int primary key identity,
GuestName varchar (100) not null,
PhoneNumber varchar(20) not null,
Nationality varchar(50) not null,
NationalID  varchar(30) not null,
Gender varchar(6) not null,
GuestAddress varchar(200) not null,
UserId int references Users (UserCode) on delete no action on update cascade)

create table RoomReservation(
ReservationCode int primary key identity,
StartDate DATE not null,
EndDate DATE not null,
GuestID int references Guest(GuestCode)  on delete no action on update cascade not null,
RoomID int references RoomDetails(RoomDetailscode) on delete no action on update cascade not null)
 

