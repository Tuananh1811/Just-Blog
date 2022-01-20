-- Create table Employee, Status = 1: are working
USE MASTER
GO
CREATE DATABASE dbEMS
GO
USE dbEMS
GO

CREATE TABLE [dbo].[Employee](
[EmpNo] [int] NOT NULL
, [EmpName] [nchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT
NULL
, [BirthDay] [datetime] NOT NULL
, [DeptNo] [int] NOT NULL
, [MgrNo] [int]
, [StartDate] [datetime] NOT NULL
, [Salary] [money] NOT NULL
, [Status] [int] NOT NULL
, [Note] [nchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
, [Level] [int] NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE Employee
ADD CONSTRAINT PK_Emp PRIMARY KEY (EmpNo)
GO

ALTER TABLE [dbo].[Employee]
ADD CONSTRAINT [chk_Level]
CHECK (([Level]=(7) OR [Level]=(6) OR [Level]=(5) OR [Level]=(4)
OR [Level]=(3) OR [Level]=(2) OR [Level]=(1)))
GO
ALTER TABLE [dbo].[Employee]

ADD CONSTRAINT [chk_Status]
CHECK (([Status]=(2) OR [Status]=(1) OR [Status]=(0)))

GO
ALTER TABLE [dbo].[Employee]
ADD Email NCHAR(30)
GO

ALTER TABLE [dbo].[Employee]
ADD CONSTRAINT chk_Email CHECK (Email IS NOT NULL)
GO

ALTER TABLE [dbo].[Employee]
ADD CONSTRAINT chk_Email1 UNIQUE(Email)

GO
ALTER TABLE Employee
ADD CONSTRAINT DF_EmpNo DEFAULT 0 FOR EmpNo

GO
ALTER TABLE Employee
ADD CONSTRAINT DF_Status DEFAULT 0 FOR Status

GO
CREATE TABLE [dbo].[Skill](
[SkillNo] [int] IDENTITY(1,1) NOT NULL
, [SkillName] [nchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT
NULL
, [Note] [nchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]

GO
ALTER TABLE Skill

ADD CONSTRAINT PK_Skill PRIMARY KEY (SkillNo)

GO
CREATE TABLE [dbo].[Department](
[DeptNo] [int] IDENTITY(1,1) NOT NULL
, [DeptName] [nchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT
NULL
, [Note] [nchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]

GO
ALTER TABLE Department
ADD CONSTRAINT PK_Dept PRIMARY KEY (DeptNo)

GO
CREATE TABLE [dbo].[Emp_Skill](
[SkillNo] [int] NOT NULL
, [EmpNo] [int] NOT NULL
, [SkillLevel] [int] NOT NULL
, [RegDate] [datetime] NOT NULL
, [Description] [nchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS
NULL
) ON [PRIMARY]

GO
ALTER TABLE Emp_Skill
ADD CONSTRAINT PK_Emp_Skill PRIMARY KEY (SkillNo, EmpNo)
GO

ALTER TABLE Employee
ADD CONSTRAINT [FK_1] FOREIGN KEY([DeptNo])
REFERENCES Department (DeptNo)

GO

ALTER TABLE Emp_Skill
ADD CONSTRAINT [FK_2] FOREIGN KEY ([EmpNo])
REFERENCES Employee([EmpNo])

GO
ALTER TABLE Emp_Skill
ADD CONSTRAINT [FK_3] FOREIGN KEY ([SkillNo])
REFERENCES Skill([SkillNo])

GO

SELECT *FROM Employee

INSERT INTO Department(DeptName,Note) 
VALUES		('DO MANH QUAN ','QL NHAN SU')
			,('DO TUAN ANH','QL VAN PHONG')
			,('NGUYEN VAN A','QL TAI CHINH')
			,('NGUYEN VAN B','QL PHONG KINH DOANH')
			,('NGUYEN VAN C','QL PHONG KE TOAN')
			,('NGUYEN VAN D','QL PHONG DAO TAO')
			,('NGUYEN VAN E','QL PHONG PHAT TRIEN')
			,('NGUYEN VAN F','QL PHONG VE SINH')
			,('NGUYEN VAN G','QL BAO VE')
			,('NGUYEN VAN H','QL PHONG MARKETTING')

INSERT INTO Skill(SkillName,Note)
VALUES		('.NET','.NET')
			,('SQL','KY NANG SQL')
			,('C','KY NANG C')
			,('C++','KY NANG C++')
			,('OOP','KY NANG OOP')
			,('JAVA','KY NANG JAVA')
			,('C#','KY NANG C#')
			,('HTML',N'KY NANG HTML')
			,('CSS','KY NANG CSS')
			,('JAVASCRIPT','JAVASCRIPT')
			
SELECT *FROM Employee
INSERT INTO Employee(EmpNo,EmpName,BirthDay,DeptNo,MgrNo,StartDate,Salary,Status,Note,Level,Email)
VALUES		(1,'DO TUAN ANH','2000-11-18',1,2,'2021-09-20',123455,1,'',1,'TANHDO18@GMAIL.COM')
			,(2,'DO TUAN ANH 2','2000-11-23',3,1,'2021-09-22',43132,1,'',2,'TANHDO13@GMAIL.COM')
			,(3,'DO MANH QUAN','1992-12-10',3,4,'2021-08-21',433132,1,'',3,'QUAN1012@GMAIL.COM')
			,(4,'DO VAN H','2000-11-23',5,3,'2021-09-22',263132,1,'',1,'@GMAIL.COM')
			,(5,'DO V G','2003-11-23',6,2,'2021-09-22',62532,2,'',2,'TANHDO00@GMAIL.COM')
			,(6,'DO TUAN','2000-11-23',6,1,'2021-09-22',1000,2,'',2,'18@GMAIL.COM')
			,(7,'DO VAN T','2000-11-23',3,1,'2021-09-12',13200,1,'',2,'DO18@GMAIL.COM')
			,(8,'DO TR','2000-11-23',7,2,'2021-09-22',3132,0,'',5,'HDO18@GMAIL.COM')
SELECT *FROM Employee
SELECT *FROM Emp_Skill
INSERT INTO Emp_Skill(SkillNo,EmpNo,SkillLevel,RegDate,[Description])
VALUES		(8,1,2,'2023-1-21','')
			,(7,1,2,'2022-1-21','')
			,(6,1,2,'2021-3-21','')
			,(28,1,2,'2021-3-21','')
			,(1,2,2,'2021-3-21','')
			,(2,3,1,'2020-3-21','')
			,(2,7,2,'2021-6-21','')
			,(3,8,2,'2021-5-21','')
			,(1,3,1,'2021-6-21','')
			,(2,6,2,'2021-7-21','')
			,(2,5,1,'2021-7-21','')
			,(1,4,2,'2021-8-21','')
			,(2,2,1,'2021-12-21','')
			,(1,1,2,'2021-3-21','')
			
SELECT *FROM Emp_Skill	
SELECT *FROM Skill

/*Specify the names of the employees whore have either ‘C++’ or ‘.NET’ skills.*/

SELECT A.EmpName AS 'TEN NHAN VIEN CO SKILL LA C#||.NET' FROM Employee A
JOIN Emp_Skill B ON A.EmpNo= B.EmpNo JOIN Skill C ON B.SkillNo=C.SkillNo
WHERE C.SkillName='C++' OR C.SkillName='.NET'
GO

/*Specify the name, email and department name of the employees that have been
working at least six months.*/
SELECT Employee.EmpName AS 'HỌ TÊN', Employee.Email AS'EMAIL', Department.DeptName AS 'PHÒNG BAN'
FROM Employee
JOIN Department ON Employee.DeptNo=Department.DeptNo
JOIN Emp_Skill ON Employee.EmpNo =Emp_Skill.EmpNo
WHERE DATEDIFF(month, Employee.StartDate, Emp_Skill.RegDate)>=6
GO
/*
List all employee names, manager names, manager emails of those employees.
*/
--SELF JOIN
SELECT A.EmpName AS 'HO TEN' , B.EmpName AS 'QUAN LY', B.Email AS 'Email'
FROM Employee A LEFT JOIN Employee B ON A.MgrNo=B.EmpNo
WHere B.EmpName IS NOT NULL

/*
Specify the departments which have >=2 employees, print out the list of departments’
*/
SELECT  A.DeptName AS 'PHONG BAN', B.EmpName 'HO TEN' 
FROM Department A JOIN Employee B  ON B.DeptNo = A.DeptNo
WHERE A.DeptName IN (select A.DeptName from Department RIGHT JOIN Employee on Employee.DeptNo = Department.DeptNo
					group by Department.DeptName
					having COUNT(Department.DeptNo) >= 2)

/*
List all name, email and number of skills of the employees and sort ascending order
by employee’s name.
*/
SELECT Employee.EmpName AS 'HO TEN', Employee.Email AS 'EMAIL' 
								,  COUNT(Emp_Skill.SkillNo) AS 'SKILL'	
FROM Skill
JOIN Emp_Skill ON Skill.SkillNo=Emp_Skill.EmpNo
JOIN Employee ON Emp_Skill.EmpNo=Employee.EmpNo
GROUP BY Employee.EmpName, Employee.Email
ORDER BY Employee.EmpName ASC

/*
Use SUB-QUERY technique to list out the different employees (include name, email,
birthday) who are working and have multiple skills.
*/
SELECT Employee.EmpName AS 'HO TEN', Employee.Email AS 'EMAIL' , Employee.BirthDay 'SINH NHAT'
FROM Employee
WHERE Employee.[Status] !=0 AND Employee.EmpNo IN (SELECT Employee.EmpNo
												  FROM	  Employee join Emp_Skill on Emp_Skill.EmpNo=Employee.EmpNo
												  GROUP BY	 Employee.EmpNo 
												  HAVING	 COUNT(Emp_Skill.EmpNo)>=1)
/*
Create a view to list all employees are working (include: name of employee and skill
name, department name).
*/
CREATE VIEW LIST_ALL_EMP AS
SELECT Employee.EmpName AS 'HO TEN', Skill.SkillName 'SKILL', Department.DeptName 'PHONG BAN'
FROM Employee JOIN Department	ON	Employee.DeptNo=Department.DeptNo
			  JOIN Emp_Skill	ON	Employee.EmpNo=Emp_Skill.EmpNo
			  JOIN Skill		ON	Emp_Skill.SkillNo= Skill.SkillNo
WHERE Employee.[Status]=1
GO

SELECT * FROM LIST_ALL_EMP
GO