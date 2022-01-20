CREATE DATABASE GuitarShopDB
GO
USE GuitarShopDB
GO


CREATE TABLE Categories
(
		CategoryId INT IDENTITY PRIMARY KEY NOT NULL
		,CategoryName NVARCHAR(50) UNIQUE NOT NULL
)

GO
CREATE TABLE Productss
(
	ProductId		INT IDENTITY	PRIMARY KEY NOT NULL
	,CategoryId		INT				REFERENCES Categories(CategoryId)
	,ProductCode	VARCHAR(10)		UNIQUE		NOT NULL 
	,ProductName	VARCHAR(50)					NOT NULL
	,[Description]	NVARCHAR(500)				
	,DateAdded		DATE
	
)
GO

CREATE TABLE Customers
(
	CustomerId INT IDENTITY PRIMARY KEY NOT NULL
	,Email VARCHAR(50) UNIQUE NOT NULL
	,[Password] VARCHAR(50) NOT NULL
	, FirstName NVARCHAR(50) NOT NULL
	, LastName NVARCHAR(50) NOT NULL
	,[Address] NVARCHAR(50) NOT NULL
	,IsPasswordChanged BIT DEFAULT 0 --default of false
)
GO

CREATE TABLE ORDERS
(
		OrderId			INT IDENTITY PRIMARY KEY NOT NULL
		,CustomerId		INT REFERENCES Customers(CustomerId) not null
		,OrderDate		DATE NOT NULL
		,ShipAddress	NVARCHAR(100)
)

GO

CREATE TABLE ORDERITEMS
(
	OrderId					INT REFERENCES ORDERS(OrderId)
	,ProductId				INT REFERENCES Productss(ProductId)
	,Quantity				INT NOT NULL	CHECK(Quantity>=1)
	,UnitPrice				MONEY NOT NULL
	,DiscountPercent		DECIMAL(4,2) NOT NULL CHECK(DiscountPercent>0.00 AND DiscountPercent<=75.00)

)
drop table ORDERITEMS
--DROP TABLE ORDERITEMS
GO

INSERT INTO Categories (CategoryName)
VALUES			('Guitar Classic  C150 ')
				,('Guitar Acoustic HT')
				,('Guitar Acoustic Rosen G11')
				,('Guitar Acoustic J100')
SELECT *FROM Categories
INSERT INTO Productss(CategoryId,ProductCode,ProductName,[Description],DateAdded)
VALUES			
				(1,'SP20000000','Classic C2',N'tiếng tốt','2021-4-1')
				,(2,'SP30000000','Classic C3',N'bấm êm','2021-9-1')
				,(2,'SP40000000','Classic C4',N'bấm êm, Có ty chỉnh cần','2021-9-1')
				,(3,'SP50000000','Classic C5',N'bấm êm, Có ty chỉnh cần','2020-9-1')
				,(4,'SP60000000','Classic C6',N'bấm êm, tiếng tốt','2021-3-1')
				,(3,'SP70000000','Classic C7',N'bấm êm, Có ty chỉnh cần','2020-9-1')
				,(1,'SP80000000','Classic C8',N'bấm êm,mặt trước gỗ thịt hồng đào full','2021-5-1')
				,(2,'SP9000000','Classic C9',N'bấm êm, Có ty chỉnh cần','2021-9-1')
				,(1,'SP10000002','Classic C10',N'bấm êm, Có ty chỉnh cần','2021-9-1')
				,(4,'SP10000003','Classic C11',N'bấm êm, Có ty chỉnh cần','2021-9-1')
				,(1,'SP10000000','Classic C1',N'lưng hông gỗ ép cứng chất lượng','2021-9-1')
SELECT *FROM Productss
INSERT INTO  Customers(Email,[Password],FirstName,LastName,[Address],IsPasswordChanged)
VALUES     ('abcd18@gmail.com','abc123','mihh','za','Vinh Phuc',0)
			,('tanhdofitmedia@gmail.com','abc11234','Anh','Do','Vinh Phuc',0)
			,('abc18@gmail.com','abc123','Anh','Do','Vinh Phuc',0)
			,('abc19@gmail.com','abc123','Anh','Do','Vinh Phuc',0)
			,('abc20@gmail.com','abc123','Anh','Do','Vinh Phuc',0)
			,('abc21@gmail.com','abc123','Anh','Do','Vinh Phuc',0)
			,('gmail18@gmail.com','abc123','Anh','Do','Vinh Phuc',0)
			,('gmail19@gmail.com','abc123','Anh','Do','Vinh Phuc',0)
			,('gmail21@gmail.com','abc123','Anh','Do','Vinh Phuc',0)
			,('abc32@gmail.com','abc123','Anh','Do','Vinh Phuc',0)
			,('tanhdo18@gmail.com','abc123','Anh','Do','Vinh Phuc',0)

INSERT INTO ORDERS(CustomerId,OrderDate,ShipAddress)
VALUES		(1,'2021-6-2','VINH PHUC')
			,(2,'2021-5-3','HA NOI')
			,(3,'2021-6-3','THAI NGUYEN')
			,(4,'2021-3-3','HAI PHONG')
			,(5,'2021-2-3','THAI BINH')
			,(5,'2021-1-3','BAC NINH')
			,(6,'2021-1-4','BAC GIANG')
			,(3,'2021-5-3','HAI DUONG')
			,(1,'2021-6-6','HA NOI')
			,(7,'2021-7-7','HA NOI')
	SELECT *FROM ORDERS
GO

INSERT INTO ORDERITEMS (OrderId,ProductId,Quantity,UnitPrice,DiscountPercent)
VALUES		
			(2,14,100,1200,'50.00')
			,(3,13,80,1220,'50.00')
			,(4,16,80,1250,'50.00')
			,(5,17,50,1260,'50.00')
			,(6,18,70,1270,'50.00')
			,(7,12,5,1207,'50.00')
			,(6,11,10,1400,'50.00')
			,(5,16,40,1700,'50.00')
			,(8,19,30,2200,'50.00')
			,(1,12,100,1200,'50.00')
			,(1,12,100,1200,'50.00')

SELECT *FROM Categories
SELECT *FROM Productss
SELECT *FROM Customers
SELECT *FROM ORDERS
SELECT *FROM ORDERITEMS

--Qb
SELECT pd.ProductCode, pd.ProductName, pd.[Description],pd.DateAdded
FROM Productss pd
WHERE DATEDIFF(MONTH,pd.DateAdded,GETDATE())>=12
ORDER BY pd.ProductCode  --mặc định là tăng dần nên em không ghi 
GO
--Qc


UPDATE Customers SET [Password]='Secret@1234!'
WHERE Email='tanhdofitmedia@gmail.com' AND IsPasswordChanged=0
GO
SELECT *FROM Customers
--Qd
SELECT C.FirstName+' '+ C.LastName  'FULLNAME'
FROM Customers C
WHERE C.LastName LIKE '[m-z]%'
ORDER BY C.LastName
GO
--Qe
SELECT pd.ProductName, or_i.UnitPrice, pd.DateAdded
FROM Productss pd INNER JOIN ORDERITEMS or_i
ON
pd.ProductId=or_i.ProductId
WHERE 
or_i.UnitPrice>=500 AND or_i.UnitPrice<=2000
ORDER BY pd.DateAdded DESC