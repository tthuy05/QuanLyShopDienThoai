CREATE DATABASE QUANLYDIENTHOAI;
GO
USE QUANLYDIENTHOAI;
GO

CREATE TABLE NHAN_VIEN (
    MaNV INT IDENTITY PRIMARY KEY,
    TenNV NVARCHAR(100) NOT NULL,
    TaiKhoan VARCHAR(50) UNIQUE NOT NULL,
    MatKhau VARCHAR(50) NOT NULL,
    ChucVu NVARCHAR(20) NOT NULL,
    LuongCoBan DECIMAL(18,0) NOT NULL DEFAULT 3000000
);

CREATE TABLE SAN_PHAM (
    MaSP INT IDENTITY PRIMARY KEY,
    TenSP NVARCHAR(200) NOT NULL,
    GiaBan DECIMAL(18,0) NOT NULL,
    GiaNhap DECIMAL(18,0) NOT NULL DEFAULT 0,
    SoLuongTon INT NOT NULL,
    CONSTRAINT CK_GiaBan CHECK (GiaBan > 0),
    CONSTRAINT CK_GiaNhap CHECK (GiaNhap >= 0),
    CONSTRAINT CK_SoLuongTon CHECK (SoLuongTon >= 0)
);
CREATE TABLE KHACH_HANG (
    MaKH INT IDENTITY PRIMARY KEY,
    TenKH NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(200),
    SDT VARCHAR(15) UNIQUE NOT NULL
);

CREATE TABLE HOA_DON (
    MaHD INT IDENTITY PRIMARY KEY,
    MaNV INT NOT NULL,
    MaKH INT NOT NULL,
    NgayBan DATETIME NOT NULL DEFAULT GETDATE(),
    TongTien DECIMAL(18,0) NOT NULL,
    TrangThai NVARCHAR(20) NOT NULL DEFAULT N'Đã thanh toán',
    CONSTRAINT FK_HD_NV FOREIGN KEY (MaNV) REFERENCES NHAN_VIEN(MaNV),
    CONSTRAINT FK_HD_KH FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH),
    CONSTRAINT CK_TongTien CHECK (TongTien >= 0)
);

CREATE TABLE CT_HOA_DON (
    MaCTHD INT IDENTITY PRIMARY KEY,
    MaHD INT NOT NULL,
    MaSP INT NOT NULL,
    SoLuong INT NOT NULL,
    DonGia DECIMAL(18,0) NOT NULL,
    CONSTRAINT FK_CTHD_HD FOREIGN KEY (MaHD) REFERENCES HOA_DON(MaHD),
    CONSTRAINT FK_CTHD_SP FOREIGN KEY (MaSP) REFERENCES SAN_PHAM(MaSP),
    CONSTRAINT CK_SoLuongBan CHECK (SoLuong > 0),
    CONSTRAINT CK_DonGia CHECK (DonGia > 0)
);
GO
CREATE OR ALTER TRIGGER TR_CTHD_TONKHO
ON CT_HOA_DON
INSTEAD OF INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN SAN_PHAM sp ON i.MaSP = sp.MaSP
        WHERE i.SoLuong > sp.SoLuongTon
    )
    BEGIN
        RAISERROR (N'Số lượng tồn kho không đủ', 16, 1);
        ROLLBACK;
        RETURN;
    END

    INSERT INTO CT_HOA_DON (MaHD, MaSP, SoLuong, DonGia)
    SELECT MaHD, MaSP, SoLuong, DonGia FROM inserted;

    UPDATE sp
    SET sp.SoLuongTon = sp.SoLuongTon - i.SoLuong
    FROM SAN_PHAM sp
    JOIN inserted i ON sp.MaSP = i.MaSP;
END;
GO

CREATE OR ALTER VIEW VW_HOA_HONG_NHAN_VIEN
AS
SELECT
    nv.MaNV,
    nv.TenNV,
    SUM(ct.SoLuong * ct.DonGia) AS TongDoanhSo,
    SUM(ct.SoLuong * ct.DonGia) * 0.01 AS TienHoaHong
