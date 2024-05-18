CREATE DATABASE QLPM
GO
USE QLPM

-- TẠO BẢNG ROLE
CREATE TABLE Roles(
    maRole int IDENTITY,
    tenRole nvarchar(50) NOT NULL,
	CONSTRAINT pk_Roles PRIMARY KEY CLUSTERED (maRole ASC) ON [PRIMARY]
) ON [PRIMARY]

-- TẠO BẢNG USER
CREATE TABLE TaiKhoan(
	maTaiKhoan int IDENTITY,
    userName nvarchar(50) NOT NULL,
	passWord nvarchar(50) NOT NULL,
    name nvarchar(50) NOT NULL,
	maRole int,
    CONSTRAINT pk_TaiKhoan PRIMARY KEY CLUSTERED (maTaiKhoan ASC) ON [PRIMARY],
	CONSTRAINT fk_Roles_TaiKhoan FOREIGN KEY (maRole) REFERENCES Roles (maRole)
) ON [PRIMARY]

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
	maTaiKhoan int,
    CONSTRAINT pk_PhieuKhamBenh PRIMARY KEY CLUSTERED (maPKB ASC) ON [PRIMARY],
	CONSTRAINT fk_BenhNhan_PhieuKhamBenh FOREIGN KEY (maBenhNhan) REFERENCES BenhNhan(maBenhNhan),
	CONSTRAINT fk_TaiKhoan_PhieuKhamBenh FOREIGN KEY (maTaiKhoan) REFERENCES TaiKhoan(maTaiKhoan)
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



CREATE TABLE DonVi(
    maDonVi int IDENTITY,
    tenDonVi nvarchar(20) NOT NULL,
    CONSTRAINT pk_donVi PRIMARY KEY CLUSTERED (maDonVi ASC) ON [PRIMARY]
) ON [PRIMARY];



CREATE TABLE CachDung(
    maCachDung int IDENTITY,
    tenCachDung nvarchar(20) NOT NULL,
    CONSTRAINT pk_cachDung PRIMARY KEY CLUSTERED (maCachDung ASC) ON [PRIMARY]
) ON [PRIMARY];



CREATE TABLE Thuoc(
    maThuoc int IDENTITY,
    tenThuoc nvarchar(50) NOT NULL,
    donGia float NOT NULL,
    maCachDung int NOT NULL,
    maDonVi int NOT NULL,
    CONSTRAINT pk_Thuoc PRIMARY KEY CLUSTERED (maThuoc ASC) ON [PRIMARY],
    CONSTRAINT fk_DonVi_Thuoc FOREIGN KEY (maDonVi) REFERENCES DonVi (maDonVi),
    CONSTRAINT fk_CachDung_Thuoc FOREIGN KEY (maCachDung) REFERENCES CachDung (maCachDung)
) ON [PRIMARY];


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


-- TẠO BẢNG DichVu
CREATE TABLE DichVu(
	maDichVu int IDENTITY,
	tenDichVu nvarchar(20) NOT NULL,
    tienDichVu float NOT NULL,
	CONSTRAINT pk_DichVu PRIMARY KEY CLUSTERED (maDichVu ASC) ON [PRIMARY]
) ON [PRIMARY]



-- TẠO BẢNG HÓA ĐƠN
CREATE TABLE HoaDon(
    maHoaDon int IDENTITY,
    ngayLapHoaDon date,
	tienThuoc float,
	tienKham float,
    tongTien float,
	maPKB int,
	maTaiKhoan int,
    CONSTRAINT pk_HoaDon PRIMARY KEY CLUSTERED (maHoaDon ASC) ON [PRIMARY],
	CONSTRAINT fk_PhieuKhamBenh_HoaDon FOREIGN KEY (maPKB) REFERENCES PhieuKhamBenh (maPKB),
	CONSTRAINT fk_TaiKhoan_HoaDon FOREIGN KEY (maTaiKhoan) REFERENCES TaiKhoan(maTaiKhoan)
) ON [PRIMARY]





INSERT INTO Roles (tenRole) VALUES
(N'Bác sĩ'),
(N'Thu ngân'),
(N'Quản trị viên')


INSERT INTO TaiKhoan (userName, passWord, name, maRole) VALUES
('bacsi','123','Bac Si Cuong',1),
('thungan','123','Thu Ngan Son',2),
('qtv','123','QTV Phong',3)


