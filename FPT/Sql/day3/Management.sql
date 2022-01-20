CREATE DATABASE MANAGEMENT
GO
USE MANAGEMENT 
GO
-----Q1: Create the table
CREATE TABLE Trainee(
	TraineeID		INT IDENTITY PRIMARY KEY
   ,Full_Name		NVARCHAR(50) 
   ,Birth_Date		DATE
   ,Gender			BIT
   ,ET_IQ			INT CHECK (ET_IQ>=0 AND ET_IQ<=20)
   ,ET_Gmath		INT CHECK (ET_Gmath>=0 AND ET_Gmath<=20)
   ,ET_English		INT CHECK (ET_English>=0 AND ET_English<=50)
   ,Training_Class	CHAR(5)
   ,Evalution_Notes NVARCHAR(50)
)
INSERT INTO Trainee (Full_Name,					Birth_Date,			Gender,		ET_IQ,	ET_Gmath,	ET_English,		Training_Class,		Evalution_Notes)
VALUES				(N'Nguyễn Thanh Bình',		'2000-05-02',		 0,		    13,	    15,		    35,			    'CPL01',			'DHCNHN'),
					(N'Đỗ Tuấn Anh',	       	'2000-05-07',		 1,		    17,	    16,		    25,			    'CPL01',			'DHCNHN'),
                    (N'Hoàng Thu Hằng',		  	'2000-05-09',		 0,		    12,	    18,		    40,			    'CPL01',			'DHCNHN'),
                    (N'Nguyễn Hoàng Lan',		'2000-02-15',		 0,		    18,	    18,		    45,			    'CPL02',			'DHFPT'),
                    (N'Nguyễn Đình Nam',	    '2000-04-11',		 1,		    10,	    12,		    32,			    'CPL02',			'DHFPT'),
                    (N'Nguyễn Đình Doanh',		'2000-06-07',		 1,		    11,	    15,		    38,			    'CPL02',			'DHCNHN'),
                    (N'Phạm Thị Minh Tú',		'2000-03-12',		 0,		    19,	    17,		    47,			    'CPL03',			'DHFPT'),
                    (N'Nguyễn Nam Anh',		    '2000-09-15',		 1,		    14,	    16,		    41,			    'CPL03',			'DHBCVT'),
                    (N'Nguyễn Thị Yến',		    '2000-06-08',		 0,		    17,	    12,		    44,			    'CPL03',			'DHHN'),
                    (N'Hà Mạnh Cường',		    '2000-06-07',		 1,		    13,	    17,		    46,			    'CPL03',			'DHBKHN')
GO

ALTER TABLE Trainee ADD Fsoft_Account VARCHAR(10) NULL
GO

UPDATE Trainee 
SET    Fsoft_Account = 'BinhNT66'
Where  TraineeID     = 1
GO

UPDATE Trainee 
SET    Fsoft_Account = 'ADT12'
Where  TraineeID     = 2
GO

UPDATE Trainee 
SET    Fsoft_Account = 'HHT18'
Where  TraineeID     = 3
GO

UPDATE Trainee 
SET    Fsoft_Account = 'LanNH10'
Where  TraineeID     = 4
GO

UPDATE Trainee 
SET    Fsoft_Account = 'NamND'
Where  TraineeID     = 5
UPDATE Trainee 
SET    Fsoft_Account = 'DoanhND26'
Where  TraineeID     = 6
GO

UPDATE Trainee 
SET    Fsoft_Account = 'TuPTM92'
Where  TraineeID     = 7
GO

UPDATE Trainee 
SET    Fsoft_Account = 'AnhNN12'
Where  TraineeID     = 8
GO

UPDATE Trainee 
SET    Fsoft_Account = 'YenNT60'
Where  TraineeID     = 9
GO

UPDATE Trainee 
SET    Fsoft_Account = 'CuongHM'
Where  TraineeID     = 10
GO
------Q2:Change the table TRAINEE to add one more field named Fsoft_Account which is a not-null & unique
ALTER TABLE Trainee ALTER COLUMN Fsoft_Account VARCHAR(10) NOT NULL
GO

ALTER TABLE Trainee ADD CONSTRAINT Unique_Fsoft_Account UNIQUE(Fsoft_Account)
GO

-----Q3:Create a View 
CREATE VIEW ET_passed
AS
SELECT *
FROM   Trainee
WHERE ET_IQ + ET_Gmath >=20
	  AND ET_IQ        >=8
	  AND ET_Gmath     >=8
	  AND ET_English   >=18
GO

SELECT * FROM ET_passed
GO

-----Q4: Query all the trainees who is pased the entry test, group them into different birth months.
SELECT * FROM ET_passed
ORDER BY MONTH(Birth_Date)
GO
-----Q5: Query the trainee who has the longes name, showing his/her ago along with his/her basic information
SELECT TraineeID,
	   Full_Name,
	   Birth_Date,
	   Gender,
	   ET_IQ, 
	   ET_Gmath,
	   ET_English,
	   Training_Class,
	   Evalution_Notes,
	   Fsoft_Account,
	   YEAR(GETDATE()) - YEAR(Birth_Date) AS 'Age'
FROM   Trainee 
WHERE  LEN(Full_Name) =(SELECT MAX(LEN(Full_Name)) FROM Trainee)
GO