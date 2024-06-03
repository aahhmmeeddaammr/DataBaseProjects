-----------------PART#2--------------------------------
use ITI;
--Get all instructors Names without repetition.
Select distinct   Ins_Name
from Instructor
--------------------------------------------------------------------------------
--Display instructor Name and Department Name Note: display all the instructors if they are attached to a department or not.

select i.Ins_Name , d.Dept_Name
from Instructor i left join Department d
on d.Dept_Id=i.Dept_Id
--------------------------------------------------------------------------------
--Display student full name and the name of the course he is taking for only courses which have a grade.
select s.St_Fname+s.St_Lname [Full name],c.Crs_Name  ,sc.Grade
from Student s,Stud_Course sc,course c
where s.St_Id=sc.St_Id and sc.Crs_Id=c.Crs_Id and sc.Grade is not null

select s.St_Fname+s.St_Lname [Full name],c.Crs_Name  ,sc.Grade
from Student s inner join Stud_Course sc 
on  s.St_Id=sc.St_Id
inner join course c 
on sc.Crs_Id=c.Crs_Id
where sc.Grade is not null

-----------------------------------------------------------------------------
--Select Student first name and the data of his supervisor. 
select s.St_Fname+s.St_Lname [Student Name], ss.*
from Student s,Student ss
where ss.St_Id=s.St_super

select s.St_Fname+s.St_Lname [Student Name], ss.*
from Student s inner join Student ss
on ss.St_Id=s.St_super
------------------------------------------------------------------------------------
--Display student with the following Format. 
select S.St_Id [Student ID], S.St_Fname + s.St_Lname [Student Full Name] , D.Dept_Name[Department Name] 
from student S ,Department D
where S.Dept_Id=D.Dept_Id

select S.St_Id [Student ID], S.St_Fname + s.St_Lname [Student Full Name] , D.Dept_Name[Department Name] 
from student S inner join Department D
on S.Dept_Id=D.Dept_Id

--------------------------------------------------------------------------------------
select @@VERSION -- thes code prints the virsion name of my SSMS 
-- the @@AnyExprision it is represent the Global Variable in SQL 
select @@SERVERNAME -- thes code prints my Divice name or the server name 
