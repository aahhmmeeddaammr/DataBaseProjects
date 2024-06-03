-------------------DEMO-------------------
Use ITI
-- Select Statement
Select *
from Student

Select St_Id , St_Fname , St_Lname
from Student

Select St_Id , St_Fname , St_Lname ,St_Address
from Student
where St_Id=5

Select St_Id , St_Fname , St_Age
from Student
where St_Age>=23

Select St_Id , St_Fname , St_Age
from Student
where St_Age>=23 and St_Age<=29

Select St_Id , St_Fname , St_Age
from Student
where St_Age between 23 and 29

Select St_Id , St_Fname , St_Age
from Student
where St_Age not between 23 and 29

Select St_Id , St_Fname , St_Address
from Student
where St_Address='Cairo' or St_Address='Alex'

Select St_Id , St_Fname , St_Address
from Student
where St_Address='Cairo' or St_Address='Alex' or St_Address='Mansoura'

Select St_Id , St_Fname , St_Address
from Student
where St_Address in('Cairo' ,'Alex','Mansoura')

Select St_Id , St_Fname , St_Address
from Student
where St_Address not in('Cairo' ,'Alex','Mansoura')

Select *
from Student
where St_super is NULL

Select *
from Student
where St_super is not NULL

Select St_Id , St_Fname
from Student
where St_Fname like '_a%'

Select distinct St_Fname
from Student

Select distinct Dept_Id
from Department
where Dept_Id is not NULL

Select St_Id , St_Fname ,St_Lname
from Student
order by St_Fname 

Select St_Id , St_Fname ,St_Lname
from Student
order by St_Fname Desc

Select *
from Student
order by 2 ,3

--------------------------------------------  Joins  -----------------------------------------------------------

-- 1.cross join
Select S.St_Fname ,D.Dept_Name
from Student S, Department D                    -- ansi

Select S.St_Fname ,D.Dept_Name
from Student S cross join Department D          -- Microsoft



-- 2.Inner join
---- Ansi
Select S.St_Fname ,D.Dept_Name
from Student S, Department D 
where D.Dept_Id=S.Dept_Id

---- Microsoft
Select S.St_Fname , D.Dept_Name
from Student S inner join Department D 
on D.Dept_Id=S.Dept_Id


-- 3.Outer join
---- a) Left Outer Join
Select S.St_Fname , D.Dept_Name
from Student S left Outer join Department D 
on D.Dept_Id=S.Dept_Id

---- b) right Outer Join
Select S.St_Fname , D.Dept_Name
from Student S right Outer join Department D 
on D.Dept_Id=S.Dept_Id

---- a) full Outer Join
Select S.St_Fname , D.Dept_Name
from Student S full Outer join Department D 
on D.Dept_Id=S.Dept_Id


-- 3.Self join
Select Stds.St_Fname 'Student Name' ,Supers.St_Fname 'Supervisor Name'
from Student Stds ,Student Supers 
where Stds.St_super =Supers.St_Id          -- EQUI Join

Select Stds.St_Fname 'Student Name' ,Supers.St_Fname 'Supervisor Name'
from Student Stds inner join Student Supers 
on Stds.St_super =Supers.St_Id          -- Inner Join

Select Stds.St_Fname 'Student Name' ,Supers.*
from Student Stds inner join Student Supers 
on Stds.St_super =Supers.St_Id          -- Inner Join



------------------------------------------------ Multi Tables Join -----------------------------------------------------------------------

--EQUI Join
Select S.St_Fname , C.Crs_Name ,SC.Grade
from Student S ,Stud_Course SC ,Course C
Where S.St_Id = SC.St_Id and C.Crs_Id=SC.Crs_Id and SC.Grade>90

--Inner Join
Select S.St_Fname , C.Crs_Name ,SC.Grade
from Student S inner join Stud_Course SC
on S.St_Id = SC.St_Id
inner join Course C
on C.Crs_Id=SC.Crs_Id 
Where SC.Grade>90
------------------------------------------------ Join + DML -----------------------------------------------------------------------
--update
Update Sc 
	Set Grade += Grade*.1
from Student S ,Stud_Course SC
Where S.St_Id = SC.St_Id and S.St_Address ='Cairo'

Update Sc 
	Set Grade += Grade*.1
from Student S inner join Stud_Course SC
on S.St_Id = SC.St_Id 
where S.St_Address ='Cairo'


--delete

Delete Sc
from Student S ,Stud_Course SC
Where S.St_Id = SC.St_Id and S.St_Address ='Cairo'

Delete Sc
from Student S inner join Stud_Course SC
on S.St_Id = SC.St_Id 
where S.St_Address ='Cairo'