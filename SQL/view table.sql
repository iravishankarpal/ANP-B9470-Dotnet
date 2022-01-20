create view employee_view as select employee_name, employee_city from employee;


select * from employee_view;

-- employee_name        employee_city
-- -------------------- --------------------
-- ravi                 ambernat
-- aeha                 west
-- tooo                 esat
-- fooo                 north
-- dhamu                south



delete from employee_view where employee_name = 'fooo';

select * from employee_view;

-- employee_name        employee_city
-- -------------------- --------------------
-- ravi                 ambernat
-- aeha                 west
-- tooo                 esat
-- dhamu                south


update employee_view set employee_name = 'aman' where employee_city =  'west';

select * from employee_view;

-- employee_name        employee_city
-- -------------------- --------------------
-- ravi                 ambernat
-- aman                 west
-- tooo                 esat
-- dhamu                south

