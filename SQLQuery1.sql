create database QuanLyPhongGym
go

--drop database QuanLyPhongGym

use QuanLyPhongGym
go

create table Account
(	
	UserName NVARCHAR(100) PRIMARY KEY,
	HoVaTen NVARCHAR(100) NOT NULL,
	NgaySinh DATE Not Null,
	GioiTinh INT,
	SoDienThoai INT NOT NULL,
	Email NVARCHAR(100),
)
go
--create table GoiTap
--(	
--	MaGoiTap NVARCHAR(100) PRIMARY KEY,
--	TenGoiTap NVARCHAR(100) NOT NULL,
--	ThoiHan DATE Not Null,
--	GiaTien decimal not null,
--)
--go

create table SanPham
(	
	MaSanPham NVARCHAR(100) Not null primary key,
	TenSanPham NVARCHAR(100) NOT NULL,
	SoLuong INT NOT NULL,
	GiaTien decimal NOT NULL,
	ChiTietSanPham NVARCHAR(100),
)
go

create table PhieuThanhToan
(	
	MaHoaDon NVARCHAR(100) NOT NULL PRIMARY KEY,
	TenNguoiMua NVARCHAR(100) Not null,
	TongTien decimal not null,
	NgayMua date not null,
)
go


create table ChiTietPhieuThanhToan
(	
	MaHoaDon NVARCHAR(100) NOT NULL,
	TenSanPham NVARCHAR(100) Not null,
	SoLuongMua INT NOT NULL,
	ThanhTien decimal not null,
	--FOREIGN KEY (MaHoaDon) REFERENCES PhieuThanhToan(MaHoaDon)
	
)
go

--drop table ChiTietPhieuThanhToan
--drop table PhieuThanhToan
