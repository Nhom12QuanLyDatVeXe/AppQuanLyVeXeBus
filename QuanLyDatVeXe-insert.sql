CREATE DATABASE QL_DATVEXE
GO

USE QL_DATVEXE
GO

CREATE TABLE TaiKhoan
(
	ID char(7) primary Key not null,
	UserName varchar(20) unique not null,
	Pass varchar(30) not null,
	Quyen varchar(10) not null,
	TrangThai varchar(20) not null
);

-- Bảng Khách hàng
CREATE TABLE KhachHang (
    MaKH CHAR(7) PRIMARY KEY,
    HoTen NVARCHAR(100),
    SDT NVARCHAR(15),
    Email NVARCHAR(100),
    GioiTinh NVARCHAR(10),
	constraint FK_KH_TK foreign Key (MaKH) references TaiKhoan(ID)
);

CREATE TABLE ChucVu
(
	MaChucVu INT PRIMARY KEY,
	TenChucVu NVARCHAR(30)
)
-- Bảng Nhân viên
CREATE TABLE NhanVien (
    MaNV CHAR(7) PRIMARY KEY,
    TenNV NVARCHAR(100),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    CCCD NVARCHAR(12),
    SDT NVARCHAR(15),
    Luong DECIMAL(18, 2),
    TrangThai NVARCHAR(20),
    MaChucVu INT,
	FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu),
	constraint FK_NV_TK foreign Key (MaNV) references TaiKhoan(ID)
);

CREATE TABLE TinhThanh
(
	MaTinh CHAR(5) PRIMARY KEY,
	TenTinh NVARCHAR(30)
)


-- Bảng Phương tiện
CREATE TABLE PhuongTien (
    BienSoXe CHAR(10) PRIMARY KEY,
    TaiXeChinh NVARCHAR(100),
    TaiXePhu NVARCHAR(100),
    SoGhe INT,
);


-- Bảng Tuyến xe
CREATE TABLE TuyenXe (
    MaTuyenXe INT PRIMARY KEY,
    TenTuyen NVARCHAR(100),
    ThoiGianDi DATETIME,
    DiemDi CHAR(5),
    DiemDen CHAR(5),
    GioXuatBen TIME,
    GioDenNoi TIME,
	KhoangCach INT,
	DonGia Money,
	BienSoXe CHAR(10),
	FOREIGN KEY (DiemDi) REFERENCES TinhThanh(MaTinh),
	FOREIGN KEY (DiemDen) REFERENCES TinhThanh(MaTinh),
	FOREIGN KEY (BienSoXe) REFERENCES PhuongTien(BienSoXe)
);


-- Bảng Phiếu đặt vé
CREATE TABLE PhieuDatVe (
    MaPhieu INT PRIMARY KEY,
    SoLuongGhe INT,
    TongTien DECIMAL(18, 2),
	MaKH CHAR(7),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
)


-- Bảng Chi tiết đặt vé (Liên kết giữa Ghế và Phiếu đặt vé)
CREATE TABLE ChiTietDatVe (
    MaPhieu INT,
    MaTuyenXe INT,
	MaGhe char(5), --SA01 -> ghế trên, SB01 -> ghế dưới
	DonGia Money,
    PRIMARY KEY (MaPhieu, MaTuyenXe, MaGhe),
    FOREIGN KEY (MaPhieu) REFERENCES PhieuDatVe(MaPhieu),
    FOREIGN KEY (MaTuyenXe) REFERENCES TuyenXe(MaTuyenXe)
);

-- Bảng Hóa đơn
CREATE TABLE HoaDon (
    SoHD INT PRIMARY KEY,
    MaPhieu INT,
    ThanhTien DECIMAL(18, 2),
    TrangThai NVARCHAR(20),
	PhuongThucTT NVARCHAR(20),
	MaNV CHAR(7),
    FOREIGN KEY (MaPhieu) REFERENCES PhieuDatVe(MaPhieu),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);


