CREATE DATABASE QL_DATVEXE
GO

USE QL_DATVEXE
GO

-- Bảng Khách hàng
CREATE TABLE KhachHang (
    MaKH CHAR(7) PRIMARY KEY,
    HoTen NVARCHAR(100),
    SDT NVARCHAR(15),
    Email NVARCHAR(100),
    GioiTinh NVARCHAR(10)
);

CREATE TABLE ChucVu
(
	MaChucVu INT PRIMARY KEY,
	TenChucVu NVARCHAR(30)
)
-- Bảng Nhân viên
CREATE TABLE NhanVien (
    MaNV CHAR(5) PRIMARY KEY,
    TenNV NVARCHAR(100),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    CCCD NVARCHAR(12),
    SDT NVARCHAR(15),
    Luong DECIMAL(18, 2),
    TrangThai NVARCHAR(20),
    MaChucVu INT,
	FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu)
);

-- Bảng Tuyến xe
CREATE TABLE TuyenXe (
    MaTuyenXe INT PRIMARY KEY,
    TenTuyen NVARCHAR(100),
    NgayDi DATE,
    GioDi TIME,
    DiemDi NVARCHAR(100),
    DiemDen NVARCHAR(100),
    GioXuatBen TIME,
    GioDenNoi TIME,
	KhoangCach INT
);

-- Bảng Phương tiện
CREATE TABLE PhuongTien (
    MaPhuongTien INT PRIMARY KEY,
    BienSoXe NVARCHAR(15),
    TaiXeChinh NVARCHAR(100),
    TaiXePhu NVARCHAR(100),
    SoGhe INT
);

-- Bảng Ghế
CREATE TABLE Ghe (
    MaGhe INT PRIMARY KEY,
    DonGia DECIMAL(18, 2),
    MaPhuongTien INT,
    FOREIGN KEY (MaPhuongTien) REFERENCES PhuongTien(MaPhuongTien)
);

-- Bảng Phiếu đặt vé
CREATE TABLE PhieuDatVe (
    MaPhieu INT PRIMARY KEY,
    MaKH CHAR(7),
	MaNV CHAR(5), 
    SoLuongGhe INT,
    TongTien DECIMAL(18, 2),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
	FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
)
ALTER TABLE PhieuDatVe
ADD MaTuyenXe INT
ALTER TABLE PhieuDatVe
ADD FOREIGN KEY (MaTuyenXe) REFERENCES TuyenXe(MaTuyenXe)


-- Bảng Chi tiết đặt vé (Liên kết giữa Ghế và Phiếu đặt vé)
CREATE TABLE ChiTietDatVe (
    MaPhieu INT,
    MaGhe INT,
    PRIMARY KEY (MaPhieu, MaGhe),
    FOREIGN KEY (MaPhieu) REFERENCES PhieuDatVe(MaPhieu),
    FOREIGN KEY (MaGhe) REFERENCES Ghe(MaGhe)
);

-- Bảng Hóa đơn
CREATE TABLE HoaDon (
    SoHD INT PRIMARY KEY,
    MaPhieu INT,
    ThanhTien DECIMAL(18, 2),
    TrangThai NVARCHAR(20),
	PhuongThucTT NVARCHAR(20),
    FOREIGN KEY (MaPhieu) REFERENCES PhieuDatVe(MaPhieu)
);


--======================================== INSERT DỮ LIỆU ============================================--

INSERT INTO KhachHang (MaKH, HoTen, SDT, Email, GioiTinh)
VALUES 
('KH0001', N'Nguyễn Văn A', '0912345678', 'a.nguyen@example.com', N'Nam'),
('KH0002', N'Trần Thị B', '0938765432', 'b.tran@example.com', N'Nữ'),
('KH0003', N'Lê Hoàng C', '0987654321', 'c.le@example.com', N'Nam');

INSERT INTO ChucVu(MaChucVu, TenChucVu)
VALUES 
(1, N'Admin'),
(2, N'Quản lý'),
(3, N'Nhân viên')



INSERT INTO NhanVien (MaNV, TenNV, NgaySinh, GioiTinh, CCCD, SDT, Luong, TrangThai, MaChucVu)
VALUES 
('AD001', N'Phạm Minh D', '1985-05-12', N'Nam', '123456789012', '0901123456', 12000000, N'Hoạt động', 1),
('NV001', N'Nguyễn Thị E', '1990-11-23', N'Nữ', '987654321098', '0902987654', 15000000, N'Hoạt động', 2),
('NV002', N'Trần Văn A', '1990-07-20', N'Nữ',   '123489511316', '0162717265', 15000000, N'Hoạt động', 3)

INSERT INTO TuyenXe (MaTuyenXe, TenTuyen, NgayDi, GioDi, DiemDi, DiemDen, GioXuatBen, GioDenNoi, KhoangCach)
VALUES 
(1, N'TP.HCM - Đà Lạt', '2024-10-10', '08:00', N'TP.HCM', N'Đà Lạt', '08:30', '16:00', 300),
(2, N'TP.HCM - Nha Trang', '2024-10-11', '06:00', N'TP.HCM', N'Nha Trang', '06:30', '14:30', 430),
(3, N'Hà Nội - Hải Phòng', '2024-10-12', '07:00', N'Hà Nội', N'Hải Phòng', '07:30', '10:00', 120);


INSERT INTO PhuongTien (MaPhuongTien, BienSoXe, TaiXeChinh, TaiXePhu, SoGhe)
VALUES 
(1, '51B-12345', N'Phạm Minh D', N'Trần Văn F', 45),
(2, '51B-67890', N'Nguyễn Văn G', N'Lê Văn H', 30),
(3, '29A-54321', N'Hoàng Văn I', N'Bùi Thị J', 35);


INSERT INTO Ghe (MaGhe, DonGia, MaPhuongTien)
VALUES 
(1, 300000, 1),
(2, 250000, 1),
(3, 400000, 2),
(4, 350000, 2),
(5, 200000, 3)


INSERT INTO PhieuDatVe (MaPhieu, MaKH, MaNV, SoLuongGhe, TongTien, MaTuyenXe)
VALUES 
(1, 'KH0001', 'NV001', 2, 600000, 1),
(2, 'KH0002', 'NV002', 1, 250000, 2),
(3, 'KH0003', 'NV001', 1, 400000, 3);

INSERT INTO ChiTietDatVe (MaPhieu, MaGhe)
VALUES 
(1, 1),  -- Phiếu 1 đặt ghế 1
(1, 2),  -- Phiếu 1 đặt ghế 2
(2, 3),  -- Phiếu 2 đặt ghế 3
(3, 4);  -- Phiếu 3 đặt ghế 4


INSERT INTO HoaDon (SoHD, MaPhieu, ThanhTien, TrangThai, PhuongThucTT)
VALUES 
(1001, 1, 600000, N'Đã thanh toán', N'Tiền mặt'),
(1002, 2, 250000, N'Chưa thanh toán', N'Chuyển khoản'),
(1003, 3, 400000, N'Đã thanh toán', N'Thẻ ATM');

