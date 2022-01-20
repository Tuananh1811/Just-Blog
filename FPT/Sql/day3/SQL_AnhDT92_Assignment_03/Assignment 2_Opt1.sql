go
use master﻿
CREATE DATABASE FresherDB
GO
USE FresherDB
GO
DROP DATABASE FresherDB
GO

--a: create table and insert records
CREATE TABLE Trainee
(
	TraineeID INT IDENTITY  PRIMARY KEY
	,Full_Name NVARCHAR(50)	NOT NULL
	, Birth_Date DATE
	, Gender BIT 
	, ET_IQ INT CHECK(ET_IQ>=0 AND ET_IQ<=20)
	, ET_Gmath  INT CHECK(ET_Gmath>=0 AND ET_Gmath<=20)
	, ET_English  INT CHECK(ET_English>=0 AND ET_English<=50)
	, Training_Class INT 
	,Evaluation_Notes NVARCHAR(100)
)
GO
 INSERT INTO Trainee VALUES
 (N'Đỗ Mạnh Quân','1992-12-19',1,10,10,20,1,N'Vĩnh Phúc'),
 (N'Tuấn Anh','2000-11-18',1,11,18,21,2,N'Vĩnh Phúc'),
 (N'Phạm Hồng Mạnh','2000-11-12',1,11,17,31,3,N'Hải Dương'),
 (N'Đỗ Tuấn Anh','2000-11-18',1,6,16,11,5,N'Vĩnh Phúc'),
 (N'Nguyễn Thanh Bình','2000-05-02',0,7,7,20,4,N'Bắc Ninh'),
 (N'Nguyễn Tất Hướng','2000-09-09',1,8,7,5,7,N'Bắc Giang'),
 (N'Phạm Thùy Linh','2000-09-02',0,18,9,3,6,N'Thái Bình'),
 (N'Hoàng Thu Hằng','2000-10-2',0,10,10,8,5,N'Bắc Giang'),
 (N'Vũ Kim Anh','2000-10-2',0,10,10,42,9,N'Hải Dương'),
 (N'Phùng Văn Đại','2000-4-14',1,10,10,31,10,N'Thanh Hóa')
 GO
 ALTER TABLE Trainee ADD Fsoft_Account VARCHAR(10) NULL
GO

UPDATE Trainee 
SET    Fsoft_Account = 'AnhDT92'
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
 --b Change the table TRAINEE to add one more field named Fsoft_Account which is a not-null & unique
 ALTER TABLE Trainee ALTER COLUMN  Fsoft_Account VARCHAR(50) NOT NULL;

 ALTER TABLE Trainee ADD CONSTRAINT UN_Trainee_Account UNIQUE (Fsoft_Account);
GO

--c 
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


--d Query all the trainees who is pased the entry test, group them into different birth months.
SELECT * FROM ET_passed
ORDER BY MONTH(Birth_Date)
GO


--e Query the trainee who has the longes name, showing his/her ago along with his/her basic information
SELECT TraineeID,
	   Full_Name,
	   Birth_Date,
	   Gender,
	   ET_IQ, 
	   ET_Gmath,
	   ET_English,
	   Training_Class,
	   Evaluation_Notes,
	   Fsoft_Account,
	   YEAR(GETDATE()) - YEAR(Birth_Date) AS 'Age'
FROM   Trainee 
WHERE  LEN(Full_Name) =(SELECT MAX(LEN(Full_Name)) FROM Trainee)
GO

