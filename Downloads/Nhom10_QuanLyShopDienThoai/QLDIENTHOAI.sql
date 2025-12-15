CREATE DATABASE QUANLYDIENTHOAI;
GO

USE QUANLYDIENTHOAI;
GO

-- ============================================
-- BẢNG NHÂN VIÊN
-- ============================================
CREATE TABLE NHAN_VIEN (
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    TenNV NVARCHAR(100) NOT NULL,
    TaiKhoan VARCHAR(50) UNIQUE NOT NULL,
    MatKhau VARCHAR(50) NOT NULL,
    ChucVu NVARCHAR(20) NOT NULL
);

-- ============================================
-- BẢNG SẢN PHẨM
-- ============================================
CREATE TABLE SAN_PHAM (
    MaSP INT IDENTITY(1,1) PRIMARY KEY,
    TenSP NVARCHAR(200) NOT NULL,
    GiaBan DECIMAL(18,0) NOT NULL,
    SoLuongTon INT NOT NULL,
    GiaNhap DECIMAL(18,0) NOT NULL DEFAULT 0,
    CONSTRAINT CK_GiaBan CHECK (GiaBan > 0),
    CONSTRAINT CK_SoLuong CHECK (SoLuongTon >= 0)
);

-- ============================================
-- BẢNG KHÁCH HÀNG
-- ============================================
CREATE TABLE KHACH_HANG (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    TenKH NVARCHAR(100),
    DiaChi NVARCHAR(200),
    SDT VARCHAR(15)
);

-- ============================================
-- BẢNG HÓA ĐƠN
-- ============================================
CREATE TABLE HOA_DON (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    MaNV INT NOT NULL,
    MaKH INT NOT NULL,
    NgayBan DATETIME NOT NULL,
    TongTien DECIMAL(18,0) NOT NULL,

    FOREIGN KEY (MaNV) REFERENCES NHAN_VIEN(MaNV),
    FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH)
);

-- ============================================
-- BẢNG CHI TIẾT HÓA ĐƠN
-- ============================================
CREATE TABLE CT_HOA_DON (
    MaCTHD INT IDENTITY(1,1) PRIMARY KEY,
    MaHD INT NOT NULL,
    MaSP INT NOT NULL,
    SoLuong INT NOT NULL,
    DonGia DECIMAL(18,0) NOT NULL,

    FOREIGN KEY (MaHD) REFERENCES HOA_DON(MaHD),
    FOREIGN KEY (MaSP) REFERENCES SAN_PHAM(MaSP)
);

-- ============================================
-- TRIGGER TRỪ TỒN KHO
-- ============================================
CREATE TRIGGER TRU_TONKHO
ON CT_HOA_DON
AFTER INSERT
AS
BEGIN
    UPDATE SAN_PHAM
    SET SoLuongTon = SoLuongTon - i.SoLuong
    FROM SAN_PHAM sp
    JOIN inserted i ON sp.MaSP = i.MaSP;
END;
GO

-- ============================================
-- DỮ LIỆU MẪU
-- ============================================
INSERT INTO NHAN_VIEN (TenNV, TaiKhoan, MatKhau, ChucVu) VALUES
(N'Quản trị viên','admin','123','Admin'),
(N'Nhân viên bán hàng','nv1','123','NhanVien'),
(N'Nguyễn Đẩu Thủy','admin1','123','Admin'),
(N'Hồ Quốc Nam','nv2','123','NhanVien');

INSERT INTO SAN_PHAM (TenSP, GiaBan, SoLuongTon, GiaNhap) VALUES
(N'iPhone 15 Pro Max 256GB',30000000,15,25000000),
(N'Samsung Galaxy S24 Ultra',25000000,10,22000000),
(N'Củ Sạc Nhanh 20W',450000,50,300000),
(N'Ốp Lưng Silicon iPhone 15',200000,80,120000),
(N'Tai Nghe Bluetooth Sony WH-1000XM5',7500000,8,6000000),
(N'iPhone 14 Pro 128GB',22000000,20,19000000),
(N'Xiaomi 14 Ultra',21000000,12,18000000),
(N'Pin Dự Phòng Anker 20.000mAh',900000,40,600000),
(N'Sạc Không Dây Samsung 15W',750000,35,500000),
(N'Loa Bluetooth JBL Charge 5',3500000,18,2700000);

INSERT INTO KHACH_HANG (TenKH, DiaChi, SDT) VALUES
(N'Nguyễn Đẩu Thủy',N'45 Hai Bà Trưng, Q3', '00556677'),
(N'Đỗ Đình Độ',N'78 Nguyễn Huệ, Q1', '00112233'),
(N'Ngô Đăng Khoa',N'123 Lê Lợi, Q1', '00778899'),
(N'Trần Nhật Minh',N'12 Võ Văn Kiệt, Q1','0909123456'),
(N'Lý Bảo Anh',N'98 CMT8, Q10','0934567890'),
(N'Huỳnh Tấn Phát',N'22 Lý Thường Kiệt, Q10','0915224466'),
(N'Nguyễn Văn Bình',N'76 Hoàng Sa, Q1','0903112233');

-- ============================================
-- TRUY VẤN BÁO CÁO LỢI NHUẬN
-- ============================================
SELECT 
    sp.TenSP,
    sp.GiaNhap,
    ct.DonGia AS GiaBan,
    SUM(ct.SoLuong) AS SoLuong,
    SUM(ct.SoLuong * ct.DonGia) AS DoanhThu,
    SUM((ct.DonGia - sp.GiaNhap) * ct.SoLuong) AS LoiNhuan
FROM HOA_DON hd
JOIN CT_HOA_DON ct ON hd.MaHD = ct.MaHD
JOIN SAN_PHAM sp ON ct.MaSP = sp.MaSP
GROUP BY sp.TenSP, sp.GiaNhap, ct.DonGia
ORDER BY LoiNhuan DESC;
GO
