USE [DoAn_lttq]
GO
/****** Object:  Trigger [TRG_NHANVIEN_UPDATE]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP TRIGGER IF EXISTS [dbo].[TRG_NHANVIEN_UPDATE]
GO
/****** Object:  Trigger [TRG_NHANVIEN_INSERT]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP TRIGGER IF EXISTS [dbo].[TRG_NHANVIEN_INSERT]
GO
/****** Object:  Trigger [TRG_NHANVIEN_DELETE]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP TRIGGER IF EXISTS [dbo].[TRG_NHANVIEN_DELETE]
GO
/****** Object:  Trigger [Xóa hóa đơn DV]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP TRIGGER IF EXISTS [dbo].[Xóa hóa đơn DV]
GO
/****** Object:  Trigger [Thêm hóa đơn DV]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP TRIGGER IF EXISTS [dbo].[Thêm hóa đơn DV]
GO
/****** Object:  Trigger [Chỉnh sửa hóa đơn DV]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP TRIGGER IF EXISTS [dbo].[Chỉnh sửa hóa đơn DV]
GO
/****** Object:  Trigger [Xóa HD bàn]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP TRIGGER IF EXISTS [dbo].[Xóa HD bàn]
GO
/****** Object:  Trigger [Thêm HD bàn]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP TRIGGER IF EXISTS [dbo].[Thêm HD bàn]
GO
/****** Object:  Trigger [Chỉnh sửa HD bàn]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP TRIGGER IF EXISTS [dbo].[Chỉnh sửa HD bàn]
GO
/****** Object:  Trigger [Thêm hóa đơn]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP TRIGGER IF EXISTS [dbo].[Thêm hóa đơn]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HOADONDV]') AND type in (N'U'))
ALTER TABLE [dbo].[HOADONDV] DROP CONSTRAINT IF EXISTS [FK_HOADONDV_HOADON]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HOADONDV]') AND type in (N'U'))
ALTER TABLE [dbo].[HOADONDV] DROP CONSTRAINT IF EXISTS [FK_HOADONDV_DICHVU]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HOADONBAN]') AND type in (N'U'))
ALTER TABLE [dbo].[HOADONBAN] DROP CONSTRAINT IF EXISTS [FK_HOADONBAN_HOADON]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HOADONBAN]') AND type in (N'U'))
ALTER TABLE [dbo].[HOADONBAN] DROP CONSTRAINT IF EXISTS [FK_HOADONBAN_BAN]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HOADON]') AND type in (N'U'))
ALTER TABLE [dbo].[HOADON] DROP CONSTRAINT IF EXISTS [FK_HOADON_NHANVIEN]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HOADON]') AND type in (N'U'))
ALTER TABLE [dbo].[HOADON] DROP CONSTRAINT IF EXISTS [FK_HOADON_KHACHHANG]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NHANVIEN]') AND type in (N'U'))
ALTER TABLE [dbo].[NHANVIEN] DROP CONSTRAINT IF EXISTS [DF_NHANVIEN_TENDANGNHAP]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NHANVIEN]') AND type in (N'U'))
ALTER TABLE [dbo].[NHANVIEN] DROP CONSTRAINT IF EXISTS [DF_NHANVIEN_MATKHAU]
GO
/****** Object:  Index [UNQ_CCCD]    Script Date: 02/01/2023 5:35:44 CH ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NHANVIEN]') AND type in (N'U'))
ALTER TABLE [dbo].[NHANVIEN] DROP CONSTRAINT IF EXISTS [UNQ_CCCD]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP TABLE IF EXISTS [dbo].[NHANVIEN]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP TABLE IF EXISTS [dbo].[KHACHHANG]
GO
/****** Object:  Table [dbo].[HOADONDV]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP TABLE IF EXISTS [dbo].[HOADONDV]
GO
/****** Object:  Table [dbo].[HOADONBAN]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP TABLE IF EXISTS [dbo].[HOADONBAN]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP TABLE IF EXISTS [dbo].[HOADON]
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP TABLE IF EXISTS [dbo].[DICHVU]
GO
/****** Object:  Table [dbo].[BAN]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP TABLE IF EXISTS [dbo].[BAN]
GO
USE [master]
GO
/****** Object:  Database [DoAn_lttq]    Script Date: 02/01/2023 5:35:44 CH ******/
DROP DATABASE IF EXISTS [DoAn_lttq]
GO
/****** Object:  Database [DoAn_lttq]    Script Date: 02/01/2023 5:35:44 CH ******/
CREATE DATABASE [DoAn_lttq]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DoAn_lttq', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DoAn_lttq.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DoAn_lttq_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DoAn_lttq_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DoAn_lttq] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DoAn_lttq].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DoAn_lttq] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DoAn_lttq] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DoAn_lttq] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DoAn_lttq] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DoAn_lttq] SET ARITHABORT OFF 
GO
ALTER DATABASE [DoAn_lttq] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DoAn_lttq] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DoAn_lttq] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DoAn_lttq] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DoAn_lttq] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DoAn_lttq] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DoAn_lttq] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DoAn_lttq] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DoAn_lttq] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DoAn_lttq] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DoAn_lttq] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DoAn_lttq] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DoAn_lttq] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DoAn_lttq] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DoAn_lttq] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DoAn_lttq] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DoAn_lttq] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DoAn_lttq] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DoAn_lttq] SET  MULTI_USER 
GO
ALTER DATABASE [DoAn_lttq] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DoAn_lttq] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DoAn_lttq] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DoAn_lttq] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DoAn_lttq] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DoAn_lttq] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DoAn_lttq] SET QUERY_STORE = OFF
GO
USE [DoAn_lttq]
GO
/****** Object:  Table [dbo].[BAN]    Script Date: 02/01/2023 5:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAN](
	[IDBAN] [int] NOT NULL,
	[GIATIEN] [money] NULL,
	[TRANGTHAI] [bit] NULL,
 CONSTRAINT [PK_BAN] PRIMARY KEY CLUSTERED 
(
	[IDBAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 02/01/2023 5:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[IDDV] [int] NOT NULL,
	[TENDV] [nvarchar](50) NULL,
	[GIATIEN] [money] NULL,
 CONSTRAINT [PK_DICHVU] PRIMARY KEY CLUSTERED 
(
	[IDDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 02/01/2023 5:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[IDHD] [int] NOT NULL,
	[IDNV] [int] NULL,
	[IDKH] [int] NULL,
	[GIOLAPHD] [datetime] NULL,
	[THANHTIEN] [money] NULL,
	[TRANGTHAI] [bit] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[IDHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADONBAN]    Script Date: 02/01/2023 5:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONBAN](
	[IDHD] [int] NULL,
	[IDBAN] [int] NULL,
	[GIOBATDAU] [datetime] NULL,
	[GIOKETTHUC] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADONDV]    Script Date: 02/01/2023 5:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONDV](
	[IDHD] [int] NOT NULL,
	[IDDV] [int] NOT NULL,
	[SOLUONG] [int] NULL,
 CONSTRAINT [PK_HDDV] PRIMARY KEY CLUSTERED 
(
	[IDHD] ASC,
	[IDDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 02/01/2023 5:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[IDKH] [int] NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[DCHI] [nvarchar](100) NULL,
	[SODT] [char](10) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[IDKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 02/01/2023 5:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[IDNV] [int] NOT NULL,
	[HOTENNV] [nvarchar](50) NULL,
	[NGAYSINH] [datetime] NULL,
	[CCCD] [varchar](15) NULL,
	[MATKHAU] [varchar](32) NOT NULL,
	[QUYENADMIN] [bit] NULL,
	[TENDANGNHAP] [varchar](32) NOT NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[IDNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BAN] ([IDBAN], [GIATIEN], [TRANGTHAI]) VALUES (1, 100000.0000, 0)
GO
INSERT [dbo].[BAN] ([IDBAN], [GIATIEN], [TRANGTHAI]) VALUES (2, 100000.0000, 0)
GO
INSERT [dbo].[BAN] ([IDBAN], [GIATIEN], [TRANGTHAI]) VALUES (3, 120000.0000, 1)
GO
INSERT [dbo].[BAN] ([IDBAN], [GIATIEN], [TRANGTHAI]) VALUES (4, 120000.0000, 0)
GO
INSERT [dbo].[BAN] ([IDBAN], [GIATIEN], [TRANGTHAI]) VALUES (5, 150000.0000, 1)
GO
INSERT [dbo].[DICHVU] ([IDDV], [TENDV], [GIATIEN]) VALUES (1, N'Coca', 12000.0000)
GO
INSERT [dbo].[DICHVU] ([IDDV], [TENDV], [GIATIEN]) VALUES (2, N'Sting dâu', 12000.0000)
GO
INSERT [dbo].[DICHVU] ([IDDV], [TENDV], [GIATIEN]) VALUES (3, N'Sting vàng', 12000.0000)
GO
INSERT [dbo].[DICHVU] ([IDDV], [TENDV], [GIATIEN]) VALUES (4, N'Khô bò', 20000.0000)
GO
INSERT [dbo].[DICHVU] ([IDDV], [TENDV], [GIATIEN]) VALUES (5, N'Bia Tiger', 15000.0000)
GO
INSERT [dbo].[DICHVU] ([IDDV], [TENDV], [GIATIEN]) VALUES (6, N'Khô mực', 40000.0000)
GO
INSERT [dbo].[DICHVU] ([IDDV], [TENDV], [GIATIEN]) VALUES (7, N'Nước suối', 10000.0000)
GO
INSERT [dbo].[DICHVU] ([IDDV], [TENDV], [GIATIEN]) VALUES (8, N'Sprite chanh', 12000.0000)
GO
INSERT [dbo].[HOADON] ([IDHD], [IDNV], [IDKH], [GIOLAPHD], [THANHTIEN], [TRANGTHAI]) VALUES (1, 1, 1, CAST(N'2022-12-19T17:55:22.277' AS DateTime), 388000.0000, 1)
GO
INSERT [dbo].[HOADON] ([IDHD], [IDNV], [IDKH], [GIOLAPHD], [THANHTIEN], [TRANGTHAI]) VALUES (2, 3, 2, CAST(N'2022-12-19T17:55:22.277' AS DateTime), 684000.0000, 1)
GO
INSERT [dbo].[HOADONBAN] ([IDHD], [IDBAN], [GIOBATDAU], [GIOKETTHUC]) VALUES (1, 1, CAST(N'2022-12-22T11:00:00.000' AS DateTime), CAST(N'2022-12-22T14:00:00.000' AS DateTime))
GO
INSERT [dbo].[HOADONBAN] ([IDHD], [IDBAN], [GIOBATDAU], [GIOKETTHUC]) VALUES (2, 3, CAST(N'2022-12-22T11:15:00.000' AS DateTime), CAST(N'2022-12-22T15:45:00.000' AS DateTime))
GO
INSERT [dbo].[HOADONBAN] ([IDHD], [IDBAN], [GIOBATDAU], [GIOKETTHUC]) VALUES (2, 2, CAST(N'2022-12-22T15:45:00.000' AS DateTime), CAST(N'2022-12-22T16:45:00.000' AS DateTime))
GO
INSERT [dbo].[HOADONDV] ([IDHD], [IDDV], [SOLUONG]) VALUES (1, 1, 1)
GO
INSERT [dbo].[HOADONDV] ([IDHD], [IDDV], [SOLUONG]) VALUES (1, 2, 1)
GO
INSERT [dbo].[HOADONDV] ([IDHD], [IDDV], [SOLUONG]) VALUES (1, 4, 1)
GO
INSERT [dbo].[HOADONDV] ([IDHD], [IDDV], [SOLUONG]) VALUES (2, 1, 1)
GO
INSERT [dbo].[HOADONDV] ([IDHD], [IDDV], [SOLUONG]) VALUES (2, 7, 1)
GO
INSERT [dbo].[KHACHHANG] ([IDKH], [HOTEN], [DCHI], [SODT]) VALUES (1, N'Trần Hưng', N'222 Trần Hưng Đạo, Q.5, TPHCM', N'0123456789')
GO
INSERT [dbo].[KHACHHANG] ([IDKH], [HOTEN], [DCHI], [SODT]) VALUES (2, N'Đỗ Quang Tiến', N'11 Phổ Quang, Q.Phú Nhuận, TPHCM', N'0223765118')
GO
INSERT [dbo].[NHANVIEN] ([IDNV], [HOTENNV], [NGAYSINH], [CCCD], [MATKHAU], [QUYENADMIN], [TENDANGNHAP]) VALUES (1, N'Trần Thu Hà', CAST(N'2002-01-01T00:00:00.000' AS DateTime), N'12821787212', N'12345678', 1, N'admin')
GO
INSERT [dbo].[NHANVIEN] ([IDNV], [HOTENNV], [NGAYSINH], [CCCD], [MATKHAU], [QUYENADMIN], [TENDANGNHAP]) VALUES (2, N'Đỗ Hải', CAST(N'1999-03-26T00:00:00.000' AS DateTime), N'082734561289', N'26031999', 0, N'nv02')
GO
INSERT [dbo].[NHANVIEN] ([IDNV], [HOTENNV], [NGAYSINH], [CCCD], [MATKHAU], [QUYENADMIN], [TENDANGNHAP]) VALUES (3, N'Vũ Đức Thành', CAST(N'1998-05-02T00:00:00.000' AS DateTime), N'078345389752', N'30041975', 0, N'nv03')
GO
INSERT [dbo].[NHANVIEN] ([IDNV], [HOTENNV], [NGAYSINH], [CCCD], [MATKHAU], [QUYENADMIN], [TENDANGNHAP]) VALUES (4, N'Trần Anh Hà', CAST(N'2000-07-16T00:00:00.000' AS DateTime), N'079200001277', N'17251900', NULL, N'nv04')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNQ_CCCD]    Script Date: 02/01/2023 5:35:44 CH ******/
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [UNQ_CCCD] UNIQUE NONCLUSTERED 
(
	[CCCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [DF_NHANVIEN_MATKHAU]  DEFAULT ('12345678') FOR [MATKHAU]
GO
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [DF_NHANVIEN_TENDANGNHAP]  DEFAULT ('nv00') FOR [TENDANGNHAP]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([IDKH])
REFERENCES [dbo].[KHACHHANG] ([IDKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NHANVIEN] ([IDNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
ALTER TABLE [dbo].[HOADONBAN]  WITH CHECK ADD  CONSTRAINT [FK_HOADONBAN_BAN] FOREIGN KEY([IDBAN])
REFERENCES [dbo].[BAN] ([IDBAN])
GO
ALTER TABLE [dbo].[HOADONBAN] CHECK CONSTRAINT [FK_HOADONBAN_BAN]
GO
ALTER TABLE [dbo].[HOADONBAN]  WITH CHECK ADD  CONSTRAINT [FK_HOADONBAN_HOADON] FOREIGN KEY([IDHD])
REFERENCES [dbo].[HOADON] ([IDHD])
GO
ALTER TABLE [dbo].[HOADONBAN] CHECK CONSTRAINT [FK_HOADONBAN_HOADON]
GO
ALTER TABLE [dbo].[HOADONDV]  WITH CHECK ADD  CONSTRAINT [FK_HOADONDV_DICHVU] FOREIGN KEY([IDDV])
REFERENCES [dbo].[DICHVU] ([IDDV])
GO
ALTER TABLE [dbo].[HOADONDV] CHECK CONSTRAINT [FK_HOADONDV_DICHVU]
GO
ALTER TABLE [dbo].[HOADONDV]  WITH CHECK ADD  CONSTRAINT [FK_HOADONDV_HOADON] FOREIGN KEY([IDHD])
REFERENCES [dbo].[HOADON] ([IDHD])
GO
ALTER TABLE [dbo].[HOADONDV] CHECK CONSTRAINT [FK_HOADONDV_HOADON]
GO
/****** Object:  Trigger [dbo].[Thêm hóa đơn]    Script Date: 02/01/2023 5:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[Thêm hóa đơn]
on [dbo].[HOADON]
after insert
as
begin
	declare @IDHD int;
	update HOADON
	set THANHTIEN = 0
	where IDHD = @IDHD
end
GO
ALTER TABLE [dbo].[HOADON] ENABLE TRIGGER [Thêm hóa đơn]
GO
/****** Object:  Trigger [dbo].[Chỉnh sửa HD bàn]    Script Date: 02/01/2023 5:35:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[Chỉnh sửa HD bàn]
on [dbo].[HOADONBAN]
after update
as
begin
	declare @IDHD int, @IDBAN int, @THOIGIAN datetime, @GIATIEN money;
	select @IDHD = IDHD, @IDBAN = IDBAN, @THOIGIAN = GIOKETTHUC - GIOBATDAU
	from deleted;
	select @GIATIEN = GIATIEN
	from BAN where IDBAN = @IDBAN;
	update HOADON
	set THANHTIEN -= (DATEPART(HOUR, @THOIGIAN) + DATEPART(MINUTE, @THOIGIAN)/60.0) * @GIATIEN
	select @IDHD = IDHD, @IDBAN = IDBAN, @THOIGIAN = GIOKETTHUC - GIOBATDAU
	from inserted;
	select @GIATIEN = GIATIEN
	from BAN where IDBAN = @IDBAN;
	update HOADON
	set THANHTIEN += (DATEPART(HOUR, @THOIGIAN) + DATEPART(MINUTE, @THOIGIAN)/60.0) * @GIATIEN
	where IDHD = @IDHD;
end
GO
ALTER TABLE [dbo].[HOADONBAN] ENABLE TRIGGER [Chỉnh sửa HD bàn]
GO
/****** Object:  Trigger [dbo].[Thêm HD bàn]    Script Date: 02/01/2023 5:35:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[Thêm HD bàn]
on [dbo].[HOADONBAN]
after insert
as
begin
	declare @IDHD int, @IDBAN int, @THOIGIAN datetime, @GIATIEN money;
	select @IDHD = IDHD, @IDBAN = IDBAN, @THOIGIAN = GIOKETTHUC - GIOBATDAU
	from inserted;
	select @GIATIEN = GIATIEN
	from BAN where IDBAN = @IDBAN;
	update HOADON
	set THANHTIEN += (DATEPART(HOUR, @THOIGIAN) + DATEPART(MINUTE, @THOIGIAN)/60.0) * @GIATIEN
	where IDHD = @IDHD;
end
GO
ALTER TABLE [dbo].[HOADONBAN] ENABLE TRIGGER [Thêm HD bàn]
GO
/****** Object:  Trigger [dbo].[Xóa HD bàn]    Script Date: 02/01/2023 5:35:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[Xóa HD bàn]
on [dbo].[HOADONBAN]
after delete
as
begin
	declare @IDHD int, @IDBAN int, @THOIGIAN datetime, @GIATIEN money;
	select @IDHD = IDHD, @IDBAN = IDBAN, @THOIGIAN = GIOKETTHUC - GIOBATDAU
	from deleted;
	select @GIATIEN = GIATIEN
	from BAN where IDBAN = @IDBAN;
	update HOADON
	set THANHTIEN -= (DATEPART(HOUR, @THOIGIAN) + DATEPART(MINUTE, @THOIGIAN)/60.0) * @GIATIEN
	where IDHD = @IDHD;
end
GO
ALTER TABLE [dbo].[HOADONBAN] ENABLE TRIGGER [Xóa HD bàn]
GO
/****** Object:  Trigger [dbo].[Chỉnh sửa hóa đơn DV]    Script Date: 02/01/2023 5:35:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[Chỉnh sửa hóa đơn DV]
on [dbo].[HOADONDV]
after insert
as
begin
	declare @GIATIEN money, @SOLUONG int, @IDHD int;
	select @IDHD = IDHD, @SOLUONG = SOLUONG, @GIATIEN = GIATIEN
	from deleted i join DICHVU d on i.IDDV = d.IDDV;
	update HOADON
	set THANHTIEN -= @GIATIEN * @SOLUONG
	where IDHD = @IDHD
	select @IDHD = IDHD, @SOLUONG = SOLUONG, @GIATIEN = GIATIEN
	from inserted i join DICHVU d on i.IDDV = d.IDDV;
	update HOADON
	set THANHTIEN += @GIATIEN * @SOLUONG
	where IDHD = @IDHD
end
GO
ALTER TABLE [dbo].[HOADONDV] ENABLE TRIGGER [Chỉnh sửa hóa đơn DV]
GO
/****** Object:  Trigger [dbo].[Thêm hóa đơn DV]    Script Date: 02/01/2023 5:35:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[Thêm hóa đơn DV]
on [dbo].[HOADONDV]
after insert
as
begin
	declare @GIATIEN money, @SOLUONG int, @IDHD int;
	select @IDHD = IDHD, @SOLUONG = SOLUONG, @GIATIEN = GIATIEN
	from inserted i join DICHVU d on i.IDDV = d.IDDV;
	update HOADON
	set THANHTIEN += @GIATIEN * @SOLUONG
	where IDHD = @IDHD
end
GO
ALTER TABLE [dbo].[HOADONDV] ENABLE TRIGGER [Thêm hóa đơn DV]
GO
/****** Object:  Trigger [dbo].[Xóa hóa đơn DV]    Script Date: 02/01/2023 5:35:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[Xóa hóa đơn DV]
on [dbo].[HOADONDV]
after delete
as
begin
	declare @GIATIEN decimal, @SOLUONG int, @IDHD int;
	select @IDHD = IDHD, @SOLUONG = SOLUONG, @GIATIEN = GIATIEN
	from deleted d join DICHVU dv on d.IDDV = dv.IDDV;
	update HOADON
	set THANHTIEN -= @GIATIEN * @SOLUONG
	where IDHD = @IDHD
end
GO
ALTER TABLE [dbo].[HOADONDV] ENABLE TRIGGER [Xóa hóa đơn DV]
GO
/****** Object:  Trigger [dbo].[TRG_NHANVIEN_DELETE]    Script Date: 02/01/2023 5:35:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[TRG_NHANVIEN_DELETE]
on [dbo].[NHANVIEN]
after delete
as
begin
	if (not exists(
		select *
		from NHANVIEN
		where QUYENADMIN = 1
	))
	begin
		rollback transaction;
		print N'Không thể xóa quản trị viên. Cần có tối thiểu 1 quản trị viên trong danh sách.';
	end
end
GO
ALTER TABLE [dbo].[NHANVIEN] ENABLE TRIGGER [TRG_NHANVIEN_DELETE]
GO
/****** Object:  Trigger [dbo].[TRG_NHANVIEN_INSERT]    Script Date: 02/01/2023 5:35:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[TRG_NHANVIEN_INSERT]
on [dbo].[NHANVIEN]
after insert
as
begin
	declare @TENDANGNHAP varchar(64), @IDNV int;
	select @TENDANGNHAP = TENDANGNHAP, @IDNV = IDNV
	from inserted;
	if (exists(
		select *
		from NHANVIEN
		where TENDANGNHAP = @TENDANGNHAP and IDNV != @IDNV
	))
	begin
		rollback transaction;
		print N'Tên đăng nhập bị trùng. Vui lòng thử lại';
	end
end
GO
ALTER TABLE [dbo].[NHANVIEN] ENABLE TRIGGER [TRG_NHANVIEN_INSERT]
GO
/****** Object:  Trigger [dbo].[TRG_NHANVIEN_UPDATE]    Script Date: 02/01/2023 5:35:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[TRG_NHANVIEN_UPDATE]
on [dbo].[NHANVIEN]
after update
as
if (update(TENDANGNHAP))
begin
	declare @TENDANGNHAP varchar(64), @IDNV int;
	select @TENDANGNHAP = TENDANGNHAP, @IDNV = IDNV
	from inserted;
	if (exists(
		select *
		from NHANVIEN
		where TENDANGNHAP = @TENDANGNHAP and IDNV != @IDNV
	))
	begin
		rollback transaction;
		print N'Tên đăng nhập bị trùng. Vui lòng thử lại';
	end
end
GO
ALTER TABLE [dbo].[NHANVIEN] ENABLE TRIGGER [TRG_NHANVIEN_UPDATE]
GO
USE [master]
GO
ALTER DATABASE [DoAn_lttq] SET  READ_WRITE 
GO
