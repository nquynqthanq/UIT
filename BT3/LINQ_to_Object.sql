CREATE TABLE QLSP

USE QLSP

CREATE TABLE SanPham(
	MaSanPham INT PRIMARY KEY IDENTITY(1,1),
	TenSanPham nvarchar(100),
	SoLuong int,
	DonGia Decimal(18,0),
	XuatXu nvarchar(100),
	NgayHetHan datetime,
)