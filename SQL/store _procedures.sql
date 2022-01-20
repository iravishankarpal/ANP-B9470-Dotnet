
create proc proc_employee
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


exec proc_employee;

-- employee_name        employee_city        employee_phoneno
-- -------------------- -------------------- ----------------
-- aman                 west                 88888888
-- dhamu                south                88888888
-- ravi                 ambernat             88888888
-- tooo                 esat                 333333333



alter proc proc_employee
as
begin 
	delete proc_employee where employee_name = 'tooo';
end;



alter proc proc_employee
as
begin 
	select * from proc_employee;
end;



select * from proc_employee;


select proc_employee
as 
begin
	select 
		*
	from 
		proc_employee
	
end;