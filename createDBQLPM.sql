﻿/****** To insert Vietnames:  ******/
/****** 1. make sure script in Unicode-16 ******/
/****** 2. Put N before Vietnames text ******/
/******    Example: N'Lý Đạo Nam' ******/

USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLPM')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLPM') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLPM]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLPM]
GO
USE [QLPM]
GO
SET DATEFORMAT DMY
/*N'TẠO BẢNG CÁCH DÙNG'*/
CREATE TABLE [dbo].[tblCACHDUNG](
[cachDung] [nvarchar](20) NOT NULL)
/*N'TẠO BẢNG ĐƠN VỊ'*/
CREATE TABLE [dbo].[tblDONVI](
[donVi] [nvarchar](20) NOT NULL)
/*N'TẠO BẢNG TIỀN KHÁM'*/
CREATE TABLE [dbo].[tblTK](
[tienKham] [float] NOT NULL)
/*N'TẠO BẢNG HÓA ĐƠN'*/
CREATE TABLE [dbo].[tblHOADON](
	[maHD] [nvarchar](5) NOT NULL,
	[nglapHD] [smalldatetime] NOT NULL,
	[maPKB] [nvarchar](5) NOT NULL,
	[tongTien] [float] ,
 CONSTRAINT [PK_tblHOADON] PRIMARY KEY CLUSTERED 
(
	[maHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
/*N'TẠO BẢNG LOẠI BỆNH'*/
CREATE TABLE [dbo].[tblBENH](
	[maBenh] [nvarchar](5) NOT NULL,
	[tenBenh] [nvarchar](50)NOT NULL,
 CONSTRAINT [PK_tblBENH] PRIMARY KEY CLUSTERED 
(
	[maBenh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
/*N'TẠO BẢNG PHIẾU KHÁM BỆNH'*/
CREATE TABLE [dbo].[tblPKB](
	[maPKB] [nvarchar](5) NOT NULL,
	[NgayKham] [smalldatetime] ,
	[TrieuChung] [nvarchar](50) ,

 CONSTRAINT [PK_tblPKB] PRIMARY KEY CLUSTERED 
(
	[maPKB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
/*CONSTRAINT fk_BENH_PKB
	FOREIGN KEY (maBenh)
	REFERENCES tblBENH (maBenh)
*/
) ON [PRIMARY]
/*N'TẠO BẢNG BỆNH NHÂN'*/
CREATE TABLE [dbo].[tblBENHNHAN](
	[maBN] [nvarchar](5) NOT NULL,
	[tenBN] [nvarchar](50) NOT NULL,
	[NgaySinh] [smalldatetime] NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](50) NOT NULL,
	[maPKB] [nvarchar](5) ,
 CONSTRAINT [PK_tblBENHNHAN] PRIMARY KEY CLUSTERED 
(
	[maBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
CONSTRAINT fk_PKB_BENHNHAN
   FOREIGN KEY (maPKB)
   REFERENCES tblPKB (maPKB)
) ON [PRIMARY]
/*N'TẠO BẢNG THUỐC'*/
CREATE TABLE [dbo].[tblTHUOC](
	[maThuoc] [nvarchar](5) NOT NULL,
	[tenThuoc] [nvarchar](50)NOT NULL,
	[DVT] [nvarchar](10)NOT NULL,
	[Dongia] [float] NOT NULL,
	[CachDung] [nvarchar](20)NOT NULL,
 CONSTRAINT [PK_tblTHUOC] PRIMARY KEY CLUSTERED 
(
	[maThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
/*N'TẠO BẢNG TOA'*/
CREATE TABLE [dbo].[tblTOA](
	[maToa] [nvarchar](5) NOT NULL,
	[ngKeToa] [smalldatetime] NOT NULL,
	[maPKB] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK_tblTOA] PRIMARY KEY CLUSTERED 
(
	[maToa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
CONSTRAINT fk_TOA_PHIEUKHAMBENH
   FOREIGN KEY (maPKB)
   REFERENCES tblPKB (maPKB)
) ON [PRIMARY]
/*N'TẠO BẢNG KẾT QUẢ CHẨN ĐOÁN'*/
CREATE TABLE [dbo].[tblKQCHANDOAN](
	[maBenh] [nvarchar](5) NOT NULL,
	[maPKB] [nvarchar](5) NOT NULL,
	CONSTRAINT fk_KQ_BENH
   FOREIGN KEY (maBenh)
   REFERENCES tblBENH (maBenh),
	CONSTRAINT fk_KQ_PKB
   FOREIGN KEY (maPKB)
   REFERENCES tblPKB (maPKB)
) ON [PRIMARY]
/*N'TẠO BẢNG KÊ THUỐC'*/
CREATE TABLE [dbo].[tblKETHUOC](
	[maThuoc] [nvarchar](5) NOT NULL,
	[maToa] [nvarchar](5) NOT NULL,
	[soLuong] [int] NOT NULL,
	CONSTRAINT fk_KETHUOC_THUOC
   FOREIGN KEY (maThuoc)
   REFERENCES tblTHUOC (maThuoc),
	CONSTRAINT fk_KETHUOC_TOA
   FOREIGN KEY (maToa)
   REFERENCES tblTOA (maToa)
) ON [PRIMARY]
/*N'Tạo giá trị mặc định'*/
/*N'Có 2 đơn vị'*/
INSERT INTO [tblDONVI] ([donVi]) VALUES (N'Chai')
INSERT INTO [tblDONVI] ([donVi]) VALUES (N'Viên')
/*N'Có 3 cách dùng'*/
INSERT INTO [tblCACHDUNG] ([cachDung]) VALUES (N'Tiêm')
INSERT INTO [tblCACHDUNG] ([cachDung]) VALUES (N'Uống')
INSERT INTO [tblCACHDUNG] ([cachDung]) VALUES (N'Hít')
/*N'Tiền khám là 30000'*/
INSERT INTO [tblTK] ([tienKham]) VALUES (30000)
/*N'Có 30 loại thuốc*/
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(1,N'Paracetamol',N'Viên',N'2000',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(2,N'Rifampin',N'Chai',N'50000',N'Tiêm' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(3,N'Halothane',N'Chai',N'80000',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(4,N'Isoflurane',N'Chai',N'10000',N'Tiêm' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(5,N'Ketamine',N'Viên',N'2200',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(6,N'Propofo',N'Chai',N'57000',N'Tiêm' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(7,N'Codeine',N'Viên',N'1000',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(8,N'Midazolam',N'Chai',N'50000',N'Tiêm' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(9,N'Albendazole',N'Viên',N'2000',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(10,N'Ivermectin',N'Chai',N'30000',N'Tiêm' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(11,N'Oxamniquine',N'Viên',N'3500',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(12,N'Amoxicillin',N'Viên',N'900',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(13,N'Cloxacillin',N'Viên',N'2460',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(14,N'Amikacin',N'Chai',N'120000',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(15,N'Chloramphenicol',N'Viên',N'6300',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(16,N'Clindamycin',N'Chai',N'93000',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(17,N'Clofazimine',N'Viên',N'1800',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(18,N'Dapsone',N'Chai',N'500000',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(19,N'Ethambutol',N'Viên',N'3300',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(20,N'Pyrazinamide',N'Chai',N'59000',N'Tiêm' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(21,N'Amphotericin B',N'Viên',N'650',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(22,N'Nystatin',N'Chai',N'132000',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(23,N'Aciclovir',N'Viên',N'4900',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(24,N'Abacavir',N'Chai',N'76000',N'Tiêm' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(25,N'Efavirenz',N'Viên',N'1550',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(26,N'Valganciclovir',N'Chai',N'84000',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(27,N'Sofosbuvir',N'Viên',N'2000',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(28,N'Diloxanide',N'Chai',N'586000',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(29,N'Miltefosine',N'Viên',N'840',N'Uống' )
INSERT INTO[dbo].[tblTHUOC]([maThuoc],[tenThuoc],[DVT],[Dongia],[CachDung]) VALUES(30,N'Artemether',N'Chai',N'200000',N'Tiêm' )
/*N'Có 5 loại bệnh'*/
INSERT INTO [tblBENH] ([maBenh], [tenBenh]) VALUES (1,N'Cảm')
INSERT INTO [tblBENH] ([maBenh], [tenBenh]) VALUES (2,N'Viêm Xoan')
INSERT INTO [tblBENH] ([maBenh], [tenBenh]) VALUES (3,N'Tiêu chảy')
INSERT INTO [tblBENH] ([maBenh], [tenBenh]) VALUES (4,N'Viêm Họng')
INSERT INTO [tblBENH] ([maBenh], [tenBenh]) VALUES (5,N'Viêm đường ruột')
/*N'Tạo ràng buộc khám tối đa trong ngày'*/
go
create trigger kham_toida1 
ON tblPKB 
FOR INSERT 
AS
BEGIN
	IF (Select Count(a.maPKB)
     From tblPKB a Inner Join INSERTED b On a.NgayKham = b.NgayKham)>40
	BEGIN
		PRINT N'Không được khám quá 40 bệnh nhân trong 1 ngày'
		ROLLBACK TRANSACTION
	END 
END



--- Thêm dữ liệu vào bảng tblPKB
INSERT INTO tblPKB (maPKB, NgayKham, TrieuChung) VALUES 
(1, '2023-05-01', N'Sốt cao'), 
(2, '2023-05-02', N'Dau bung'), 
(3, '2023-05-03', N'Tiêu chảy'), 
(4, '2023-05-04', N'Ho khan'), 
(5, '2023-05-05', N'Đau họng'), 
(6, '2023-05-06', N'Dau dạ dày'), 
(7, '2023-05-07', N'Đau răng'), 
(8, '2023-05-08', N'Sốt nhẹ'), 
(9, '2023-05-09', N'Đau lưng'), 
(10, '2023-05-10', N'Mất ngủ');

-- Thêm dữ liệu vào bảng tblBENHNHAN
INSERT INTO tblBENHNHAN (maBN, tenBN, NgaySinh, DiaChi, GioiTinh, maPKB) VALUES 
(1, N'Trần Văn A', '1985-01-15', N'Hà Nội', N'Nam', 1), 
(2, N'Nguyễn Thị B', '1990-03-20', N'Hồ Chí Minh', N'Nữ', 2), 
(3, N'Lê Văn C', '1978-07-10', N'Đà Nẵng', N'Nam', 3), 
(4, N'Phạm Thị D', '2000-11-05', N'Hải Phòng', N'Nữ', 4), 
(5, N'Hồ Văn E', '1995-09-30', N'Cần Thơ', N'Nam', 5), 
(6, N'Trần Thị F', '1982-04-25', N'Bình Dương', N'Nữ', 6), 
(7, N'Đặng Văn G', '1970-12-12', N'An Giang', N'Nam', 7), 
(8, N'Hoàng Thị H', '1988-06-18', N'Tây Ninh', N'Nữ', 8), 
(9, N'Vũ Văn I', '1993-08-22', N'Long An', N'Nam', 9), 
(10, N'Mai Thị K', '1980-02-28', N'Bạc Liêu', N'Nữ', 10);

-- Thêm dữ liệu vào bảng tblTHUOC
INSERT INTO tblTHUOC (maThuoc, tenThuoc, DVT, Dongia, CachDung) VALUES 
(1, N'Paracetamol', N'Viên', 2000, N'Uống'), 
(2, N'Rifampin', N'Chai', 50000, N'Tiêm'), 
(3, N'Halothane', N'Chai', 80000, N'Uống'), 
(4, N'Isoflurane', N'Chai', 10000, N'Tiêm'), 
(5, N'Ketamine', N'Viên', 2200, N'Uống'), 
(6, N'Propofo', N'Chai', 57000, N'Tiêm'), 
(7, N'Codeine', N'Viên', 1000, N'Uống'), 
(8, N'Midazolam', N'Chai', 50000, N'Tiêm'), 
(9, N'Albendazole', N'Viên', 2000, N'Uống'), 
(10, N'Ivermectin', N'Chai', 30000, N'Tiêm');

-- Thêm dữ liệu vào bảng tblTOA
INSERT INTO tblTOA (maToa, ngKeToa, maPKB) VALUES 
(1, '2023-05-01', 1), 
(2, '2023-05-02', 2), 
(3, '2023-05-03', 3), 
(4, '2023-05-04', 4), 
(5, '2023-05-05', 5), 
(6, '2023-05-06', 6), 
(7, '2023-05-07', 7), 
(8, '2023-05-08', 8), 
(9, '2023-05-09', 9), 
(10, '2023-05-10', 10);

-- Thêm dữ liệu vào bảng tblKETHUOC
INSERT INTO tblKETHUOC (maThuoc, maToa, soLuong) VALUES 
(1, 1, 2), 
(2, 2, 1), 
(3, 3, 3), 
(4, 4, 2), 
(5, 5, 1), 
(6, 6, 2), 
(7, 7, 3), 
(8, 8, 2), 
(9, 9, 1), 
(10, 10, 4);

-- Thêm dữ liệu vào bảng tblHOADON
INSERT INTO tblHOADON (maHD, nglapHD, maPKB, tongTien) VALUES 
(1, '2023-05-01', 1, 150000), 
(2, '2023-05-02', 2, 180000), 
(3, '2023-05-03', 3, 120000), 
(4, '2023-05-04', 4, 200000), 
(5, '2023-05-05', 5, 220000), 
(6, '2023-05-06', 6, 170000), 
(7, '2023-05-07', 7, 250000), 
(8, '2023-05-08', 8, 190000), 
(9, '2023-05-09', 9, 210000), 
(10, '2023-05-10', 10, 240000);

-- Thêm dữ liệu vào bảng tblKQCHANDOAN
INSERT INTO tblKQCHANDOAN (maBenh, maPKB) VALUES 
(1, 1), 
(2, 2), 
(3, 3), 
(4, 4), 
(5, 5), 
(1, 6), 
(2, 7), 
(3, 8), 
(4, 9), 
(5, 10);







-- Tiếp tục thêm dữ liệu cho các bảng khác theo cùng một nguyên tắc






/*UPDATE [tblTK] set tienKham='40000' where tienkham='50000'
UPDATE [tblDONVI] set donVi='Viên nén' where donVi='Viên'*/
/*SELECT SUM(TH.Dongia*KT.soLuong) AS TIENTHUOC INTO TIENTHUOC FROM tblPKB PKB JOIN tblTOA T ON PKB.maPKB=T.maPKB JOIN tblKETHUOC KT ON T.maToa=KT.maToa JOIN tblTHUOC TH ON KT.maThuoc=TH.maThuoc WHERE PKB.maPKB='6'*/
/*SELECT maPKB FROM [tblPKB]
SELECT MAX (KQ.MAPKB) AS MM from (SELECT CONVERT(float, tblPKB.maPKB) AS MAPKB FROM tblPKB ) AS KQ
SELECT * FROM [tblPKB] WHERE ([maPKB] LIKE CONCAT('%',6,'%')) OR ([NgayKham]='7/6/2019')
SELECT TH.maThuoc,TH.tenThuoc,KT.soLuong,TH.CachDung,TH.DVT,TH.Dongia FROM tblTOA T JOIN tblKETHUOC KT ON T.maToa=KT.maToa JOIN tblTHUOC TH ON KT.maThuoc=TH.maThuoc
SELECT TH.maThuoc, TH.tenThuoc, sum (KT.soLuong) as SL FROM tblTOA T JOIN tblKETHUOC KT ON T.maToa=KT.maToa JOIN tblTHUOC TH ON KT.maThuoc=TH.maThuoc WHERE MONTH(T.ngKeToa)='6' and year(T.ngKeToa)='2019' group by TH.maThuoc,TH.tenThuoc
SELECT KT FROM tblPKB PKB JOIN tblTOA T ON PKB.maPKB=T.maPKB JOIN tblKETHUOC KT ON T.maToa=KT.maToa JOIN tblTHUOC TH ON KT.maThuoc=TH.maThuoc WHERE PKB.maPKB='5'
SELECT  count (KT.maToa) as SLD FROM tblTOA T JOIN tblKETHUOC KT ON T.maToa=KT.maToa JOIN tblTHUOC TH ON KT.maThuoc=TH.maThuoc WHERE MONTH(T.ngKeToa)='6' and year(T.ngKeToa)='2019' and TH.maThuoc='2'
SELECT TH.maThuoc, TH.tenThuoc, sum (KT.soLuong) as SL FROM tblTOA T JOIN tblKETHUOC KT ON T.maToa=KT.maToa JOIN tblTHUOC TH ON KT.maThuoc=TH.maThuoc WHERE MONTH(T.ngKeToa)='6' and year(T.ngKeToa)='2019' group by TH.maThuoc,TH.tenThuoc
SELECT HD.nglapHD, count (HD.maHD) as sobn, sum (HD.tongTien) as doanhthu FROM tblPKB PKB JOIN tblHOADON HD ON PKB.maPKB=HD.maPKB WHERE MONTH(HD.nglapHD)='6' group by HD.nglapHD
SELECT count (HD.maHD) as sobn FROM tblHOADON HD WHERE HD.nglapHD='6/22/2019'
SELECT sum (HD.tongTien) as doanhthu FROM tblHOADON HD WHERE HD.nglapHD='6/22/2019'
SELECT nglapHD FROM [tblHOADON] WHERE MONTH(nglapHD)='6' and YEAR(nglapHD)='2019' group by nglapHD
SELECT BE.tenBenh,PKB.TrieuChung FROM tblBENHNHAN BN JOIN tblPKB PKB ON BN.maPKB=PKB.maPKB JOIN tblKQCHANDOAN CD ON PKB.maPKB=CD.maPKB JOIN tblBENH BE ON CD.maBenh=BE.maBenh  group by BE.tenBenh,PKB.TrieuChung*/