--======================================== INSERT DỮ LIỆU ============================================--
--- Bảng Tài Khoản
INSERT INTO TaiKhoan (ID, UserName, Pass, Quyen, TrangThai)
VALUES 
('KH0001', 'NKD001', 'password123', 'KhachHang', 'Hoạt động'),
('KH0002', 'DNK002', 'password456', 'KhachHang', 'Hoạt động'),
('KH0003', 'PPG011', 'ppg123', 'KhachHang', 'Không Hoạt động'),
('NV0001', 'phamminhduy', 'duy123', 'NhanVien', 'Hoạt động'),
('NV0002', 'nguyenthanhthuy', 'thuy123', 'NhanVien', 'Hoạt động'),
('Admin','admin01','adminpass123','Admin','Hoạt động');



--- Bảng Chức Vụ

INSERT INTO ChucVu (MaChucVu, TenChucVu)
VALUES 
(1, N'Admin'),
(2, N'Quản lý'),
(3, N'Nhân viên');

--- Bảng Khách Hàng

INSERT INTO KhachHang (MaKH, HoTen, SDT, Email, GioiTinh)
VALUES 
('KH0001', N'Nguyễn Văn Nam', '0912345678', 'namnguyen@example.com', N'Nam'),
('KH0002', N'Trần Thị Duyen', '0938765432', 'duyentran01@example.com', N'Nữ'),
('KH0003', N'Trần Duy Anh', '0923998123', 'tda01!@example.com', N'Nam')

---- Bảng Nhân Viên

INSERT INTO NhanVien (MaNV, TenNV, NgaySinh, GioiTinh, CCCD, SDT, Luong, TrangThai, MaChucVu)
VALUES 
('NV0001', N'Phạm Minh Duy', '1985-05-12', N'Nam', '123456789012', '0901123456', 12000000, N'Hoạt động', 1),
('NV0002', N'Nguyễn Thanh Thúy', '1990-11-23', N'Nữ', '987654321098', '0902987654', 15000000, N'Hoạt động', 1);


---- Bảng Tỉnh Thành
INSERT INTO TinhThanh (MaTinh, TenTinh)
VALUES 
('79', N'TP.HCM'),
('77', N'Đà Lạt'),
('37', N'Nha Trang');

---- Bảng Phương Tiện
INSERT INTO PhuongTien (BienSoXe, TaiXeChinh, TaiXePhu, SoGhe)
VALUES 
('51B-12345', N'Phạm Ngọc Thảo', N'Trần Văn Anh', 45),
('51B-67890', N'Nguyễn Văn Đào', N'Lê Văn Sĩ', 30),
('29A-54321', N'Hoàng Văn Nam', N'Bùi Thị Diễm Quỳnh', 35);

---- Bảng Tuyến Xe

INSERT INTO TuyenXe (MaTuyenXe, TenTuyen, ThoiGianDi, DiemDi, DiemDen, GioXuatBen, GioDenNoi, KhoangCach, DonGia, BienSoXe)
VALUES 
(1, N'TP.HCM - Đà Lạt', '2024-10-10 08:00:00', '79', '77', '08:30', '16:00', 300, 300000, '51B-12345'),
(2, N'TP.HCM - Nha Trang', '2024-10-11 06:00:00', '79', '37', '06:30', '14:30', 430, 430000, '51B-67890');


---- Bảng Phiếu Đặt Vé

INSERT INTO PhieuDatVe (MaPhieu, SoLuongGhe, TongTien, MaKH)
VALUES 
(1, 2, 600000, 'KH0001'),
(2, 1, 430000, 'KH0002');


---- Bảng Chi Tiết Phiếu Đặt Vé

INSERT INTO ChiTietDatVe (MaPhieu, MaTuyenXe, MaGhe, DonGia)
VALUES 
(1, 1, 'SA01', 300000),  
(1, 1, 'SA02', 300000),  
(2, 2, 'SB01', 430000);  
	
---- Bảng Hóa Đơn

INSERT INTO HoaDon (SoHD, MaPhieu, ThanhTien, TrangThai, PhuongThucTT, MaNV)
VALUES 
(1001, 1, 600000, N'Đã thanh toán', N'Tiền mặt', 'NV0001'),
(1002, 2, 430000, N'Chưa thanh toán', N'Chuyển khoản', 'NV0002');
