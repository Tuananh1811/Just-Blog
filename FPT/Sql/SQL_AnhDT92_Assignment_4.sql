use dbAss4
go
--query1
SELECT ProductID, [Name], Color, ListPrice 
FROM Production.Product 
--query2
SELECT ProductID, [Name], Color, ListPrice 
FROM Production.Product WHERE ListPrice >0
GO
--query 3
SELECT ProductID, [Name], Color, ListPrice 
FROM Production.Product WHERE Color IS NULL
GO
--query4
SELECT ProductID, [Name], Color, ListPrice 
FROM Production.Product WHERE Color IS NOT NULL
GO
--query5
SELECT ProductID, [Name], Color, ListPrice 
FROM Production.Product 
WHERE Color IS NOT NULL AND ListPrice >0
GO
--query6
SELECT  [Name]+ ':'+ Color AS 'Name And Color'
FROM Production.Product 
WHERE Color IS NOT NULL
GO
--query7
SELECT  'NAME: '+ Name+' COLOR: '+ Color AS 'NAME AND COLOR'
FROM Production.Product 
WHERE Color IS NOT NULL
GO
--query8 
SELECT ProductID, [Name] FROM Production.Product 
WHERE ProductID BETWEEN 400 AND 500
GO
--query9
SELECT ProductID, [Name], Color FROM Production.Product 
WHERE  Color= 'Black' OR Color='Blue'
GO
--query10
SELECT  [Name],ListPrice FROM Production.Product 
WHERE [Name] LIKE 'S%'--chữ bắt đầu
GO
--query11
SELECT  [Name],ListPrice
FROM Production.Product 
WHERE [Name] LIKE  'A%' OR [Name] LIKE 'S%'
GO

--query 12:
SELECT  [Name],ListPrice
FROM Production.Product 
WHERE [Name] LIKE 'SPO[^K]%'
GO

--query 13:
SELECT DISTINCT Color
FROM Production.Product 
GO


--query 14:
SELECT DISTINCT ProductSubcategoryID,Color
FROM Production.Product 
WHERE ProductSubcategoryID IS NOT NULL AND Color IS NOT NULL
GO


--query 15:-
SELECT ProductSubCategoryID
		, LEFT([Name],35) AS [Name]
		, Color
		, ListPrice
FROM Production.Product
WHERE Color  NOT IN  ('Red','Black') AND ProductSubCategoryID != 1   OR ListPrice  BETWEEN 1000 AND 2000  
ORDER BY ProductID
GO
--query15 cach2 --như đề bài
SELECT ProductSubCategoryID
		, LEFT([Name],35) AS [Name]
		, Color
		, ListPrice
FROM Production.Product
WHERE Color   IN  ('Red','Black') AND ProductSubCategoryID = 1   OR ListPrice  BETWEEN 1000 AND 2000  
ORDER BY ProductID
GO


--query 16:
SELECT  [Name],COALESCE(Color,'Unknown'),ListPrice
FROM Production.Product 
GO