CREATE DATABASE QLPM
GO
USE QLPM

-- TẠO BẢNG BỆNH NHÂN
CREATE TABLE BenhNhan(
    maBenhNhan int IDENTITY,
    tenBenhNhan nvarchar(50) NOT NULL,
    ngaySinh date NOT NULL,
    diaChi nvarchar(50) NOT NULL,
    gioiTinh nvarchar(50) NOT NULL,
    CONSTRAINT pk_BenhNhan PRIMARY KEY CLUSTERED (maBenhNhan ASC) ON [PRIMARY]
) ON [PRIMARY]


-- TẠO BẢNG PHIẾU KHÁM BỆNH
CREATE TABLE PhieuKhamBenh(
    maPKB int IDENTITY,
    ngayKham date,
    trieuChung nvarchar(50),
	maBenhNhan int,
    CONSTRAINT pk_PhieuKhamBenh PRIMARY KEY CLUSTERED (maPKB ASC) ON [PRIMARY],
	CONSTRAINT fk_BenhNhan_PhieuKhamBenh FOREIGN KEY (maBenhNhan) REFERENCES BenhNhan(maBenhNhan)
) ON [PRIMARY]



-- TẠO BẢNG LOẠI BỆNH
CREATE TABLE Benh(
    maBenh int IDENTITY,
    tenBenh nvarchar(50) NOT NULL,
    CONSTRAINT pk_Benh PRIMARY KEY CLUSTERED (maBenh ASC) ON [PRIMARY]
) ON [PRIMARY]



-- TẠO BẢNG CHUẨN ĐOÁN
CREATE TABLE ChuanDoan(
	maBenh int,
	maPKB int,
    CONSTRAINT pk_ChuanDoan PRIMARY KEY CLUSTERED (maBenh, maPKB ASC) ON [PRIMARY],
	CONSTRAINT fk_Benh_ChuanDoan FOREIGN KEY (maBenh) REFERENCES Benh (maBenh),
	CONSTRAINT fk_PhieuKhamBenh_ChuanDoan FOREIGN KEY (maPKB) REFERENCES PhieuKhamBenh (maPKB)
) ON [PRIMARY]


-- TẠO BẢNG ĐƠN VỊ
CREATE TABLE DonVi(
    donVi nvarchar(20) NOT NULL,
	CONSTRAINT pk_donVi PRIMARY KEY CLUSTERED (donVi ASC) ON [PRIMARY],
) ON [PRIMARY]

-- TẠO BẢNG Cách dùng
CREATE TABLE CachDung(
    cachDung nvarchar(20) NOT NULL,
	CONSTRAINT pk_cachDung PRIMARY KEY CLUSTERED (cachDung ASC) ON [PRIMARY],
) ON [PRIMARY]


-- TẠO BẢNG THUỐC
CREATE TABLE Thuoc(
    maThuoc int IDENTITY,
    tenThuoc nvarchar(50) NOT NULL,
    donGia float NOT NULL,
    cachDung nvarchar(20) NOT NULL,
	donVi nvarchar(20) NOT NULL,
    CONSTRAINT pk_Thuoc PRIMARY KEY CLUSTERED (maThuoc ASC) ON [PRIMARY],
	CONSTRAINT fk_DonVi_Thuoc FOREIGN KEY (donVi) REFERENCES DonVi (donVi),
    CONSTRAINT fk_CachDung_Thuoc FOREIGN KEY (cachDung) REFERENCES CachDung (cachDung)
) ON [PRIMARY]


-- TẠO BẢNG TOA THUỐC
CREATE TABLE ToaThuoc(
    maToaThuoc int IDENTITY,
    ngayKeToa date,
	maPKB int,
    CONSTRAINT pk_ToaThuoc PRIMARY KEY CLUSTERED (maToaThuoc ASC) ON [PRIMARY],
	CONSTRAINT fk_PhieuKhamBenh_ToaThuoc FOREIGN KEY (maPKB) REFERENCES PhieuKhamBenh (maPKB)
) ON [PRIMARY]


