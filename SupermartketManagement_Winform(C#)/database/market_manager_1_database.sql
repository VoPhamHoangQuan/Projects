CREATE database MySupermarket_Manager_1
go
use MySupermarket_Manager_1
go


--nhân viên
create table NhanVien
(
	Idnv nchar(10) primary key,
	Fname nvarchar(30),
	Lname nvarchar(20),
	Bdate date,
	Gender nvarchar(10),
	Addr nvarchar(100),
	Idql nchar(10)  references NhanVien(Idnv),
	Position nvarchar(50),
	Picture image,
	Usename nchar(100),
	Pass nchar(20),
	Phone nchar(10)
)


--sản phẩm
create table SanPham
(
	Idsp nchar(10) primary key,
	Tensp nvarchar(20),
	Hsd date,
	Nsx date,
	Sltrenke float,
	Giagoc float,
	Giaban float,
	Picture image,
	Loaisp nvarchar(50),
	Hang nvarchar(50)
)

--kho
create table Kho
(
	Idsp nchar(10),
	Sltrongkho float
)

alter table Kho
add constraint deletesp foreign key (Idsp) references Sanpham (Idsp) on delete cascade

--kho nhập xuât
create table NhapXuatKho
(
	Idnhapxuat nchar(10) primary key,
	Idsp nchar(10) references SanPham(Idsp),
	Idqlkho nchar(10) references NhanVien(Idnv),
	Slnhapkho float,
	Ngaynhapkho date,
	Slxuatkho float,
	Ngayxuatkho date,

)

--kiểm tra HSD
create table Checkdate
(
	Idnhapxuat nchar(10) references Nhapxuatkho(Idnhapxuat),
	Trangthai nvarchar(10)
)



--Khách hàng
Create table KhachHang(
	Idkh nchar(10) primary key,
	Fname nvarchar(30),
	Lname nvarchar(20),
	Bdate date,
	Gender nvarchar(5),
	Addr nvarchar(100),
	Phone nchar(10)
)

--Bill
create table dbo.Bill
(
	Idbill int identity(1,1),
	Sp nvarchar(50),
	Sl float,
	Tongtien float	
)

--Bill chi tiết
create table BillDetail
(
	Idbill int identity(1,1),
	Ngay datetime,
	Tensp nvarchar(50),
	Idnv nchar(10) references NhanVien(Idnv),
	Slmua int,
	Tien float
)



--Doanh thu
create table DoanhThu
(
	Idsp nchar(10) references SanPham(Idsp),
	Slban float,
	Thanhtien float
)

--SET IDENTITY_INSERT dbo.Bill ON
--SET IDENTITY_INSERT BillDetail ON