FROM HOA_DON hd
JOIN NHAN_VIEN nv ON hd.MaNV = nv.MaNV
JOIN CT_HOA_DON ct ON hd.MaHD = ct.MaHD
WHERE hd.TrangThai = N'Đã thanh toán'
GROUP BY nv.MaNV, nv.TenNV;
GO

CREATE OR ALTER PROCEDURE SP_TINH_LUONG_NHAN_VIEN
    @Thang INT,
    @Nam INT
AS
BEGIN
    SELECT 
        nv.MaNV,
        nv.TenNV,
        nv.LuongCoBan,
        ISNULL(SUM(ct.SoLuong * ct.DonGia) * 0.01, 0) AS HoaHong,
        nv.LuongCoBan + ISNULL(SUM(ct.SoLuong * ct.DonGia) * 0.01, 0) AS TongLuong
    FROM NHAN_VIEN nv
    LEFT JOIN HOA_DON hd 
        ON nv.MaNV = hd.MaNV
        AND MONTH(hd.NgayBan) = @Thang
        AND YEAR(hd.NgayBan) = @Nam
        AND hd.TrangThai = N'Đã thanh toán'
    LEFT JOIN CT_HOA_DON ct 
        ON hd.MaHD = ct.MaHD
    GROUP BY nv.MaNV, nv.TenNV, nv.LuongCoBan;
END;
GO

CREATE INDEX IDX_HD_NgayBan ON HOA_DON(NgayBan);
CREATE INDEX IDX_HD_MaNV ON HOA_DON(MaNV);
CREATE INDEX IDX_CTHD_MaHD ON CT_HOA_DON(MaHD);
CREATE INDEX IDX_CTHD_MaSP ON CT_HOA_DON(MaSP);
GO

INSERT INTO NHAN_VIEN (TenNV, TaiKhoan, MatKhau, ChucVu) VALUES
(N'Nguyễn Đẩu Thủy','admin','123','Admin'),
(N'Đỗ Đình Độ','nv1','123','NhanVien'),
(N'Hồ Quốc Nam','nv2','123','NhanVien');

INSERT INTO SAN_PHAM (TenSP, GiaBan, GiaNhap, SoLuongTon) VALUES
(N'iPhone 15 Pro Max 256GB',30000000,25000000,15),
(N'iPhone 14 Pro 128GB',22000000,19000000,20),
(N'Samsung Galaxy S24 Ultra',25000000,22000000,10),
(N'Xiaomi 14 Ultra',21000000,18000000,12),
(N'Oppo Find X7',18000000,15000000,14),
(N'Tai nghe Sony WH-1000XM5',7500000,6000000,8),
(N'Loa JBL Charge 5',3500000,2700000,18),
(N'Pin dự phòng Anker 20000mAh',900000,600000,40),
(N'Sạc nhanh Apple 20W',450000,300000,50),
(N'Ốp lưng iPhone 15 Silicon',200000,120000,80);

INSERT INTO KHACH_HANG (TenKH, DiaChi, SDT) VALUES
(N'Nguyễn Văn Bình', N'Quận 1, TP.HCM', '0903112233'),
(N'Trần Nhật Minh', N'Quận 3, TP.HCM', '0909123456'),
(N'Lý Bảo Anh', N'Quận 10, TP.HCM', '0934567890'),
(N'Huỳnh Tấn Phát', N'Quận 10, TP.HCM', '0915224466'),
(N'Ngô Đăng Khoa', N'Quận 1, TP.HCM', '00778899'),
(N'Khách lẻ', N'Tại cửa hàng', '0000000000');
GO

EXEC SP_TINH_LUONG_NHAN_VIEN 12, 2025;
select*from SAN_PHAM
select*from CT_HOA_DON