USE [master]
GO
/****** Object:  Database [DBQLQuanAn]    Script Date: Friday, 24, 08, 2018 6:31:40 PM ******/
CREATE DATABASE [DBQLQuanAn]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBQLQuanAn', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DBQLQuanAn.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBQLQuanAn_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DBQLQuanAn_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DBQLQuanAn] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBQLQuanAn].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBQLQuanAn] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DBQLQuanAn] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBQLQuanAn] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBQLQuanAn] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBQLQuanAn] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBQLQuanAn] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBQLQuanAn] SET  MULTI_USER 
GO
ALTER DATABASE [DBQLQuanAn] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBQLQuanAn] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBQLQuanAn] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBQLQuanAn] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBQLQuanAn] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBQLQuanAn] SET QUERY_STORE = OFF
GO
USE [DBQLQuanAn]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [DBQLQuanAn]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: Friday, 24, 08, 2018 6:31:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[MaBan] [nvarchar](100) NOT NULL,
	[TrangThai] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: Friday, 24, 08, 2018 6:31:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaChiTietHoaDon] [nvarchar](100) NOT NULL,
	[MaHoaDon] [nvarchar](100) NOT NULL,
	[MaSanPham] [nvarchar](100) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: Friday, 24, 08, 2018 6:31:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [nvarchar](100) NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[TongTien] [float] NOT NULL,
	[MaNhanVien] [nvarchar](100) NOT NULL,
	[MaBan] [nvarchar](100) NOT NULL,
	[TrangThaiHoaDon] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: Friday, 24, 08, 2018 6:31:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](100) NOT NULL,
	[TenNhanVien] [nvarchar](100) NOT NULL,
	[NgaySinh] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[ChucVu] [nvarchar](100) NOT NULL,
	[SoDienThoai] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: Friday, 24, 08, 2018 6:31:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [nvarchar](100) NOT NULL,
	[TenSanPham] [nvarchar](100) NOT NULL,
	[LoaiSanPham] [nvarchar](100) NOT NULL,
	[DuongDan] [nvarchar](100) NOT NULL,
	[GiaSanPham] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: Friday, 24, 08, 2018 6:31:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TaiKhoan] [nvarchar](10) NOT NULL,
	[MatKhau] [nvarchar](16) NOT NULL,
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[MatKhau2] [nvarchar](16) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T01', N'Free')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T02', N'Free')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T03', N'Free')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T04', N'Free')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T05', N'Free')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T06', N'Free')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T07', N'Free')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T08', N'Free')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T09', N'Free')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T10', N'Free')
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD00202610', N'HD0020261', N'SP0002', 2, 94000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026102', N'HD0020263', N'SP0005', 1, 41000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026113', N'HD0020263', N'SP0007', 1, 149000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026124', N'HD0020263', N'SP0008', 1, 98000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026135', N'HD0020263', N'SP0009', 1, 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026146', N'HD0020263', N'SP0010', 1, 1000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026153', N'HD0020261', N'SP0003', 1, 54000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026160', N'HD0020264', N'SP0002', 1, 47000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026171', N'HD0020264', N'SP0005', 1, 41000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026182', N'HD0020264', N'SP0007', 1, 149000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026193', N'HD0020264', N'SP0008', 1, 98000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026204', N'HD0020264', N'SP0009', 1, 20000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD00202621', N'HD0020261', N'SP0005', 2, 82000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026215', N'HD0020264', N'SP0010', 1, 1000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026220', N'HD0020265', N'SP0003', 1, 54000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026231', N'HD0020265', N'SP0004', 1, 41000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026242', N'HD0020265', N'SP0005', 1, 41000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026253', N'HD0020265', N'SP0007', 1, 149000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026264', N'HD0020265', N'SP0008', 1, 98000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD002026275', N'HD0020265', N'SP0010', 1, 1000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD00202640', N'HD0020262', N'SP0004', 2, 82000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD00202651', N'HD0020262', N'SP0005', 1, 41000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD00202654', N'HD0020261', N'SP0004', 1, 41000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD00202662', N'HD0020262', N'SP0006', 1, 5000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD00202673', N'HD0020262', N'SP0008', 1, 98000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD00202680', N'HD0020263', N'SP0002', 1, 47000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong], [ThanhTien]) VALUES (N'CTHD00202691', N'HD0020263', N'SP0003', 1, 54000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TongTien], [MaNhanVien], [MaBan], [TrangThaiHoaDon]) VALUES (N'HD0020261', CAST(N'2018-08-24T12:56:11.630' AS DateTime), 271000, N'NV005', N'T01', N'Đã Thanh toán')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TongTien], [MaNhanVien], [MaBan], [TrangThaiHoaDon]) VALUES (N'HD0020262', CAST(N'2018-08-24T13:00:22.867' AS DateTime), 226000, N'NV005', N'T03', N'Đã Thanh toán')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TongTien], [MaNhanVien], [MaBan], [TrangThaiHoaDon]) VALUES (N'HD0020263', CAST(N'2018-08-24T13:02:01.680' AS DateTime), 410000, N'NV005', N'T05', N'Đã Thanh toán')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TongTien], [MaNhanVien], [MaBan], [TrangThaiHoaDon]) VALUES (N'HD0020264', CAST(N'2018-08-24T13:28:53.273' AS DateTime), 356000, N'NV005', N'T01', N'Đã Thanh toán')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TongTien], [MaNhanVien], [MaBan], [TrangThaiHoaDon]) VALUES (N'HD0020265', CAST(N'2018-08-24T13:29:10.537' AS DateTime), 384000, N'NV005', N'T01', N'Đã Thanh toán')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [ChucVu], [SoDienThoai]) VALUES (N'NV001', N'Rick S. Hellman', N'28/06/1978', N'432 Pointe River', N'NV', N'+44(737)-7442452')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [ChucVu], [SoDienThoai]) VALUES (N'NV002', N'Steeven B. Grunwald', N'19/01/1986', N'393 Brentwood Circle', N'NV', N'+44(555)-5778601')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [ChucVu], [SoDienThoai]) VALUES (N'NV0020267', N'Thử', N'27/05/1980', N'ádasff', N'NV', N'098786598235')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [ChucVu], [SoDienThoai]) VALUES (N'NV0020268', N'ádasdasd', N'22-08-2018', N'ádasd', N'QL', N'ádasd')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [ChucVu], [SoDienThoai]) VALUES (N'NV003', N'Normand M. Ring', N'03/05/1985', N'602 Spinnaker Farm', N'NV', N'+44(343)-5555092

')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [ChucVu], [SoDienThoai]) VALUES (N'NV004', N'Sullivan G. Hollander', N'28/06/1982', N'622 Rubaiyat Road', N'NV', N'+44(737)-4330837

')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [ChucVu], [SoDienThoai]) VALUES (N'NV005', N'Phan Tuấn Trọng', N'20/07/1993', N'Ở đâu đó Việt Nam', N'QL', N'+84(97)-4930868')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [ChucVu], [SoDienThoai]) VALUES (N'NV006', N'Trần Anh Tuấn', N'13/05/1994', N'Ở nhà', N'QL', N'+84(93)-8725025')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [ChucVu], [SoDienThoai]) VALUES (N'NV007', N'test phan trang 1', N'13/09/1994', N'ád', N'NV', N'123456')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [ChucVu], [SoDienThoai]) VALUES (N'NV008', N'gưegiwg', N'13/10/1995', N'1dfji', N'QL', N'18195')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [ChucVu], [SoDienThoai]) VALUES (N'NV0081', N'tưkengkwen', N'13/08/1993', N'sèniwe', N'NV', N'12498159')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [DuongDan], [GiaSanPham]) VALUES (N'SP0001', N'Kimbap
', N'Hàn Quốc', N'https://www.foody.vn/ho-chi-minh/hanuri-quan-an-han-quoc', 39000)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [DuongDan], [GiaSanPham]) VALUES (N'SP0002', N'Bánh gạo tok bok ki phô mai có mì ', N'Hàn Quốc', N'https://www.foody.vn/ho-chi-minh/hanuri-quan-an-han-quoc', 47000)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [DuongDan], [GiaSanPham]) VALUES (N'SP0003', N'Lẩu kim chi thịt heo', N'Hàn Quốc', N'https://www.foody.vn/ho-chi-minh/hanuri-quan-an-han-quoc', 54000)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [DuongDan], [GiaSanPham]) VALUES (N'SP0004', N'Bánh gạo tok buk ki phô mai không mì', N'Hàn Quốc', N'https://www.foody.vn/ho-chi-minh/hanuri-quan-an-han-quoc', 41000)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [DuongDan], [GiaSanPham]) VALUES (N'SP0005', N'Nudu kimbab', N'Hàn Quốc', N'https://www.foody.vn/ho-chi-minh/hanuri-quan-an-han-quoc', 41000)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [DuongDan], [GiaSanPham]) VALUES (N'SP0006', N'Bánh mì', N'Việt Nam', N'https://www.foody.vn/ho-chi-minh/ga-nuong-o-o-o-nguyen-hong-dao', 5000)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [DuongDan], [GiaSanPham]) VALUES (N'SP0007', N'Gà nướng ớt cay Địa Trung Hải (nguyên con)', N'Việt Nam', N'https://www.foody.vn/ho-chi-minh/ga-nuong-o-o-o-nguyen-hong-dao', 149000)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [DuongDan], [GiaSanPham]) VALUES (N'SP0008', N'Gà nướng xá xíu (nửa con)', N'Việt Nam', N'https://www.foody.vn/ho-chi-minh/ga-nuong-o-o-o-nguyen-hong-dao', 98000)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [DuongDan], [GiaSanPham]) VALUES (N'SP0009', N'Pepsi', N'Nước', N'https://www.foody.vn/ho-chi-minh/ga-nuong-o-o-o-nguyen-hong-dao', 20000)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [DuongDan], [GiaSanPham]) VALUES (N'SP0010', N'Trà Đá', N'Nước', N'-', 1000)
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNhanVien], [MatKhau2]) VALUES (N'TK002', N'123456', N'NV003', N'654321')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNhanVien], [MatKhau2]) VALUES (N'TK001', N'123456', N'NV005', N'654321')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNhanVien], [MatKhau2]) VALUES (N'TK003', N'ABCD', N'NV006', N'EFGH')
USE [master]
GO
ALTER DATABASE [DBQLQuanAn] SET  READ_WRITE 
GO
