------------------------------****PART#4****-------------------------------------
use MyCompany;
--Retrieve a list of employees and the projects they are working on ordered by department and within each department, alphabetically by last name, first name
select e.Fname , p.Pname ,p.Dnum
from Employee E ,Works_for WF ,Project p ,Departments D
where e.SSN= wf.ESSn and wf.Pno=p.Pnumber and p.Dnum=D.Dnum
order by D.Dnum , e.Fname ,e.Lname --Equi

select e.Fname , p.Pname ,p.Dnum
from Employee E inner join Works_for WF 
on  e.SSN= wf.ESSn
inner Join Project p 
on wf.Pno=p.Pnumber
inner join Departments D 
on p.Dnum=D.Dnum
order by D.Dnum , e.Fname ,e.Lname -- inner Join 

--------------------------------------------------------------------------------
--Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30% 	
update E
set e.Salary =e.Salary*1.3
from Employee E, Works_for wf , Project p
where e.SSN =wf.ESSn and p.Pnumber =wf.Pno and p.Pname='Al Rabwah'

update E
set e.Salary =e.Salary*1.3
from Employee E inner Join  Works_for wf 
on e.SSN =wf.ESSn 
inner Join  Project p 
on p.Pnumber =wf.Pno
where  p.Pname='Al Rabwah' -- DML+DQL(inner JOIN )

--In the department table insert a new department called "DEPT IT”, with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'
insert into Departments
values ('DEPT IT',100,112233,'1-11-2006')

--Do what is required if you know that: Mrs. Oha Mohamed (SSN=968574) moved to be the manager of the new department (id = 100), and they give you (your SSN =102672) her position (Dept. 20 manager)
--1->First try to update her record in the department table.
update Departments
set MGRSSN = '968574'
where Dnum = 100
--2->Update your record to be department 20 manager.
update Departments 
set MGRSSN = '102672'
where Dnum = 20 
--3->Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)
update Employee 
set Superssn = '102672'
where SSN = '102660'


--Unfortunately, the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so try to delete him from your database in case you know that you will be temporarily in his position.

--DELETE ALL DEPENDENTS WHO ARE RELATED TO 
delete from Dependent
where ESSN=223344
--Delete All Forigen Keies  from tables Employee and Deparments
update Departments
set MGRSSN=null , [MGRStart Date]=null
where MGRSSN=223344
update Employee
set Superssn=null
where Superssn=223344
--Delete Him From Projects
delete from Works_for
where ESSn=223344
--Delete The Employee
delete from Employee 
where ssn=223344

