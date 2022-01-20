CREATE DATABASE dbQuestion2
GO
USE dbQuestion2
GO
CREATE TABLE Department (
			DepartmentNumber	INT IDENTITY(1,1)  PRIMARY KEY 	 NOT NULL
			, DepartmentName	NVARCHAR(30)					 NOT NULL
)
GO
CREATE TABLE Employee 
(
		EmployeeNumber			INT IDENTITY(1,1)  PRIMARY KEY 	 NOT NULL
		, EmployeeName			NVARCHAR(50)					 NOT NULL
		, DepartmentNumber		INT		 REFERENCES Department (DepartmentNumber)			 NOT NULL
)
GO

CREATE TABLE Employee_Skill (
		EmployeeNumber			INT			REFERENCES   Employee (EmployeeNumber)
		, SkillCode			NVARCHAR(50)		
		, DateRegistered		DATE
PRIMARY KEY(EmployeeNumber,SkillCode)
)
GO
INSERT INTO Department   ( DepartmentName)
VALUES					 (N'PHÒNG HỖ TRỢ KHÁCH HÀNG'		)
						,(N'PHÒNG SUPPORT'					)
						,(N' PHÒNG SỰ KIÊN'					)
						,(N'PHÒNG BẢO VỆ'					)
						,(N'PHÒNG KINH DOANH'				)
GO
INSERT INTO Employee		( EmployeeName					, DepartmentNumber)
VALUES						 (N'ĐỖ TUẤN ANH'					,1	)
							,(N'NGUYỄN THU HOÀI'				,2	)
							,(N'ĐỖ MẠNH QUÂN'					,3	)
							,(N'ĐỖ TUẤN'						,4	)
							,(N'NGUYỄN THANH BÌNH'				,2	)
							,(N'HOÀNG THU HẰNG'					,4	)
							,(N'ĐỖ MINH PHÚC'					,3	)
							,(N'ĐỖ MINH HUYỀN'					,2	)
							,(N'PHẠM HỒNG MẠNH'					,1	)
							,(N'NGUYỄN TẤT HƯỚNG'				,5	)
GO
INSERT INTO Employee_Skill (EmployeeNumber	, SkillCode		, DateRegistered)
VALUES							 (7,			N'JAVA',	'2020-9-15')
								,(1					,N'JAVA SWING'			,'2021-05-13'	 )
								,(2					,N'SQL'				,'2020-04-12'	 )
								,(3					,N'PHP'				,'2021-04-11'	 )
								,(4					,N'HTML'			,'2019-03-10'	 )
								,(5					,N'.NET'			,'2020-02-15'	 )
								,(6					,N'C++'				,'2020-02-16'	 )
								,(7					,N'THUYẾT TRÌNH'	,'2019-01-17'	 )
								,(8					,N'PYTHON'			,'2018-11-21'	 )
								,(9					,N'CHỤP ẢNH'		,'2020-11-23'	 )
								,(10				,N'QUAY VIDEO'		,'2021-10-22'	 )
								,(2					,N'EDIT VIDEO'		,'2020-05-27'	 )
								,(1					,N'USING PHOTOSHOP'	,'2016-04-22'	 )
								,(5					,N'DESIGN'			,'2017-03-23'	 )
								
								
GO


SELECT * FROM Department
SELECT * FROM Employee
SELECT * FROM Employee_Skill


SELECT E.EmployeeName 
FROM  Employee_Skill S JOIN Employee E ON S.EmployeeNumber=E.EmployeeNumber
WHERE S.SkillCode='JAVA'
GO
--SUBQUERY
SELECT E.EmployeeName 
FROM   Employee E 
WHERE E.EmployeeNumber IN (SELECT ES.EmployeeNumber
						FROM Employee_SkilL ES
						WHERE ES.SkillCode='JAVA')
GO
--QUERY3
SELECT D.DepartmentName,E.EmployeeName 
FROM   Employee E JOIN  Department D ON E.DepartmentNumber=D.DepartmentNumber
WHERE D.DepartmentNumber IN (SELECT DepartmentNumber
							FROM   Employee 
							GROUP BY DepartmentNumber
							HAVING COUNT(EmployeeNumber)>=3)
GO
--QUERY4
SELECT E.EmployeeNumber, EmployeeName
FROM   Employee E
WHERE E.EmployeeNumber IN (SELECT EmployeeNumber
							FROM   Employee_Skill
							GROUP BY EmployeeNumber
							HAVING COUNT(SkillCode)>=2)
GO

---QUERY5
CREATE VIEW V_Employees
AS
SELECT E.EmployeeNumber, EmployeeName, D.DepartmentName
FROM   Employee E JOIN  Department D ON E.DepartmentNumber=D.DepartmentNumber
WHERE E.EmployeeNumber IN (SELECT EmployeeNumber
							FROM   Employee_Skill
							GROUP BY EmployeeNumber
							HAVING COUNT(SkillCode)>1)
GO

SELECT * FROM V_Employees
GO



