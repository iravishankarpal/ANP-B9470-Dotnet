-- inner  join
insert into department values (1,'compes'), (2,'java'), (3,'python'), (4,'c++') ,(5,'ruby');

select * from employee;

select e1.employee_id,e1.employee_name,d1.dep_name 
from employee AS e1 inner join department AS d1 on e1.employee_id = d1.dep_id order by employee_id;


-- full join 
select e1.employee_id,e1.employee_name,d1.dep_name 
from employee as e1 full join department as d1 on e1.employee_name = d1.dep_name;

-- left join
select e1.employee_id,e1.employee_name,d1.dep_name
 from employee as e1 left join department as d1 on e1.employee_name = d1.dep_name;

--  right join

select e1.employee_id,e1.employee_name,d1.dep_name
 from employee as e1 right join department as d1 on e1.employee_name = d1.dep_name;


--  cross join

select e1.employee_id,e1.employee_name,d1.dep_name 
from employee as e1 cross join department as d1;