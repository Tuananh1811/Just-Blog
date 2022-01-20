USE MASTER
GO
CREATE DATABASE dbMovieCollection

go
USE dbMovieCollection
go
CREATE TABLE Genre(
	GenreID		INT PRIMARY KEY CHECK(GenreID >=1 AND GenreID<=8) NOT NULL 
	, GenreName		NVARCHAR(50) NOT NULL	
)

GO
CREATE TABLE Movie(
	MovidID INT identity primary key
	,[Name] NVARCHAR(100)
	,Duration INT CHECK(Duration>60) NOT NULL
	,Genre INT CHECK(Genre >=1 AND Genre<=8)	NOT NULL REFERENCES Genre(GenreID)
	,Director NVARCHAR(20)
	,amountofmoney MONEY
	,Comment TEXT

)

CREATE TABLE Actor(
	ActorID INT IDENTITY PRIMARY KEY
	,[Name] nvarchar(20) not null
	, Age				INT				NOT NULL
	, AverageSalary	MONEY			NOT NULL
	, Nationality		NVARCHAR(100)	NOT NULL

)
GO
CREATE TABLE ActedIn(
	MovieID		INT NOT NULL		REFERENCES Movie(MovidID)
	,ActorID	INT IDENTITY NOT NULL	REFERENCES Actor(ActorID)
)
DROP TABLE ActedIn
--Q2
ALTER TABLE Movie ADD IMAGELINK VARCHAR(100) UNIQUE(IMAGELINK) NOT NULL 
INSERT INTO Genre(GenreID,GenreName) VALUES('1',N'Hành động')
INSERT INTO Genre(GenreID,GenreName) VALUES('2',N'Phiêu lưu')
INSERT INTO Genre(GenreID,GenreName) VALUES('3',N'Hài')
INSERT INTO Genre(GenreID,GenreName) VALUES('4',N'Tội phạm')
INSERT INTO Genre(GenreID,GenreName) VALUES('5',N'Phim truyền hình')
INSERT INTO Genre(GenreID,GenreName) VALUES('6',N'Kinh dị')
INSERT INTO Genre(GenreID,GenreName) VALUES('7',N'Ca nhạc/khiêu vũ')
INSERT INTO Genre(GenreID,GenreName) VALUES('8',N' Chiến tranh')
 SELECT *FROM Genre

INSERT INTO Movie([Name],Duration,Genre,Director,amountofmoney,Comment,IMAGELINK) 
VALUES(N'TRÒ CHƠI CON MỰC','100',4,'TUAN ANH',99999,N'HAY.','./IMG/IMG1.JPG')

INSERT INTO Movie([Name],Duration,Genre,Director,amountofmoney,Comment,IMAGELINK)
VALUES(N'TRÒ CHƠI CON MỰC 2','100',1,'TUAN ANH',99999,N'HAY.','./IMG/IMG2.JPG')

INSERT INTO Movie([Name],Duration,Genre,Director,amountofmoney,Comment,IMAGELINK) 
VALUES(N'KILL IT','132',1,'TUAN ANH',99999,N'BUỒN','./IMG/IMG3.JPG')

---------------------
INSERT INTO Actor ([Name],Age,AverageSalary	,Nationality)
VALUES(' Sung-Woo',32,2345678,'KOREA')

INSERT INTO Actor ([Name],Age,AverageSalary	,Nationality)
VALUES(' Jang Ki Yong',21,2345678,'KOREA')

INSERT INTO Actor ([Name],Age,AverageSalary	,Nationality)
VALUES('Nana',42,2345678,'KOREA')
INSERT INTO Actor ([Name],Age,AverageSalary	,Nationality)
VALUES('Nana2',60,2345678,'KOREA')
INSERT INTO Actor ([Name],Age,AverageSalary	,Nationality)
VALUES('Nana4',50,2345678,'KOREA')

---------------------
SET IDENTITY_INSERT ActedIn ON 
SET IDENTITY_INSERT Actor OFF
SET IDENTITY_INSERT Movie OFF 

INSERT INTO ActedIn (MovieID,ActorID)
VALUES	 (3,2)
INSERT INTO ActedIn (MovieID,ActorID)
VALUES	(1,1)
INSERT INTO ActedIn (MovieID,ActorID)
VALUES	(1,2)
INSERT INTO ActedIn (MovieID,ActorID)
VALUES  (2,3)
		
SET IDENTITY_INSERT ActedIn OFF 
SET IDENTITY_INSERT Movie ON
SET IDENTITY_INSERT Actor ON
SELECT *FROM ActedIn
--Q3
--query1
SELECT *FROM Actor WHERE Actor.Age>=50

---query2
SELECT [Name],AverageSalary FROM Actor
ORDER BY AverageSalary DESC

--query3
SELECT Movie.[Name] 'NAME MOVIE' FROM ActedIn
JOIN Actor ON ActedIn.ActorID=Actor.ActorID
JOIN Movie ON Movie.MovidID=ActedIn.ActorID
WHERE Actor.[Name]='Nana'

--query4
SELECT Movie.[Name] FROM Movie
WHERE Genre=1 AND Movie.MovidID 
=(SELECT Movie.MovidID FROM ActedIn JOIN Movie on Movie.MovidID = ActedIn.MovieID	
GROUP BY Movie.MovidID HAVING COUNT(ActorID)>3)

