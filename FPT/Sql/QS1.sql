CREATE DATABASE dbQuestion1
GO
USE dbQuestion1
GO
CREATE TABLE San_Pham (
			  MaSP			INT IDENTITY  PRIMARY KEY 	     NOT NULL
			, TenSP		NVARCHAR(30)					 NOT NULL
			, DonGia		MONEY							 NOT NULL
)
GO
CREATE TABLE KhachHang (
			  MaKH			INT IDENTITY		PRIMARY KEY 	 NOT NULL
			, TenKH			NVARCHAR(50)					 NOT NULL
			, PhoneNo		INT				   UNIQUE	     NOT NULL
			, GhiChu		TEXT
)
GO

CREATE TABLE Don_Hang (
			  MaDH			INT IDENTITY		PRIMARY KEY 	NOT NULL
			, NgayDH		DATE								NOT NULL
			, MaSP			INT					REFERENCES San_Pham (MaSP)		NOT NULL
			, SoLuong		INT													NOT NULL
			, MaKH			INT					REFERENCES KhachHang(MaKH)	NOT NULL
)
GO

INSERT INTO San_Pham ( TenSP			, DonGia	)
VALUES				 (N'COCA'			,100		)
					,(N'PEPSI'			,120		)
					,(N'MIRINDA'		,250		)
					,(N'REDBULL'		,450		)
					,(N'REVIVE'			,550		)
					,(N'STING'			,180		)
GO

SELECT *FROM San_Pham

INSERT INTO KhachHang (TenKH					, PhoneNo		, GhiChu)
VALUES                 (N'DO MANH QUAN'			,012345668		,''	)
					  ,(N'NGUYEN THU HOAI'		,034567854		,''	)
					  ,(N'DO TUAN ANH'			,09876543		,''	)
					  ,(N'HOANG THU HANG'		,0532245		,''	)
					  ,(N'NGUYEN THANH BINH'    ,09864262		,''	)
GO
SELECT *FROM KhachHang

INSERT INTO Don_Hang ( NgayDH		, MaSP			,SoLuong			, MaKH	)
VALUES				 ('2021-05-21'	,4				,2					,7		)
					,('2021-04-22'	,4				,1					,8		)
					,('2021-04-23'	,3				,3					,8		)
					,('2021-05-24'	,2				,3					,8		)
					,('2021-06-25'	,4				,1					,7		)
					,('2021-07-26'	,5				,3					,9		)
					,('2021-8-17'	,6				,1					,10		)
					,('2021-9-01'	,3				,2					,11		)
GO
CREATE VIEW WDonHang AS
SELECT DH.MaDH ,TenKH , DH.NgayDH, SP.TenSP, DH.SoLuong , DH.SoLuong*SP.DonGia  AS 'SUM TOTAL'
FROM Don_Hang DH join San_Pham SP on DH.MaSP=SP.MaSP
				join KhachHang K on DH.MaKH=K.MaKH
GO

SELECT * FROM WDonHang 
GO






