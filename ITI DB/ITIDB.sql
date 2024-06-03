--ITI Data Base
--Create The Data Base called ITI
create database ITI
--Create Tables 
-- ========Table Students======
use ITI
Create Table Students(
	ID Int Identity(1,1) Primary Key,--Auto Generate
	Fname VarChar(20) Not Null ,--required
	Lname VarChar(20),
	Age Int not null,--required
	Address text  not null,--required
	Dep_ID int not null  --refrences Departments(ID) [Relationship ManyToOne ]mandatory
)

-- ========Table Departments======
Create Table Departments(
	ID Int Identity(1,1) Primary Key,--Auto Generate
	name VarChar(20) Not Null ,--required
	HiringDate Date,
	ins_id Int not null unique,--refrences instructors(ID) [Relationship OneToOne ]mandatory
)
-- ========Table instructors======
Create Table Instructors(
	ID Int Identity(1,1) Primary Key,--Auto Generate
	name VarChar(20) Not Null ,--required
	Address  Text Not Null, --required
	Bouns dec(10,5) ,
	Salary dec (20,10) Not Null ,--required
	Hour_Rate dec(5,2) Not Null ,--required
)
alter table Instructors 
add  Dep_id int not null --Add New Column 
-- ========Table Courses======
Create Table Courses(
	ID Int Identity(1,1) Primary Key,--Auto Generate
	name VarChar(20) Not Null ,--required
	Duration  Int Not Null, --required
	Description  VarChar(200) Not Null , --required
	Top_id Int not null  --references Topics(ID) [Relationship ManyToOne ]mandatory
)
-- ========Table Topics======
Create Table Topics(
	ID Int Identity(1,1) Primary Key,--Auto Generate
	name VarChar(20) Not Null ,--required
)
-- ========Table Student_Courses======
Create Table Student_Courses(
	Stud_ID Int references Students(ID) ,
	Course_ID Int references Courses(ID),
	Grade Char(2),
	primary Key(Stud_ID,Course_ID)
)
-- ========Table Instrucor_Course======
Create Table Instrucor_Course(
	inst_ID Int References Instructors(ID) ,
	Course_ID Int References Courses(ID),
	Evaluation VarChar(200),
	primary Key(inst_ID,Course_ID)
)

-- ========Relationships========

--======== Student_Department==============
Alter Table Students
Add foreign Key(Dep_id) references Departments(ID) 
--======== Department_Instructor==============

--1.
Alter Table Departments
Add foreign Key(ins_id) references Instructors(ID) 
--2.
alter table Instructors
add  foreign key(Dep_id) references Departments(ID) 

--======== Course_Topic==============
Alter Table Courses
Add foreign Key(Top_id) references Topics(ID) 
