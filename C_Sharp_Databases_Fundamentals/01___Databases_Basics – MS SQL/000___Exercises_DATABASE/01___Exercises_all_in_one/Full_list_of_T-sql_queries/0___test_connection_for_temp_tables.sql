CREATE TABLE #PersonDetails( 
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(50)
)
INSERT INTO #PersonDetails
VALUES
('x'),
('y'),
('z')

select * from #PersonDetails
SELECT [NAME] FROM tempdb..sysobjects
WHERE NAME LIKE '%#PersonDetails%'

-- Global temp tables are accesible  because they are visible from all the connections
select * from ##EmployeeDetails

-- that's why i cannot create a table with the same name from this connection 
CREATE TABLE ##EmployeeDetails( 
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(50)
)
INSERT INTO ##EmployeeDetails
VALUES
('x'),
('y'),
('z')

SELECT * FROM ##EmployeeDetails
-- |||||||||||||||||||||||||||||||||||||||||||||||||        1        |||||||||||||||||||||||||||||||||||||||||||||||||
-- TEST QUERIE FOR TRANSACTION TO SIMULATE DEADLOCK
-- -----------------------------------------------------------
begin transaction
update People
set Firstname = 'testname'
where id = 2

rollback


begin transaction

update UserInfoTable 
SET FirstName = 'testname' 
where id = 27 
-- -----------------------------------------------
-- trying to access from this connection  the same table which is already being executed in transaction with update statement from another connection
SELECT * FROM UserInfoTable WHERE ID = 27 -- option one - this is statement executed from other connection with transaction
SELECT * FROM UserInfoTable WHERE ID = 28 -- option two 
SELECT * FROM UserInfoTable -- option three



BEGIN TRANSACTION
select * from UserInfoTable ut where id = 27
rollback
UPDATE UserInfoTable
SET Salary = 6666666 WHERE ID = 27




-- |||||||||||||||||||||||||||||||||||||||||||||||||        2        |||||||||||||||||||||||||||||||||||||||||||||||||
-- ISOLATION LEVELS

set transaction isolation level read committed
-- simulate dirty read
set transaction isolation level read uncommitted
select * from UserInfoTable(nolock) where id = 27  -- when we want to read during execution of another tran


-- lost update 
set transaction isolation level repeatable read

begin transaction
declare @salary_decrease int 

select @salary_decrease = ut.Salary from UserInfoTable ut where ut.Id = 27

waitfor delay '00:00:1'
select @salary_decrease -= 20

update UserInfoTable
set Salary = @salary_decrease 
where id = 27
print  @salary_decrease
commit tran

rollback

-- non repeatable read 

-- Transaction 2
Update UserInfoTable 
   set Salary = 666 
 where Id = 27

 -- - SERIALIZABLE  isolation level

 set transaction isolation level serializable   

 begin tran
select Salary 
  from UserInfoTable 
 where id = 27

  rollback

-- SNAPSHOT  isolation level 
set transaction isolation level snapshot

 begin tran
update UserInfoTable
  set Salary +=66 
 where id = 27

  commit tran