-- TẠO BẢNG KÊ THUỐC
CREATE TABLE KeThuoc(
	maThuoc int,
	maToaThuoc int,
	soLuong int NOT NULL,
	CONSTRAINT pk_KeThuoc PRIMARY KEY CLUSTERED (maThuoc, maToaThuoc ASC) ON [PRIMARY],
	CONSTRAINT fk_Thuoc_KeThuoc FOREIGN KEY (maThuoc) REFERENCES Thuoc (maThuoc),
	CONSTRAINT fk_ToaThuoc_KeThuoc FOREIGN KEY (maToaThuoc) REFERENCES ToaThuoc (maToaThuoc)
) ON [PRIMARY]



-- TẠO BẢNG QUY ĐỊNH
-- TẠO BẢNG DichVu
CREATE TABLE DichVu(
	maDichVu int IDENTITY,
	tenDichVu nvarchar(20) NOT NULL,
    tienDichVu float NOT NULL
) ON [PRIMARY]



-- TẠO BẢNG HÓA ĐƠN
CREATE TABLE HoaDon(
    maHoaDon int IDENTITY,
    ngayLapHoaDon date,
	tienThuoc float,
	tienKham float,
    tongTien float,
	maPKB int,
    CONSTRAINT pk_HoaDon PRIMARY KEY CLUSTERED (maHoaDon ASC) ON [PRIMARY],
	CONSTRAINT fk_PhieuKhamBenh_HoaDon FOREIGN KEY (maPKB) REFERENCES PhieuKhamBenh (maPKB),
) ON [PRIMARY]


-- Insert data into BenhNhan
INSERT INTO BenhNhan (tenBenhNhan, ngaySinh, diaChi, gioiTinh)
VALUES 
('Nguyen Van A', '1985-05-01', '123 Le Loi, Hanoi', 'Nam'),
('Tran Thi B', '1990-07-15', '456 Nguyen Trai, Ho Chi Minh', 'Nu'),
('Le Van C', '1975-10-20', '789 Tran Hung Dao, Da Nang', 'Nam');

-- Insert data into PhieuKhamBenh
INSERT INTO PhieuKhamBenh (ngayKham, trieuChung, maBenhNhan)
VALUES 
('2024-05-10', 'Sot, ho', 1),
('2024-05-11', 'Dau dau, met moi', 2),
('2024-05-12', 'Dau bung', 3);

-- Insert data into Benh
INSERT INTO Benh (tenBenh)
VALUES 
('Cam cum'),
('Dau dau'),
('Dau bung');

-- Insert data into ChuanDoan
INSERT INTO ChuanDoan (maBenh, maPKB)
VALUES 
(1, 1),
(2, 2),
(3, 3);

-- Insert data into DonVi
INSERT INTO DonVi (donVi)
VALUES 
('Vien'),
('Chai'),
('Goi');

-- Insert data into CachDung
INSERT INTO CachDung (cachDung)
VALUES 
('Uong'),
('Tiem'),
('Boi');

-- Insert data into Thuoc
INSERT INTO Thuoc (tenThuoc, donGia, cachDung, donVi)
VALUES 
('Paracetamol', 5000, 'Uong', 'Vien'),
('Vitamin C', 3000, 'Uong', 'Vien'),
('Oresol', 7000, 'Uong', 'Goi');

-- Insert data into ToaThuoc
INSERT INTO ToaThuoc (ngayKeToa, maPKB)
VALUES 
('2024-05-10', 1),
('2024-05-11', 2),
('2024-05-12', 3);

-- Insert data into KeThuoc
INSERT INTO KeThuoc (maThuoc, maToaThuoc, soLuong)
VALUES 
(1, 1, 10),
(2, 1, 5),
(3, 2, 20);

-- Insert data into DichVu
INSERT INTO DichVu (tenDichVu, tienDichVu)
VALUES 
('Kham benh', 50000),
('Xet nghiem', 200000),
('Chup X-quang', 150000);




