create database Quanlybanthucannhanh
Go

use Quanlybanthucannhanh


CREATE TABLE LOAINHANVIEN(
MALNV CHAR(30) NOT NULL  PRIMARY KEY,
TENLNV CHAR(30) NOT NULL
)
GO

insert into LOAINHANVIEN
VALUES ('PV','Nhan vien phuc vu'),
('QL','Quan ly')
Go



CREATE TABLE NHANVIEN(
MANV CHAR (30)NOT NULL  PRIMARY KEY,
TENNV NVARCHAR(30)NOT NULL,
NGAYSINH DATETIME NOT NULL,
GIOITINH NVARCHAR(10)NOT NULL,
SDT varchar(15) NOT NULL,
MALNV CHAR(30),
FOREIGN KEY(MALNV) REFERENCES dbo.LOAINHANVIEN(MALNV)
)
go

insert into NHANVIEN
VALUES ('NV001','Nguyen Van A','2000-10-10','Nam','012897390','PV')
Go



CREATE TABLE LOAIMONAN(
MALMA CHAR(30) NOT NULL  PRIMARY KEY,
TENLMA CHAR(30) NOT NULL
)
GO

insert into LOAIMONAN
values ('DOAN',N'Do an'),
	('THUCUONG',N'Thuc uong')

CREATE TABLE MONAN(
MAMA CHAR(30) NOT NULL  PRIMARY KEY,
TENMA NVARCHAR(30)NOT NULL,
GIABAN INT,
MALMA CHAR(30),
SOLUONGHANGHOA INT,
FOREIGN KEY(MALMA) REFERENCES dbo.LOAIMONAN(MALMA)
)
GO

insert into MONAN
values ('M001','Com',10000,'DOAN',100),
('M002','Thit kho',20000,'DOAN', 200),
('M003','Pepsi',15000,'THUCUONG', 300)
Go


CREATE TABLE KHACHHANG(
MAKH CHAR(30) NOT NULL  PRIMARY KEY,
TENKH NVARCHAR(30) NOT NULL,
GIOITINH NVARCHAR(10) NULL,
DIACHI NVARCHAR(30) NOT NULL,
SDT INT
)
GO


CREATE TABLE KHUYENMAI(
MAKM int PRIMARY KEY,
TENKM NVARCHAR(30) NOT NULL,
)
GO

insert into KHUYENMAI
values (50,'Giam 50%'),
(30,'Giam 30%'),
(0,'Khong giam')


CREATE TABLE BAN(
MABN varchar(10) NOT NULL  PRIMARY KEY,
TENBN NVARCHAR(30) NOT NULL,
TRANGTHAI nvarchar (10)
)
GO

insert into BAN
values ('Ban 1','Ban 1','Trong'),
('Ban 2','Ban 2','Trong'),
('Ban 3','Ban 3','Trong'),
('Ban 4','Ban 4','Trong'),
('Ban 5','Ban 5','Trong'),
('Ban 6','Ban 6','Trong'),
('Ban 7','Ban 7','Trong'),
('Ban 8','Ban 8','Trong'),
('Ban 9','Ban 9','Trong'),
('Ban 10','Ban 10','Trong'),
('Ban 11','Ban 11','Trong'),
('Ban 12','Ban 12','Trong')
Go

create table chitiethoadon(
MACTHD int identity PRIMARY KEY,
MAMA CHAR(30) FOREIGN KEY (MAMA) REFERENCES dbo.MONAN(MAMA),
MAHD char(20) foreign key (MAHD) references dbo.HOADON(MAHD),
MABN varchar(10)  FOREIGN KEY(MABN) REFERENCES dbo.BAN(MABN),
SOLUONG INT,
)
Go

insert into chitiethoadon
values ('M001','HD1','Ban 1','NV001',10),
('M002','HD1','Ban 2','NV001',20),
('M003','HD1','Ban 2','NV001',30)
Go



CREATE TABLE HOADON(
MAHD char(20) PRIMARY KEY,
NGAYDEN DATE,
THANHTIEN INT,
MAKM int FOREIGN KEY(MAKM) REFERENCES dbo.KHUYENMAI(MAKM),
MABN varchar(10)  FOREIGN KEY(MABN) REFERENCES dbo.BAN(MABN),
TRANGTHAI varchar(20),
MANV CHAR (30) FOREIGN KEY(MANV) REFERENCES dbo.NHANVIEN(MANV),
)
GO

insert into HOADON
values ('HD1','2000-10-10',10000000,'30','Ban 1','Trong'),
('HD2','2000-10-30',10000000,'50','Ban 2','Trong'),
('HD3','2000-10-10',10000000,'0','Ban 3','Trong')
Go




drop table LOAIMONAN
drop table MONAN
drop table KHUYENMAI
drop table LOAINHANVIEN
drop table NHANVIEN
drop table HOADON
drop table chitiethoadon
drop table BAN
drop table KHACHHANG
SELECT * from LOAINHANVIEN
select * from MONAN
select * from NHANVIEN
select * from HOADON
select * from BAN
select * from chitiethoadon
select * from KHUYENMAI
drop database Quanlybanthucannhanh

select  HOADON.MABN, chitiethoadon.MAMA,chitiethoadon.SOLUONG
from chitiethoadon,HOADON
where HOADON.MAHD = 1 and HOADON.MABN = 'Ban 1'

select * from HOADON where MAHD = 2

select HOADON.MABN, chitiethoadon.MAMA,chitiethoadon.SOLUONG from chitiethoadon,HOADON where HOADON.MAHD = 2 and HOADON.MAHD = chitiethoadon.MAHD









CREATE TABLE NHAPHANG(
MAHANGHOA CHAR(30) NOT NULL PRIMARY KEY,
MAMA CHAR(30)
FOREIGN KEY(MAMA) REFERENCES dbo.MONAN(MAMA)
)
GO

insert into NHAPHANG
values ('HH001','Cut','M001'),
('HH002','Com','M002')






