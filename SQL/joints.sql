
--new table
create table department(
dep_id int primary key not null,
dep_name varchar(20) not null);


insert into department values (1,'compes'), (2,'java'), (3,'python'), (4,'c++') ,(5,'ruby');
insert into department values (6,'ravi');

select * from employee;


-- inner  join
insert into department values (1,'compes'), (2,'java'), (3,'python'), (4,'c++') ,(5,'ruby');

select * from employee;

select e1.employee_id,e1.employee_name,d1.dep_name 
from employee AS e1 inner join department AS d1 on e1.employee_id = d1.dep_id order by employee_id;

-- employee_id employee_name        dep_name
-- ----------- -------------------- --------------------
-- 1           ravi                 compes
-- 2           aman                 java
-- 3           tooo                 python
-- 5           dhamu                ruby


-- full join 
select e1.employee_id,e1.employee_name,d1.dep_name 
from employee as e1 full join department as d1 on e1.employee_name = d1.dep_name;

-- employee_id employee_name        dep_name
-- ----------- -------------------- --------------------
-- 1           ravi                 ravi
-- 2           aeha                 NULL
-- 3           tooo                 NULL
-- 4           fooo                 NULL
-- 5           dhamu                NULL
-- NULL        NULL                 compes
-- NULL        NULL                 java
-- NULL        NULL                 python
-- NULL        NULL                 c++
-- NULL        NULL                 ruby

-- left join
select e1.employee_id,e1.employee_name,d1.dep_name
 from employee as e1 left join department as d1 on e1.employee_name = d1.dep_name;

--  employee_id employee_name        dep_name
-- ----------- -------------------- --------------------
-- 1           ravi                 ravi
-- 2           aman                 NULL
-- 3           tooo                 NULL
-- 5           dhamu                NULL

--  right join

select e1.employee_id,e1.employee_name,d1.dep_name
 from employee as e1 right join department as d1 on e1.employee_name = d1.dep_name;


--  ----------- -------------------- --------------------
-- NULL        NULL                 compes
-- NULL        NULL                 java
-- NULL        NULL                 python
-- NULL        NULL                 c++
-- NULL        NULL                 ruby
-- 1           ravi                 ravi


--  cross join

select e1.employee_id,e1.employee_name,d1.dep_name 
from employee as e1 cross join department as d1;


-- employee_id employee_name        dep_name
-- ----------- -------------------- --------------------
-- 1           ravi                 compes
-- 1           ravi                 java
-- 1           ravi                 python
-- 1           ravi                 c++
-- 1           ravi                 ruby
-- 1           ravi                 ravi
-- 2           aman                 compes
-- 2           aman                 java
-- 2           aman                 python
-- 2           aman                 c++
-- 2           aman                 ruby
-- 2           aman                 ravi
-- 3           tooo                 compes
-- 3           tooo                 java
-- 3           tooo                 python
-- 3           tooo                 c++
-- 3           tooo                 ruby
-- 3           tooo                 ravi
-- 5           dhamu                compes
-- 5           dhamu                java
-- 5           dhamu                python
-- 5           dhamu                c++
-- 5           dhamu                ruby
-- 5           dhamu                ravi