INSERT INTO BenhNhan (tenBenhNhan, ngaySinh, diaChi, gioiTinh) VALUES
(N'Nguyễn Văn A', '1980-01-01', N'Hà Nội', N'Nam'),
(N'Trần Thị B', '1985-02-15', N'Sài Gòn', N'Nữ'),
(N'Lê Văn C', '1990-03-20', N'Đà Nẵng', N'Nam'),
(N'Phạm Thị D', '1992-04-10', N'Cần Thơ', N'Nữ'),
(N'Hoàng Văn E', '1975-05-30', N'Hải Phòng', N'Nam'),
(N'Vũ Thị F', '1988-06-25', N'Quảng Ninh', N'Nữ'),
(N'Bùi Văn G', '1995-07-07', N'Nghệ An', N'Nam'),
(N'Đỗ Thị H', '1993-08-08', N'Hà Tĩnh', N'Nữ'),
(N'Phan Văn I', '1981-09-09', N'Huế', N'Nam'),
(N'Ngô Thị J', '1986-10-10', N'Vĩnh Phúc', N'Nữ'),
(N'Nguyễn Văn K', '1982-11-11', N'Bắc Ninh', N'Nam'),
(N'Trần Thị L', '1987-12-12', N'Hà Nam', N'Nữ'),
(N'Lê Văn M', '1991-01-13', N'Thái Bình', N'Nam'),
(N'Phạm Thị N', '1994-02-14', N'Nam Định', N'Nữ'),
(N'Hoàng Văn O', '1978-03-15', N'Tuyên Quang', N'Nam'),
(N'Vũ Thị P', '1989-04-16', N'Lào Cai', N'Nữ'),
(N'Bùi Văn Q', '1996-05-17', N'Lạng Sơn', N'Nam'),
(N'Đỗ Thị R', '1997-06-18', N'Cao Bằng', N'Nữ'),
(N'Phan Văn S', '1983-07-19', N'Bắc Giang', N'Nam'),
(N'Ngô Thị T', '1998-08-20', N'Hà Giang', N'Nữ');


INSERT INTO PhieuKhamBenh (ngayKham, trieuChung, maBenhNhan, maTaiKhoan) VALUES
('2024-01-01', N'Sốt cao', 1, 1),
('2024-01-02', N'Ho', 2, 1),
('2024-01-03', N'Đau bụng', 3, 1),
('2024-01-04', N'Đau đầu', 4, 1),
('2024-01-05', N'Khó thở', 5, 1),
('2024-01-06', N'Nôn mửa', 6, 1),
('2024-01-07', N'Tiêu chảy', 7, 1),
('2024-01-08', N'Chóng mặt', 8, 1),
('2024-01-09', N'Mệt mỏi', 9, 1),
('2024-01-10', N'Phát ban', 10, 1);


INSERT INTO Benh (tenBenh) VALUES
(N'Cảm cúm'),
(N'Sốt xuất huyết'),
(N'Tiểu đường'),
(N'Tăng huyết áp'),
(N'Viêm phổi'),
(N'Viêm gan B'),
(N'Sỏi thận'),
(N'Viêm họng'),
(N'Dị ứng'),
(N'Viêm dạ dày');


INSERT INTO ChuanDoan (maBenh, maPKB) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10,10);


INSERT INTO DonVi (tenDonVi) VALUES
(N'Viên'),
(N'Chai'),
(N'Ống'),
(N'Gói'),
(N'Túi'),
(N'Hộp'),
(N'Lọ'),
(N'Thỏi'),
(N'Viên nang'),
(N'Dạng lỏng');


INSERT INTO CachDung (tenCachDung) VALUES
(N'Uống sau ăn'),
(N'Uống trước ăn'),
(N'Uống khi đói'),
(N'Uống buổi sáng'),
(N'Uống buổi tối'),
(N'Tiêm'),
(N'Bôi ngoài da'),
(N'Ngậm'),
(N'Nhai'),
(N'Hít');


INSERT INTO Thuoc (tenThuoc, donGia, maCachDung, maDonVi) VALUES
(N'Paracetamol', 5000, 1, 1),
(N'Amoxicillin', 10000, 2, 1),
(N'Vitamin C', 2000, 3, 1),
(N'Ibuprofen', 8000, 4, 1),
(N'Aspirin', 7000, 5, 1),
(N'Cephalexin', 12000, 6, 3),
(N'Diclofenac', 6000, 7, 2),
(N'Ranitidine', 9000, 8, 1),
(N'Ceftriaxone', 15000, 9,9),
(N'Dexamethasone', 11000, 10 , 10);


INSERT INTO ToaThuoc (ngayKeToa, maPKB) VALUES
('2024-05-01', 1),
('2024-04-02', 2),
('2024-03-03', 3),
('2024-04-04', 4),
('2024-05-05', 5),
('2024-05-06', 6),
('2024-03-07', 7),
('2024-04-08', 8),
('2024-05-09', 9),
('2024-05-10', 10);


INSERT INTO KeThuoc (maThuoc, maToaThuoc, soLuong) VALUES
(1, 1, 10),
(2, 2, 20),
(3, 3, 15),
(4, 4, 25),
(5, 5, 30),
(6, 6, 5),
(7, 7, 10),
(8, 8, 15),
(9, 9, 20),
(10, 10, 25);


INSERT INTO DichVu (tenDichVu, tienDichVu) VALUES
(N'Khám bệnh', 50000),
(N'Chụp X-quang', 300000),
(N'Siêu âm', 200000),
(N'Chụp CT', 1000000),
(N'Nội soi', 800000),
(N'Điện tim', 150000),
(N'Khám tổng quát', 250000),
(N'Tiêm phòng', 100000),
(N'Thử máu', 200000),
(N'Kiểm tra sức khỏe', 350000);


INSERT INTO HoaDon (ngayLapHoaDon, tienThuoc, tienKham, tongTien, maPKB, maTaiKhoan) VALUES
('2024-05-01', 50000, 300000, 350000, 1, 2),
('2024-04-02', 100000, 300000, 400000, 2, 2),
('2024-03-03', 75000, 300000, 375000, 3, 2),
('2024-04-04', 125000, 300000, 425000, 4, 2),
('2024-05-05', 150000, 300000, 450000, 5, 2),
('2024-05-06', 25000, 300000, 325000, 6, 2);

