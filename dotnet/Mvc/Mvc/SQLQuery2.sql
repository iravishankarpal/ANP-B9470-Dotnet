Create procedure [dbo].[AddNewEmpDetails]  
(  @id int,
   @name varchar (50),  
   @city varchar (50),  
   @address varchar (50)  
)  
as  
begin  
   Insert into Employee values(@id,@name,@city,@address)  
End
;

Create Procedure [dbo].[GetEmployees] 
as 
begin 
 select *from Employee 
End

Create procedure [dbo].[UpdateEmpDetails] 
( 
 @Id int, 
 @Name varchar (50), 
 @City varchar (50), 
 @Address varchar (50) 
) 
as 
begin 
 Update Employee 
 set Name=@Name, 
 City=@City, 
 Address=@Address 
 where Id=@Id 
End


Create procedure [dbo].[DeleteEmpById] 
( 
 @EmpId int 
) 
as 
begin 
 Delete from Employee where Id=@EmpId 
End
