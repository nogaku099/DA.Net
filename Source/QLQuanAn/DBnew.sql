CREATE DATABASE DBQLQuanAn
USE [DBQLQuanAn]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: Tuesday, 21, 08, 2018 9:16:49 PM ******/
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
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: Tuesday, 21, 08, 2018 9:16:50 PM ******/
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
/****** Object:  Table [dbo].[HoaDon]    Script Date: Tuesday, 21, 08, 2018 9:16:50 PM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: Tuesday, 21, 08, 2018 9:16:50 PM ******/
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
/****** Object:  Table [dbo].[SanPham]    Script Date: Tuesday, 21, 08, 2018 9:16:50 PM ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: Tuesday, 21, 08, 2018 9:16:50 PM ******/
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
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T02', N'Busy')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T03', N'Free')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T04', N'Busy')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T05', N'Busy')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T06', N'Free')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T07', N'Free')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T08', N'Busy')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T09', N'Busy')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'T10', N'Busy')
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
