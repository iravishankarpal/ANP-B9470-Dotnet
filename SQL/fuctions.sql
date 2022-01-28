create function fun_employee
as
begin 
	select 
		employee_name,


		employee_city,
		employee_phoneno
	from 
		employee
	
	return fun_employee
end