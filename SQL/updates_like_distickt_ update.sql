select * from employee;


/*
employee_id employee_name        employee_phoneno employee_city
----------- -------------------- ---------------- --------------------
1           ravi                 88888888         ambernat
2           aeha                 88888888         west
3           tooo                 333333333        esat
4           fooo                 88888888         north
5           dhamu                88888888         south
*/



select * from department;
/*
dep_id      dep_name
----------- --------------------
1           compes
2           java
3           python
4           c++
5           ruby
6           ravi
*/


update employee set employee_phoneno = 333333333 where employee_id = 3;

-- 1 row effected
select * from employee;

/*
employee_id employee_name        employee_phoneno employee_city
----------- -------------------- ---------------- --------------------
1           ravi                 88888888         ambernat
2           aeha                 88888888         west
3           tooo                 333333333        esat
4           fooo                 88888888         north
5           dhamu                88888888         south

(5 rows affected)
*/




--like clause


 select * from employee where employee_phoneno like '3%';

--  employee_id employee_name        employee_phoneno employee_city
-- ----------- -------------------- ---------------- --------------------
-- 3           tooo                 333333333        esat



  select * from employee where employee_phoneno like '8%';



--   employee_id employee_name        employee_phoneno employee_city
-- ----------- -------------------- ---------------- --------------------
-- 1           ravi                 88888888         ambernat
-- 2           aeha                 88888888         west
-- 4           fooo                 88888888         north
-- 5           dhamu                88888888         south




  select * from employee where employee_name like '_a%';

--   employee_id employee_name        employee_phoneno employee_city
-- ----------- -------------------- ---------------- --------------------
-- 1           ravi                 88888888         ambernat



--orderby 
-- SELECT column-list
-- FROM table_name
-- [WHERE condition]
-- [ORDER BY column1, column2, .. columnN] [ASC | DESC]


select  employee_name,employee_id,employee_city from employee order by employee_city desc;

-- employee_name        employee_id employee_city
-- -------------------- ----------- --------------------
-- aeha                 2           west
-- dhamu                5           south
-- fooo                 4           north
-- tooo                 3           esat
-- ravi                 1           ambernat


select  employee_name,employee_id,employee_city from employee order by employee_name asc;


-- employee_name        employee_id employee_city
-- -------------------- ----------- --------------------
-- aeha                 2           west
-- dhamu                5           south
-- fooo                 4           north
-- ravi                 1           ambernat
-- tooo                 3           esat


--group by 


select employee_name , sum(employee_id) from employee group by employee_name;


-- employee_name        
-- -------------------- -----------
-- aeha                 2
-- dhamu                5
-- fooo                 4
-- ravi                 1
-- tooo                 3


--DISTINCT
-- for removing duplicate values



select distinct  employee_phoneno from employee order by employee_phoneno desc;

-- employee_phoneno
-- ----------------
-- 333333333
-- 88888888


--




