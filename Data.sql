CREATE DATABASE QLShopHoaTuoi

USE QLShopHoaTuoi

CREATE TABLE ChiTietNH(
	ID int IDENTITY NOT NULL,
	MaNH int NULL,
	MaHH nchar(10) NULL,
	TenHH nvarchar(50) NULL,
	XuatXu nvarchar(30) NULL,
	DonGia float NULL,
	SL int NULL,
	ThanhTien float NULL,
PRIMARY KEY CLUSTERED 
(
	ID ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON PRIMARY
) ON PRIMARY


CREATE TABLE DonHang(
	ID int AUTO_INCREMENT PRIMARY KEY,
	SoHD int,
	MaHH char(10),
	TenHH varchar(50),
	DonGia float,
	SL int,
	ThanhTien float
)


CREATE TABLE HangHoa(
	MaHH nchar(10) PRIMARY KEY,
	TenHH nvarchar(50),
	XuatXu nvarchar(30),
	GiaBan float NULL,
	SL int NULL,
)


CREATE TABLE HoaDon(
	SoHD int AUTO_INCREMENT PRIMARY KEY,
	NgayLap datetime,
	TongTien float
)


CREATE TABLE NhanVien(
	MaNV char(10) NOT NULL,
	Hoten varchar(50) NULL,
	Gioi char(10) NULL,
	ChucVu varchar(50) NULL,
	NamSinh char(10) NULL,
	SDT char(10) NULL,
	DiaChi varchar(50) NULL
)


CREATE TABLE NhapHang(
	MaNH int AUTO_INCREMENT PRIMARY KEY,
	NgayNH date NULL,
	ChiPhi float NULL
)


CREATE TABLE ThongKe(
	ID int AUTO_INCREMENT PRIMARY KEY,
	NgayTK date NULL,
	Thu float NULL,
	Chi float NULL,
	DoanhThu float NULL
)


CREATE TABLE UserSystem(
	ID char(10) NOT NULL PRIMARY KEY,
	Account varchar(50),
	Password varchar(50),
)

INSERT UserSystem (ID, Account, Password) VALUES (N'1         ', N'admin', N'admin')
INSERT UserSystem (ID, Account, Password) VALUES (N'2         ', N'nvkho', N'nvkho')
INSERT UserSystem (ID, Account, Password) VALUES (N'3         ', N'nvbanhang', N'nvbanhang')

ALTER TABLE ChiTietNH  WITH CHECK ADD FOREIGN KEY(MaNH)
REFERENCES NhapHang (MaNH)

ALTER TABLE DonHang  WITH CHECK ADD FOREIGN KEY(SoHD)
REFERENCES HoaDon (SoHD)
