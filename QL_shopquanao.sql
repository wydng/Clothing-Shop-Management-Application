create database QLSHOPQUANAO
use QLSHOPQUANAO
--CREATE TABLE THANHVIEN(
--	MATHANHVIEN CHAR(10), --TIEM NANG , THAN THIET , CAO CAP
--	TENTHANHVIEN NVARCHAR(50),
--	NGAYSINH DATETIME,
--	NGAYDANGKI DATETIME,
--	DOANHSO INT,
--	CONSTRAINT PK_MTV PRIMARY KEY (MATHANHVIEN)
--)

--INSERT INTO THANHVIEN
--VALUES ('T')
set dateformat dmy
go
CREATE TABLE KHACHHANG(
	MAKH	char(10) not null,
	HOTEN	nvarchar(40),
	GIOITINH nvarchar(3) CHECK(GIOITINH=N'Nam' or GIOITINH=N'Nữ'),
	DCHI	nvarchar(50),
	SODT	varchar(20),
	--MATHANHVIEN CHAR(10),
	constraint pk_kh primary key(MAKH),
	--CONSTRAINT FK_MTV FOREIGN KEY(MATHANHVIEN) REFERENCES THANHVIEN(MATHANHVIEN),
)

insert into khachhang values('KH01','Nguyen Van A',N'Nam','731 Tran Hung Dao, Q5, TpHCM','8823451')
insert into khachhang values('KH02','Tran Ngoc Han',N'Nữ','23/5 Nguyen Trai, Q5, TpHCM','908256478')
insert into khachhang values('KH03','Tran Ngoc Linh',N'Nữ','45 Nguyen Canh Chan, Q1, TpHCM','938776266')
insert into khachhang values('KH04','Tran Minh Long',N'Nam','50/34 Le Dai Hanh, Q10, TpHCM','917325476')
insert into khachhang values('KH05','Le Nhat Minh',N'Nam','34 Truong Dinh, Q3, TpHCM','8246108')
insert into khachhang values('KH06','Le Hoai Thuong',N'Nữ','227 Nguyen Van Cu, Q5, TpHCM','8631738')
insert into khachhang values('KH07','Nguyen Van Tam',N'Nam','32/3 Tran Binh Trong, Q5, TpHCM','916783565')
insert into khachhang values('KH08','Phan Thi Thanh',N'Nữ','45/2 An Duong Vuong, Q5, TpHCM','938435756')
insert into khachhang values('KH09','Le Ha Vinh',N'Nam','873 Le Hong Phong, Q5, TpHCM','8654763')
insert into khachhang values('KH10','Ha Duy Lap',N'Nam','34/34B Nguyen Trai, Q1, TpHCM','8768904')


CREATE TABLE NHANVIEN(
	MANV	char(10) not null,	
	HOTEN	nvarchar(40),
	GIOITINH nvarchar(3) CHECK(GIOITINH=N'Nam' or GIOITINH=N'Nữ'),
	SODT	varchar(20),
	NGAYVAOLAM	datetime,
	taikhoan char(10) UNIQUE,
	matkhau char(20),
	chucvu nvarchar(15),
	constraint pk_nv primary key(MANV)
)
insert into nhanvien values('NV01','Nguyen Nhu Nhut',N'Nam','927345678','13/04/2021','nhunhut','12345',N'Nhân viên')
insert into nhanvien values('NV02','Le Thi Phi Yen',N'Nữ','987567390','21/04/2021','phiyen','12345',N'Nhân viên')
insert into nhanvien values('NV03','Nguyen Van B',N'Nam','997047382','27/04/2022','vanb','12345',N'Quản lý')
insert into nhanvien values('NV04','Ngo Thanh Tuan',N'Nam','913758498','24/06/2021','thanhtuan','12345',N'Nhân viên')
insert into nhanvien values('NV05','Nguyen Thi Truc Thanh',N'Nữ','918590387','20/07/2021','tructhanh','12345',N'Quản lý')


CREATE TABLE LOAI(
	MaLoai varchar(10),
	TenLoai NVARCHAR(50),
	CONSTRAINT PK_MALOAI PRIMARY KEY (MALOAI)
)
insert into LOAI(MaLoai,TenLoai)
Values	('A01',N'Áo thun'),
		('A02',N'Áo khoác'),
		('Q01',N'Quần kaki'),
		('Q02',N'Quần jean')

		
