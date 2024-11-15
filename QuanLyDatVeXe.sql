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

