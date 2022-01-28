select * from employee


-- its as function in sql 
create proc proc_employ
as 
begin
	select 
		employee_name,
		employee_city,
		employee_phoneno
	from 
		employee
	order by
		employee_name asc;
end;

--ececutioni command
proc_employ
exec proc_employ


employee_name        employee_city        employee_phoneno
-------------------- -------------------- ----------------
aman                 west                 88888888
dhamu                south                88888888
ravi                 ambernat             88888888
tooo                 esat                 333333333


-- store procedures funcion with parameters 

change and create are  two key word are use to create  this function
is  and as are key word for sepation from decelaration and main function


proc_employ

alter proc proc_employ
@employee_phoneno as int
as 
begin

	update employee
	set employee_phoneno = @employee_phoneno
	where employee_name = 'ravi'
end

proc_employ 123








--alter in store procedures may lead to crash the sp fuction

alter proc proc_employee
as
begin 
	delete proc_employee where employee_name = 'tooo';
end;



alter proc proc_employee
as
begin 
	select * from proc_employee

end;