CREATE TABLE SANPHAM(
	MASP	char(10) not null,
	TENSP	nvarchar(40),
	--SIZE char(10) check (SIZE = 'XS' or SIZE = 'S' or SIZE = 'M' or SIZE = 'L' or SIZE = 'XL' or SIZE = 'XLL' or SIZE = 'XLLL'),
	NgayNhap datetime,
	TinhTrang nvarchar(20) check (TinhTrang=N'Còn hàng' or TinhTrang = N'Hết hàng'),
	SoLuong int,
	GiaBan int,
	ChatLieu nvarchar(50),
	NhaSX	nvarchar(100),
	MaLoai varchar(10),
	constraint pk_sp primary key(MASP),
	CONSTRAINT FK_MALOAI FOREIGN KEY (MaLoai) REFERENCES LOAI(MaLoai)
)
insert into sanpham values('P01',N'Áo thun nam','20/10/2021',N'Còn hàng',50,300000,'Cotton',N'Công Ty TNHH Dệt Kim Lý Gia Nguyễn','A01')
insert into sanpham values('P02',N'Áo thun nữ','29/12/2020',N'Còn hàng',30,300000,'Cotton',N'Công Ty TNHH Dệt Kim Lý Gia Nguyễn','A01')
insert into sanpham values('P03',N'Áo khoác nam','18/1/2021',N'Còn hàng',20,400000,'Poly',N'Công Ty TNHH Công Nghiệp Dệt May Thái Bình Dương','A02')
insert into sanpham values('P04',N'Áo khoác nữ','1/1/2021',N'Còn hàng',30,400000,'Poly',N'Công Ty TNHH Công Nghiệp Dệt May Thái Bình Dương','A01')
insert into sanpham values('P05',N'Quần kaki nam','9/3/2022',N'Còn hàng',60,500000,'Kaki',N'Công Ty TNHH Việt Ánh Dương','Q01')
insert into sanpham values('P06',N'Quần jean nam','9/3/2022',N'Còn hàng',60,500000,'Cotton',N'Công Ty TNHH Việt Ánh Dương','Q02')
insert into sanpham values('P07',N'Quần kaki nữ','18/1/2022',N'Còn hàng',30,500000,'Kaki',N'Công Ty TNHH Nam Đăng','Q01')
insert into sanpham values('P08',N'Quần jean nữ','18/1/2022',N'Còn hàng',30,500000,'Cotton',N'Công Ty TNHH Nam Đăng','A02')




CREATE TABLE HOADON(
	SOHD	int not null,
	NGHD 	datetime,
	MAKH 	char(10),
	MANV 	char(10),
	constraint pk_hd primary key(SOHD),
	constraint fk01_HD FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH),
	constraint fk02_HD FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
)
insert into hoadon values(1001,'23/07/2006','KH01','NV01')
insert into hoadon values(1002,'12/08/2006','KH01','NV02')
insert into hoadon values(1003,'23/08/2006','KH02','NV01')
insert into hoadon values(1004,'01/09/2006','KH02','NV01')
insert into hoadon values(1005,'20/10/2006','KH01','NV02')
insert into hoadon values(1006,'16/10/2006','KH01','NV03')
insert into hoadon values(1007,'28/10/2006','KH03','NV03')
insert into hoadon values(1008,'28/10/2006','KH01','NV03')
insert into hoadon values(1009,'28/10/2006','KH03','NV04')
insert into hoadon values(1010,'01/11/2006','KH01','NV01')
insert into hoadon values(1011,'04/11/2006','KH04','NV03')
insert into hoadon values(1012,'30/11/2006','KH05','NV03')
insert into hoadon values(1013,'12/12/2006','KH06','NV01')
insert into hoadon values(1014,'31/12/2006','KH03','NV02')
insert into hoadon values(1015,'01/01/2007','KH06','NV01')
insert into hoadon values(1016,'01/01/2007','KH07','NV02')
insert into hoadon values(1017,'02/01/2007','KH08','NV03')
insert into hoadon values(1018,'13/01/2007','KH08','NV03')
insert into hoadon values(1019,'13/01/2007','KH01','NV03')
insert into hoadon values(1020,'14/01/2007','KH09','NV04')
insert into hoadon values(1021,'16/01/2007','KH10','NV03')
insert into hoadon values(1022,'16/01/2007',Null,'NV03')
insert into hoadon values(1023,'17/01/2007',Null,'NV01')

