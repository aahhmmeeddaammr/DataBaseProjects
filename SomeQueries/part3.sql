-----------------------PART#3--------------------------------
use MyCompany;
--Display the Department id, name and id and the name of its manager.
select d.Dnum [Department ID] , D.Dname [Department name], E.Fname [Manager Name]
from Departments D,Employee E
where D.MGRSSN=E.SSN -- EQUI

select d.Dnum [Department ID] , D.Dname [Department name], E.Fname [Manager Name]
from Departments D inner join Employee E
on D.MGRSSN=E.SSN -- inner Join 
----------------------------------------------------------------------------------------------
--Display the name of the departments and the name of the projects under its control

select D.Dname [Department Name],p.Pname [Project Name]
from Departments D, Project p
where D.Dnum=p.Dnum --EQUI

select D.Dname [Department Name],p.Pname [Project Name]
from Departments D, Project p
where D.Dnum=p.Dnum --inner Join
--------------------------------------------------------------------------------
--Display the full data about all the dependence associated with the name of the employee they depend on.

select d.* , E.Fname[depend on]
from Dependent D, Employee E
where D.ESSN=E.SSN --EQUI 

select d.* , E.Fname[depend on]
from Dependent D inner Join Employee E
on D.ESSN=E.SSN --inner 
--------------------------------------------------------------------------------

--Display the Id, name, and location of the projects in Cairo or Alex city.
select p.Pnumber ID , p.Pname NAME ,p.Plocation 
from Project p
where City='Alex'or City='Cairo'

select p.Pnumber ID , p.Pname NAME ,p.Plocation 
from Project p
where City in('Alex' ,'Cairo')
--------------------------------------------------------------------------------
--Display the Projects full data of the projects with a name starting with "a" letter.
select *
from Project p
where p.Pname like 'a%'
--display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select *
from Employee
where Salary between 1000 and 2000
--Retrieve the names of all employees in department 10 who work more than or equal 10 hours per week on the "AL Rabwah" project.
select * 
from  Employee e ,Works_for wf ,Project p
where e.Dno=10 and e.SSN=wf.ESSn and wf.Pno=p.Pnumber and wf.Hours>=10 and p.Pname='AL Rabwah' --EQUI

select * 
from  Employee e inner Join Works_for wf 
on e.SSN=wf.ESSn 
inner join Project p
on wf.Pno=p.Pnumber
where e.Dno=10 and wf.Hours>=10 and p.Pname='AL Rabwah'
--------------------------------------------------------------------------------

--Find the names of the employees who were directly supervised by Kamel Mohamed
select E1.Fname [Employee Name] ,E2.Fname [supervisor Name]
from Employee E1,Employee E2
where E1.Superssn=E2.SSN and E2.Fname='Kamel' and  E2.Lname='Mohamed' --EQUI

select E1.Fname [Employee Name] ,E2.Fname [supervisor Name]
from Employee E1 inner Join Employee E2
on E1.Superssn=E2.SSN 
where E2.Fname='Kamel' and  E2.Lname='Mohamed'--Inner Join 
--------------------------------------------------------------------------------
--Display All Data of the managers
select E2.*
from Employee E1,Employee E2
where E1.Superssn=E2.SSN --EQUI

select E2.*
from Employee E1 inner Join Employee E2
on  E1.Superssn=E2.SSN --inner Join
--------------------------------------------------------------------------------
--Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
select e.Fname ,p.Pname
from  Employee e ,Works_for wf ,Project p
where  e.SSN=wf.ESSn and wf.Pno=p.Pnumber
Order By p.Pname --EQUI

select e.Fname ,p.Pname
from  Employee e inner Join Works_for wf 
on e.SSN=wf.ESSn 
inner Join Project p 
on wf.Pno=p.Pnumber
Order By p.Pname
--------------------------------------------------------------------------------
--For each project located in Cairo City, find the project number, the controlling department name, the department manager’s last name, address and birthdate.
select p.Pname , D.Dname , E.Lname
from project p ,Departments D ,Employee E
where p.City='Cairo' and D.Dnum=p.Dnum and E.SSN=D.MGRSSN --EQUI

select p.Pname , D.Dname , E.Lname
from project p inner Join Departments D 
on D.Dnum=p.Dnum
inner Join Employee E 
on  E.SSN=D.MGRSSN
where p.City='Cairo'--inner Join
--------------------------------------------------------------------------------
--Display All Employees data and the data of their dependents even if they have no dependents.
select E.*,D.*
from Employee E left join  Dependent D
on E.SSN=D.ESSN
---------------------------------------------------------------------------------
