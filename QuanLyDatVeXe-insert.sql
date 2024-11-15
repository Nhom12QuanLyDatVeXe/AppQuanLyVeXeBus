CREATE DATABASE QL_DATVEXE
GO

USE QL_DATVEXE
GO

--======================================== INSERT DỮ LIỆU ============================================--
--- Bảng Tài Khoản
INSERT INTO TaiKhoan (ID, UserName, Pass, Quyen, TrangThai)
VALUES 
('KH0001', 'NKD001', 'password123', 'KH', 'Đang hoạt động'),
('KH0002', 'DNK002', 'password456', 'KH', 'Đang hoạt động'),
('KH0003', 'PPG011', 'ppg123', 'KH', 'Không Đang hoạt động'),
('NV0001', 'phamminhduy', 'duy123', 'NV', 'Đang hoạt động'),
('NV0002', 'nguyenthanhthuy', 'thuy123', 'NV', 'Vô hiệu hóa'),
('Admin','admin01','adminpass123','Admin','Đang hoạt động');



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
