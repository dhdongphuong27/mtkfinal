-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: sql6.freemysqlhosting.net
-- Thời gian đã tạo: Th5 31, 2022 lúc 03:31 PM
-- Phiên bản máy phục vụ: 5.5.62-0ubuntu0.14.04.1
-- Phiên bản PHP: 7.0.33-0ubuntu0.16.04.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `sql6495204`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `chitietnh`
--

CREATE TABLE `chitietnh` (
  `ID` int(11) NOT NULL,
  `MaNH` int(11) DEFAULT NULL,
  `MaHH` char(10) DEFAULT NULL,
  `TenHH` varchar(50) DEFAULT NULL,
  `XuatXu` varchar(30) DEFAULT NULL,
  `DonGia` float DEFAULT NULL,
  `SL` int(11) DEFAULT NULL,
  `ThanhTien` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `chitietnh`
--

INSERT INTO `chitietnh` (`ID`, `MaNH`, `MaHH`, `TenHH`, `XuatXu`, `DonGia`, `SL`, `ThanhTien`) VALUES
(1, 1, '1', 'asda', 'asda', 123, 123, 15129),
(2, 1, '1', 'asda', 'asda', 123, 123, 15129),
(3, 1, '1', '123', '213', 123, 123, 15129),
(4, 2, '1', '2', '123', 123, 123, 15129),
(5, 3, '1', 'abc', 'asdln', 123, 100, 12300),
(6, 4, '2', 'Hàng hóa 2', 'asdjk', 12342, 12, 148104),
(7, 4, '2', 'Hàng hóa 2', 'asdjk', 12342, 12, 148104),
(8, 4, '2', 'Hàng hóa 2', '123', 12342, 12, 148104),
(9, 4, '22', 'Hàng hóa 2', '123', 12342, 12, 148104),
(10, 5, '2', 'Hàng 2', 'saojd;', 123, 2324, 285852),
(11, 6, '2', 'Hàng hóa 2', 'saihd', 21312, 12, 255744);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `donhang`
--

CREATE TABLE `donhang` (
  `ID` int(11) NOT NULL,
  `SoHD` int(11) DEFAULT NULL,
  `MaHH` char(10) DEFAULT NULL,
  `TenHH` varchar(50) DEFAULT NULL,
  `DonGia` float DEFAULT NULL,
  `SL` int(11) DEFAULT NULL,
  `ThanhTien` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `donhang`
--

INSERT INTO `donhang` (`ID`, `SoHD`, `MaHH`, `TenHH`, `DonGia`, `SL`, `ThanhTien`) VALUES
(6, 6, '1', '2', 123, 2, 246),
(7, 6, '1', '2', 123, 2, 246),
(8, 6, '1', '2', 123, 2, 246),
(9, 6, '1', '2', 123, 2, 246),
(10, 7, '1', '2', 123, 2, 246),
(11, 7, '1', '2', 123, 2, 246),
(12, 7, '1', '2', 123, 2, 246),
(18, 9, '1', '2', 123, 5, 615),
(19, 9, '1', '2', 123, 5, 615),
(20, 11, '1', '2', 123, 3, 369),
(21, 12, '1', '2', 123, 4, 492),
(22, 12, '1', '2', 123, 4, 492),
(23, 12, '1', '2', 123, 4, 492),
(24, 17, '1', '2', 123, 3, 369),
(25, 18, '1', '2', 123, 2, 246),
(26, 19, '1', '2', 123, 3, 369),
(27, 19, '1', '2', 123, 3, 369),
(28, 20, '1', '2', 123, 2, 246),
(29, 21, '1', '2', 123, 3, 369),
(30, 22, '1', '2', 123, 3, 369),
(31, 23, '1', '2', 123, 10, 1230),
(32, 24, '1', '2', 123, 3, 369),
(33, 25, '1', '2', 123, 23, 2829),
(34, 26, '1', '2', 123, 3, 369),
(35, 26, '1', '2', 123, 2, 246),
(36, 26, '1', '2', 123, 1, 123),
(37, 27, '1', '2', 123, 2, 246),
(38, 27, '1', '2', 123, 2, 246),
(39, 27, '1', '2', 123, 2, 246),
(40, 34, '1', '2', 123, 3, 369),
(41, 35, '1', '2', 123, 2, 246),
(42, 38, '1', '2', 123, 3, 369),
(43, 40, '1', 'Tr? S?a Macchiato', 25000, 2, 50000),
(44, 40, '3', 'Tr? T?c Ly L?n', 15000, 1, 15000),
(45, 42, '1', 'Tr? S?a Macchiato', 25000, 2, 50000),
(46, 42, '5', 'Choco B?c H? ?? Xay', 25000, 1, 25000),
(47, 43, '1', 'Tr? S?a Macchiato', 25000, 2, 50000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `hanghoa`
--

CREATE TABLE `hanghoa` (
  `MaHH` char(10) NOT NULL,
  `TenHH` varchar(50) DEFAULT NULL,
  `XuatXu` varchar(30) DEFAULT NULL,
  `GiaBan` float DEFAULT NULL,
  `SL` int(11) DEFAULT NULL,
  `Loai` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `hanghoa`
--

INSERT INTO `hanghoa` (`MaHH`, `TenHH`, `XuatXu`, `GiaBan`, `SL`, `Loai`) VALUES
('1', 'Trà Sữa Macchiato', '7-Eleven', 25000, 998, 'Thức uống'),
('10', 'Cà Phê Sữa Tươi', '7-Eleven', 25000, 1000, 'Thức uống'),
('100', 'Trà Sữa Trân Châu Đường Đen', '7-Eleven', 20000, 1000, 'Thức uống'),
('11', 'Coca-Cola PET 390ml', 'Coca-Cola', 8000, 1000, 'Nước giải khát'),
('12', 'Coca-cola Sleek lon320ml_N', 'Coca-Cola', 12000, 1000, 'Nước giải khát'),
('13', 'Coca-Cola Light Lon 320_N', 'Coca-Cola', 12000, 1000, 'Nước giải khát'),
('14', 'Pepsi Cola Lon Cao 320ml', 'Pepsi', 12000, 1000, 'Nước giải khát'),
('15', 'Pepsi Black Lon Cao 320ml', 'Pepsi', 12000, 1000, 'Nước giải khát'),
('16', 'Fanta Cam PET 390ml', 'Coca-Cola', 8000, 1000, 'Nước giải khát'),
('17', 'Nước Pocari Sweat Chai 500', 'Otsuka', 15000, 1000, 'Nước giải khát'),
('18', 'Revive 500ml Chai', 'Suntory PepsiCo', 13000, 1000, 'Nước giải khát'),
('19', 'Revive Chanh MuốI 390ml', 'Suntory PepsiCo', 12000, 1000, 'Nước giải khát'),
('2', 'Trà Sữa TC Đen Macchiato', '7-Eleven', 30000, 1000, 'Thức uống'),
('20', 'Nước LaVie 500ml', 'La Vie', 6000, 1000, 'Nước giải khát'),
('21', 'Nước Aquafina 500ml', 'Suntory PepsiCo', 6000, 1000, 'Nước giải khát'),
('22', 'Strongbow Gold Lon 330', 'Nhà máy Bia Việt Nam', 25000, 1000, 'Đồ uống có cồn'),
('23', 'Strongbow Dark Fruit 330ml', 'Nhà máy Bia Việt Nam', 25000, 1000, 'Đồ uống có cồn'),
('24', 'Strongbow Berries Lon 330', 'Nhà máy Bia Việt Nam', 25000, 1000, 'Đồ uống có cồn'),
('25', 'Strongbow Peach Lon 330ml', 'Nhà máy Bia Việt Nam', 25000, 1000, 'Đồ uống có cồn'),
('26', 'Bia Heineken Lon Cao 330ml', 'Heineken', 23000, 1000, 'Đồ uống có cồn'),
('27', 'Bia Tiger 330ml', 'nhà máy bia APB', 20000, 1000, 'Đồ uống có cồn'),
('28', 'Rượu Ceccato Merlot Veneto', 'Riondo', 460000, 1000, 'Đồ uống có cồn'),
('29', 'Rượu Ceccato Pinot Grigio', 'Riondo', 460000, 1000, 'Đồ uống có cồn'),
('3', 'Trà Tắc Ly Lớn', '7-Eleven', 15000, 1000, 'Thức uống'),
('30', 'Rượu Ispritz Frizzante', 'Riondo', 455000, 1000, 'Đồ uống có cồn'),
('31', 'Rượu Bel.Angle Cab Sauv 75', 'La Belle Angele', 505000, 1000, 'Đồ uống có cồn'),
('32', 'Rượu Bel.Angle SauvBlanc75', 'La Belle Angele', 505000, 1000, 'Đồ uống có cồn'),
('33', 'Xúc Xích Hot Dog', '7-Eleven', 12000, 1000, 'Thức ăn nhanh'),
('34', 'Bánh Mì Xúc Xích Hot Dog', '7-Eleven', 18000, 1000, 'Thức ăn nhanh'),
('35', 'Bánh Bao Gà Nấm Phô Mai', '7-Eleven', 19000, 1000, 'Thức ăn nhanh'),
('36', 'Bánh Bao Trứng Cút Trứng Muối', '7-Eleven', 18000, 1000, 'Thức ăn nhanh'),
('37', 'Bánh Bao Xá Xíu', '7-Eleven', 18000, 1000, 'Thức ăn nhanh'),
('38', 'Bánh Bao Hoàng Kim', '7-Eleven', 13000, 1000, 'Thức ăn nhanh'),
('39', 'Bánh Bao Khoai Môn', '7-Eleven', 6000, 1000, 'Thức ăn nhanh'),
('4', 'Yo-Cruz Việt Quất', '7-Eleven', 35000, 1000, 'Thức uống'),
('40', 'Bánh Giò', '7-Eleven', 13000, 1000, 'Thức ăn nhanh'),
('41', 'Bánh Giò Gà Nấm Đông Cô', '7-Eleven', 14000, 1000, 'Thức ăn nhanh'),
('42', 'Xíu Mại Hấp', '7-Eleven', 13000, 1000, 'Thức ăn nhanh'),
('43', 'Xôi Thịt Kho Trứng', '7-Eleven', 20000, 1000, 'Thức ăn nhanh'),
('44', 'Cơm Chiên Hải Sản Sa Tế', '7-Eleven', 37000, 1000, 'Thực phẩm mang đi'),
('45', 'Cơm Trộn Hàn Quốc', '7-Eleven', 35000, 1000, 'Thực phẩm mang đi'),
('46', 'Cơm Gà Cay Sốt Mật Ong', '7-Eleven', 35000, 1000, 'Thực phẩm mang đi'),
('47', 'Cơm Thịt Xá Xíu', '7-Eleven', 32000, 1000, 'Thực phẩm mang đi'),
('48', 'Cơm Chiên Kim Chi', '7-Eleven', 30000, 1000, 'Thực phẩm mang đi'),
('49', 'Cơm Chiên Dương Châu', '7-Eleven', 35000, 1000, 'Thực phẩm mang đi'),
('5', 'Choco Bạc Hà Đá Xay', '7-Eleven', 25000, 1000, 'Thức uống'),
('50', 'Cơm Rang Dưa Bò', '7-Eleven', 37000, 1000, 'Thực phẩm mang đi'),
('51', 'Cơm Bò Sốt Tiêu Đen', '7-Eleven', 37000, 1000, 'Thực phẩm mang đi'),
('52', 'Bún Bò Huế', '7-Eleven', 38000, 1000, 'Thực phẩm mang đi'),
('53', 'Bún Thái', '7-Eleven', 37000, 1000, 'Thực phẩm mang đi'),
('54', 'Mì Ý Sốt Bò Bằm', '7-Eleven', 35000, 1000, 'Thực phẩm mang đi'),
('55', 'Bánh Quy Danisa 200g', 'Danisa', 69000, 1000, 'Đồ ăn vặt'),
('56', 'AFC Dinh Dưỡng Rau Cải 200', 'AFC', 35000, 1000, 'Đồ ăn vặt'),
('57', 'Cosy Quế Chocolate 132g', 'Cosy', 17000, 1000, 'Đồ ăn vặt'),
('58', 'Socola Meiji Đen 50g', 'Meiji', 50000, 1000, 'Đồ ăn vặt'),
('59', 'Socola Meiji Sữa 50g', 'Meiji', 48000, 1000, 'Đồ ăn vặt'),
('6', 'Sinh Tố Chuối Choco', '7-Eleven', 30000, 1000, 'Thức uống'),
('60', 'Sôcôla KitKat Chunky', 'KitKat', 19000, 1000, 'Đồ ăn vặt'),
('61', 'Sôcôla KitKat 4F', 'KitKat', 15000, 1000, 'Đồ ăn vặt'),
('62', 'Choco M&M Peanut 90g', 'M&M', 47000, 1000, 'Đồ ăn vặt'),
('63', 'Kẹo Choco M&M Milk 90g', 'M&M', 47000, 1000, 'Đồ ăn vặt'),
('64', 'Đậu Phộng Oishi Cốt Dừa', 'Oishi', 13000, 1000, 'Đồ ăn vặt'),
('65', 'Đậu Phộng Oishi Vị Mực Cay', 'Oishi', 12000, 1000, 'Đồ ăn vặt'),
('66', 'Kiwi Vàng New Hộp 4 Trái', '7-Eleven', 160000, 1000, 'Trái cây'),
('67', 'Dưa Lưới TopMeal 1.3kg up', '7-Eleven', 53000, 1000, 'Trái cây'),
('68', 'Cam Navel Mỹ Hộp 3Trái', '7-Eleven', 144000, 1000, 'Trái cây'),
('69', 'Đu Đủ Cắt Sẵn', '7-Eleven', 25000, 1000, 'Trái cây'),
('7', 'Sinh Tố Chuối', '7-Eleven', 25000, 1000, 'Thức uống'),
('70', 'Dâu Hàn Quốc Hộp 250gr', '7-Eleven', 224000, 1000, 'Trái cây'),
('71', 'Mận Hà Nội Hộp 500g', '7-Eleven', 50000, 1000, 'Trái cây'),
('72', 'Bơ Sáp ĐăkLăk HT 500gr', '7-Eleven', 38000, 1000, 'Trái cây'),
('73', 'Bưởi Da Xanh Tách Múi', '7-Eleven', 37000, 1000, 'Trái cây'),
('74', 'Mít Tươi Loại I', '7-Eleven', 29000, 1000, 'Trái cây'),
('75', 'Vải U Hồng ĐakLak 500gr', '7-Eleven', 57000, 1000, 'Trái cây'),
('76', 'Xoài Tươi Loại I', '7-Eleven', 22000, 1000, 'Trái cây'),
('77', 'Kem Mini Yukimi Daifuku', 'Lotte', 90000, 1000, 'Đồ đông lạnh'),
('78', 'Kem Sandwich PM V.Quất 65g', 'Nestle', 23000, 1000, 'Đồ đông lạnh'),
('79', 'Kem HD Vị Vani 473ml', 'Haagen-Dazs', 289000, 1000, 'Đồ đông lạnh'),
('8', 'Cà phê Đen Đá Vừa', '7-Eleven', 15000, 1000, 'Thức uống'),
('80', 'Kem HD Hạt Macadamia 100ml', 'Haagen-Dazs', 80000, 1000, 'Đồ đông lạnh'),
('81', 'Kem HD Bánh Quy & Kem 100', 'Haagen-Dazs', 80000, 1000, 'Đồ đông lạnh'),
('82', 'Kem HD Vani Hộp 100ml', 'Haagen-Dazs', 80000, 1000, 'Đồ đông lạnh'),
('83', 'Kem HD vị dâu tây 100ml', 'Haagen-Dazs', 80000, 1000, 'Đồ đông lạnh'),
('84', 'Kem OREO Sandwich 60g', 'Oreo', 28000, 1000, 'Đồ đông lạnh'),
('85', 'Kem OREO Hũ 240g', 'Oreo', 90000, 1000, 'Đồ đông lạnh'),
('86', 'Kem Cornetto Love Rose', 'Cornetto', 25000, 1000, 'Đồ đông lạnh'),
('87', 'Kem Cornetto Hokkaido CV66', 'Cornetto', 20000, 1000, 'Đồ đông lạnh'),
('88', 'Pin AA Duracell Everyday4v', 'Duracell', 42000, 1000, 'Đồ gia dụng'),
('89', 'Pin Nút Lithium Cr2032 8C', 'Lithium', 49000, 1000, 'Đồ gia dụng'),
('9', 'Cà phê Sữa Đá Vừa', '7-Eleven', 15000, 1000, 'Thức uống'),
('90', 'Áo Mưa 7-Eleven 2020', 'Duracell', 66000, 1000, 'Đồ gia dụng'),
('91', 'Áo mưa RANDO (Loại trơn)', 'RANDO', 24000, 1000, 'Đồ gia dụng'),
('92', 'Sáp Thơm Đuổi Muỗi Oasis', 'Oasis', 69000, 1000, 'Đồ gia dụng'),
('93', 'XCT Raid Không Mùi 600ml', 'Raid', 83000, 1000, 'Đồ gia dụng'),
('94', 'Xịt Đa Năng Cif 500ML TN', 'Cif', 40000, 1000, 'Đồ gia dụng'),
('95', 'Găng tay cao su dài Kinkit', 'Kinkit', 42000, 1000, 'Đồ gia dụng'),
('96', 'NG Omo Thư Thái CT Túi 2kg', 'Omo', 155000, 1000, 'Đồ gia dụng'),
('97', 'NX Comfort TN BellaTúi1.8l', 'Comfort', 170000, 1000, 'Đồ gia dụng'),
('98', 'NLS Sunlight Bạc Hà 1l 18', 'Sunlight', 38000, 1000, 'Đồ gia dụng'),
('99', 'Nước Lau Sàn Lifebuoy 1l', 'Lifebuoy', 42000, 1000, 'Đồ gia dụng');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `hoadon`
--

CREATE TABLE `hoadon` (
  `SoHD` int(11) NOT NULL,
  `NgayLap` date DEFAULT NULL,
  `TongTien` float DEFAULT NULL,
  `SauGiam` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `hoadon`
--

INSERT INTO `hoadon` (`SoHD`, `NgayLap`, `TongTien`, `SauGiam`) VALUES
(1, '0000-00-00', NULL, 0),
(2, '0000-00-00', NULL, 0),
(3, '0000-00-00', NULL, 0),
(4, '0000-00-00', NULL, 0),
(5, '0000-00-00', NULL, 0),
(6, '0000-00-00', 984, 0),
(7, '0000-00-00', 738, 0),
(8, '0000-00-00', NULL, 0),
(9, '2022-05-29', 1230, 0),
(10, '2022-05-29', NULL, 0),
(11, '2022-05-29', 369, 0),
(12, '2022-05-29', 1476, 0),
(13, '2022-05-29', NULL, 0),
(14, '2022-05-30', NULL, 0),
(15, '2022-05-30', NULL, 0),
(16, '2022-05-30', NULL, 0),
(17, '2022-05-30', NULL, 0),
(18, '2022-05-30', NULL, 0),
(19, '2022-05-30', NULL, 0),
(20, '2022-05-30', NULL, 0),
(21, '2022-05-30', NULL, 0),
(22, '2022-05-30', 369, 369),
(23, '2022-05-30', NULL, 0),
(24, '2022-05-30', 369, 359),
(25, '2022-05-30', 2829, 2546.1),
(26, '2022-05-31', 738, 538),
(27, '2022-05-31', 738, 738),
(28, '2022-05-31', NULL, 0),
(29, '2022-05-31', NULL, 0),
(30, '2022-05-31', NULL, 0),
(31, '2022-05-31', NULL, 0),
(32, '2022-05-31', NULL, 0),
(33, '2022-05-31', NULL, 0),
(34, '2022-05-31', 369, 184.5),
(35, '2022-05-31', NULL, 0),
(36, '2022-05-31', NULL, 0),
(37, '2022-05-31', NULL, 0),
(38, '2022-05-31', NULL, 0),
(39, '2022-05-31', NULL, 0),
(40, '2022-05-31', NULL, 0),
(41, '2022-05-31', NULL, 0),
(42, '2022-05-31', NULL, 0),
(43, '2022-05-31', 50000, 50000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `nhanvien`
--

CREATE TABLE `nhanvien` (
  `MaNV` char(10) NOT NULL,
  `Hoten` varchar(50) DEFAULT NULL,
  `Gioi` char(10) DEFAULT NULL,
  `ChucVu` varchar(50) DEFAULT NULL,
  `NamSinh` char(10) DEFAULT NULL,
  `SDT` char(10) DEFAULT NULL,
  `DiaChi` varchar(50) DEFAULT NULL,
  `Luong` float DEFAULT NULL,
  `TrangThai` varchar(10) NOT NULL DEFAULT 'Present'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `nhanvien`
--

INSERT INTO `nhanvien` (`MaNV`, `Hoten`, `Gioi`, `ChucVu`, `NamSinh`, `SDT`, `DiaChi`, `Luong`, `TrangThai`) VALUES
('1', 'Nguy?n Ho?ng Quang Huy', 'Nam', 'Nh?n Vi', '2000', '3242342', 'askjdans', 20000, 'Absent'),
('2', 'Phuong', 'Nam', 'Nh?n Vi', '2000', '0522052709', 'Thanh ?a', 30000, 'Absent'),
('4', '??ng Ho?ng ??ng Phuong', 'Nam', 'HR', '2000', '0522052709', 'Thanh Da', 30000, 'Absent');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `nhaphang`
--

CREATE TABLE `nhaphang` (
  `MaNH` int(11) NOT NULL,
  `NgayNH` date DEFAULT NULL,
  `ChiPhi` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `nhaphang`
--

INSERT INTO `nhaphang` (`MaNH`, `NgayNH`, `ChiPhi`) VALUES
(1, '0000-00-00', 45387),
(2, '0000-00-00', 15129),
(3, '0000-00-00', 12300),
(4, '2022-05-30', NULL),
(5, '2022-05-30', NULL),
(6, '2022-05-30', 255744);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thongke`
--

CREATE TABLE `thongke` (
  `ID` int(11) NOT NULL,
  `NgayTK` date DEFAULT NULL,
  `Thu` float DEFAULT NULL,
  `Chi` float DEFAULT NULL,
  `DoanhThu` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `thongke`
--

INSERT INTO `thongke` (`ID`, `NgayTK`, `Thu`, `Chi`, `DoanhThu`) VALUES
(5, '0000-00-00', NULL, NULL, NULL),
(6, '0000-00-00', NULL, NULL, NULL),
(7, '0000-00-00', NULL, NULL, NULL),
(8, '0000-00-00', NULL, NULL, NULL),
(9, '0000-00-00', 12, 12, 12),
(10, '0000-00-00', 12, 12, 12),
(12, '0000-00-00', NULL, NULL, NULL),
(13, '2022-05-29', NULL, NULL, NULL),
(14, '2022-05-29', NULL, NULL, NULL),
(15, '2022-05-29', NULL, NULL, NULL),
(16, '2022-05-29', 123, 222, -99),
(17, '2022-05-29', NULL, NULL, NULL),
(18, '2022-05-30', NULL, NULL, NULL),
(19, '2022-05-30', NULL, NULL, NULL),
(20, '2022-05-31', NULL, NULL, NULL),
(21, '2022-05-31', 2000000, 1500000, 500000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `usersystem`
--

CREATE TABLE `usersystem` (
  `ID` char(10) NOT NULL,
  `Account` varchar(50) DEFAULT NULL,
  `Password` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `usersystem`
--

INSERT INTO `usersystem` (`ID`, `Account`, `Password`) VALUES
('1', 'admin', 'admin'),
('2', 'nvkho', 'nvkho'),
('3', 'nvbanhang', 'nvbanhang');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `chitietnh`
--
ALTER TABLE `chitietnh`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `MaNH` (`MaNH`);

--
-- Chỉ mục cho bảng `donhang`
--
ALTER TABLE `donhang`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `SoHD` (`SoHD`);

--
-- Chỉ mục cho bảng `hanghoa`
--
ALTER TABLE `hanghoa`
  ADD PRIMARY KEY (`MaHH`);

--
-- Chỉ mục cho bảng `hoadon`
--
ALTER TABLE `hoadon`
  ADD PRIMARY KEY (`SoHD`);

--
-- Chỉ mục cho bảng `nhaphang`
--
ALTER TABLE `nhaphang`
  ADD PRIMARY KEY (`MaNH`);

--
-- Chỉ mục cho bảng `thongke`
--
ALTER TABLE `thongke`
  ADD PRIMARY KEY (`ID`);

--
-- Chỉ mục cho bảng `usersystem`
--
ALTER TABLE `usersystem`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `chitietnh`
--
ALTER TABLE `chitietnh`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT cho bảng `donhang`
--
ALTER TABLE `donhang`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;
--
-- AUTO_INCREMENT cho bảng `hoadon`
--
ALTER TABLE `hoadon`
  MODIFY `SoHD` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;
--
-- AUTO_INCREMENT cho bảng `nhaphang`
--
ALTER TABLE `nhaphang`
  MODIFY `MaNH` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT cho bảng `thongke`
--
ALTER TABLE `thongke`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `chitietnh`
--
ALTER TABLE `chitietnh`
  ADD CONSTRAINT `chitietnh_ibfk_1` FOREIGN KEY (`MaNH`) REFERENCES `nhaphang` (`MaNH`);

--
-- Các ràng buộc cho bảng `donhang`
--
ALTER TABLE `donhang`
  ADD CONSTRAINT `donhang_ibfk_1` FOREIGN KEY (`SoHD`) REFERENCES `hoadon` (`SoHD`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