CREATE TABLE CTHD(
	SOHD	int,
	MASP	char(10),
	SL		int,
	DONGIA INT,
	THANHTIEN int,
	constraint pk_cthd primary key(SOHD,MASP),
	constraint fk01_CTHD FOREIGN KEY(SOHD) REFERENCES HOADON(SOHD),
	constraint fk02_CTHD FOREIGN KEY(MASP) REFERENCES SANPHAM(MASP)
)
insert into cthd values(1001,'P01',4,300000,1200000)
insert into cthd values(1001,'P02',2,300000,600000)
insert into cthd values(1002,'P04',1,400000,400000)
insert into cthd values(1002,'P01',2,300000,600000)
insert into cthd values(1003,'P03',3,400000,1200000)
insert into cthd values(1004,'P05',2,500000,1000000)
insert into cthd values(1004,'P04',1,400000,400000)
insert into cthd values(1004,'P06',3,500000,1500000)
insert into cthd values(1005,'P01',3,300000,900000)
insert into cthd values(1006,'P02',2,300000,600000)
insert into cthd values(1006,'P03',3,400000,1200000)
insert into cthd values(1006,'P04',1,400000,400000)
insert into cthd values(1007,'P07',1,500000,500000)
insert into cthd values(1008,'P03',8,400000,3200000)
insert into cthd values(1009,'P05',1,500000,500000)
insert into cthd values(1010,'P03',5,400000,2000000)
insert into cthd values(1010,'P08',5,500000,2500000)
insert into cthd values(1010,'P02',10,300000,3000000)
insert into cthd values(1010,'P04',10,400000,4000000)
insert into cthd values(1011,'P03',9,400000,3600000)
insert into cthd values(1012,'P01',3,300000,900000)
insert into cthd values(1013,'P03',5,400000,2000000)
insert into cthd values(1014,'P06',8,500000,4000000)
insert into cthd values(1014,'P02',1,300000,300000)
insert into cthd values(1014,'P03',6,400000,2400000)
insert into cthd values(1014,'P01',5,300000,1500000)
insert into cthd values(1015,'P07',3,500000,1500000)
insert into cthd values(1015,'P01',7,300000,2100000)
insert into cthd values(1016,'P02',5,300000,1500000)
insert into cthd values(1017,'P03',1,400000,400000)
insert into cthd values(1017,'P08',1,500000,500000)
insert into cthd values(1018,'P02',6,300000,1800000)
insert into cthd values(1019,'P02',1,300000,300000)
insert into cthd values(1019,'P08',2,500000,1000000)
insert into cthd values(1020,'P03',1,400000,400000)
insert into cthd values(1021,'P04',5,400000,2000000)
insert into cthd values(1021,'P07',1,500000,500000)
insert into cthd values(1022,'P01',1,300000,300000)
insert into cthd values(1023,'P06',6,500000,3000000)

select * from KHACHHANG
select * from NHANVIEN
select * from SANPHAM
select * from HOADON
select * from LOAI
select * from CTHD

Delete from NhanVien where MANV = 'gh'
Select * from NHANVIEN

go
create VIEW [dbo].[XuatHoaDon]
as
select HOADON.SOHD,HOADON.MAKH,HOADON.MANV,HOADON.NGHD,CTHD.DONGIA,CTHD.MASP,CTHD.SL,CTHD.THANHTIEN
from HOADON,CTHD
where HOADON.SOHD = CTHD.SOHD
GO
select *from XuatHoaDon


go

--xuất tên khách hàng
--create proc XuatHoTenKH @hoten nvarchar(30)
--as
--select * from KHACHHANG where HOTEN like 'a%'
--go
--exec XuatHoTenKH N'Van'

--xuất tên nhân viên


















