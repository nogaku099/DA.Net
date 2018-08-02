Create Database DbNet
USE [DbNet]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 4/20/2018 1:02:51 PM ******/
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
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 4/20/2018 1:02:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaChiTietHoaDon] [nvarchar](100) NOT NULL,
	[MaHoaDon] [nvarchar](100) NOT NULL,
	[MaSanPham] [nvarchar](100) NOT NULL,
	[SoLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 4/20/2018 1:02:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieuNhap] [nvarchar](10) NOT NULL,
	[MaNguyenLieu] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[MaNhaCungCap] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietSanPham]    Script Date: 4/20/2018 1:02:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietSanPham](
	[MaNguyenLieu] [nvarchar](10) NOT NULL,
	[MaSanPham] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 4/20/2018 1:02:51 PM ******/
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
	[TrangThai] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHO]    Script Date: 4/20/2018 1:02:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHO](
	[MaNguyenLieu] [nvarchar](100) NOT NULL,
	[SoLuongTon] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 4/20/2018 1:02:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[MaNguyenLieu] [nvarchar](100) NOT NULL,
	[TenNguyenLieu] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 4/20/2018 1:02:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [nvarchar](100) NOT NULL,
	[TenNhaCungCap] [nvarchar](100) NOT NULL,
	[DienThoaiNhaCungCap] [nvarchar](100) NOT NULL,
	[DiaChiNhaCungCap] [nvarchar](100) NOT NULL,
	[MaNguyenLieu] [nvarchar](100) NOT NULL,
	[GiaNhap] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 4/20/2018 1:02:51 PM ******/
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
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 4/20/2018 1:02:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] [nvarchar](10) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[TongTien] [float] NOT NULL,
	[MaNhanVien] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 4/20/2018 1:02:51 PM ******/
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
	[MaNguyenLieu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 4/20/2018 1:02:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TaiKhoan] [nvarchar](10) NOT NULL,
	[MatKhau] [nvarchar](16) NOT NULL,
	[MaNhanVien] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'B001', N'Trống')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'B002', N'Có Người')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'B003', N'Có Người')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'B004', N'Trống')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'B005', N'Trống')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'B006', N'Trống')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'B007', N'Trống')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'B008', N'Có Người')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'B009', N'Trống')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'B010', N'Trống')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'B011', N'Trống')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'B012', N'Trống')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'B013', N'Trống')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'B014', N'Trống')
INSERT [dbo].[Ban] ([MaBan], [TrangThai]) VALUES (N'B015', N'Trống')
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'0d80026e-6869-4670-9e0d-219d9153e005', N'e9111d9f-ca1a-429c-bbb7-e9205b98d7d6', N'SP001', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'0e9268c8-de95-4ca8-ae89-ef629812356c', N'53c76350-c0d2-4a6b-bc31-e64f1018aff7', N'SP006', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'2295b632-b78f-42de-aeb8-335020498c97', N'77e9838b-21f6-4904-82d6-68ffe6ca6aa4', N'SP002', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'32fd10aa-2195-4943-ac11-db5a20b67e15', N'121be7bd-9321-4e16-9e30-5e73612bf282', N'SP005', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'4cc711ef-3634-4087-a39a-57c024b16901', N'121be7bd-9321-4e16-9e30-5e73612bf282', N'SP001', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'501d5ef4-dd83-4d91-afc4-7978b74d90de', N'bde042b4-4f06-4ac9-b586-b6eab570183e', N'SP003', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'57c9671b-e283-4a30-890c-18ed979b99f0', N'85022b6f-6147-4ec8-9190-4281488f6932', N'SP002', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'69c5b50f-6f08-419a-b2f1-1a19c1b105d6', N'e9111d9f-ca1a-429c-bbb7-e9205b98d7d6', N'5c376a69-bfdb-4aed-aaca-9050fbfa0193', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'6d94abd0-d05c-42df-bd63-f30e16a19c0f', N'bde042b4-4f06-4ac9-b586-b6eab570183e', N'SP006', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'6dfc30e4-c6f1-48d3-a1bf-e657ce7f7fa4', N'85022b6f-6147-4ec8-9190-4281488f6932', N'5c376a69-bfdb-4aed-aaca-9050fbfa0193', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'710386da-8549-4168-8483-0a2b3d76691c', N'fe3dd9cd-e763-4f84-ba73-1a92e00d6beb', N'37b7d5ff-4274-4640-a2ec-5cc9ba84b1cf', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'9425fe9e-cd05-4d77-a92c-076f5ec73aee', N'862cfdd0-9d36-4492-af9b-57fa22edf638', N'SP003', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'97466e3c-125a-4043-bc14-66a14f7c899d', N'862cfdd0-9d36-4492-af9b-57fa22edf638', N'SP003', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'9ceaac6a-a4fa-4020-924f-1632cb818f7f', N'121be7bd-9321-4e16-9e30-5e73612bf282', N'SP006', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'a2a4752c-1343-47f8-9e7d-a5775dade8e7', N'121be7bd-9321-4e16-9e30-5e73612bf282', N'SP002', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'a49a2ccb-4e19-47bd-bf5f-e4e1d6b770d8', N'53c76350-c0d2-4a6b-bc31-e64f1018aff7', N'SP002', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'b18ca5e8-6d8a-4273-a1f4-93de2fab246c', N'e9111d9f-ca1a-429c-bbb7-e9205b98d7d6', N'ba1efd2e-b16b-4ebd-ac31-388172a9d438', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'bb5ff43b-88e1-48f5-ba78-fb17e30fd777', N'121be7bd-9321-4e16-9e30-5e73612bf282', N'SP003', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'bf8963ef-0e51-42f8-8152-ca8604982c3c', N'53c76350-c0d2-4a6b-bc31-e64f1018aff7', N'SP005', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'd1ac1e34-afe0-4ff5-8de2-60dc49347b1e', N'862cfdd0-9d36-4492-af9b-57fa22edf638', N'SP006', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'd52cff4c-b86d-46fa-be49-c27c08aed515', N'bde042b4-4f06-4ac9-b586-b6eab570183e', N'SP006', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'e8ec7e0c-d4bb-4cb9-a470-e17689ba06f6', N'bde042b4-4f06-4ac9-b586-b6eab570183e', N'SP003', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'ee959942-6f05-4ee5-a4e9-188855477b56', N'e9111d9f-ca1a-429c-bbb7-e9205b98d7d6', N'37b7d5ff-4274-4640-a2ec-5cc9ba84b1cf', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'f59e80f1-7dd8-4dc3-9af4-f28058a178dc', N'e9111d9f-ca1a-429c-bbb7-e9205b98d7d6', N'SP002', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'f9c44406-5197-46cd-9c9d-89ad2ced0b9f', N'e9111d9f-ca1a-429c-bbb7-e9205b98d7d6', N'eeeb811f-a000-406d-9179-95c54258e4ce', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSanPham], [SoLuong]) VALUES (N'ff9fc518-2e79-46db-a300-195fed8e16e6', N'85022b6f-6147-4ec8-9190-4281488f6932', N'SP001', 1)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TongTien], [MaNhanVien], [MaBan], [TrangThai]) VALUES (N'121be7bd-9321-4e16-9e30-5e73612bf282', CAST(0x0000A8C500000000 AS DateTime), 205000, N'donghai', N'B001', N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TongTien], [MaNhanVien], [MaBan], [TrangThai]) VALUES (N'53c76350-c0d2-4a6b-bc31-e64f1018aff7', CAST(0x0000A8C600000000 AS DateTime), 145000, N'', N'B004', N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TongTien], [MaNhanVien], [MaBan], [TrangThai]) VALUES (N'77e9838b-21f6-4904-82d6-68ffe6ca6aa4', CAST(0x0000A8C600000000 AS DateTime), 45000, N'', N'B002', N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TongTien], [MaNhanVien], [MaBan], [TrangThai]) VALUES (N'85022b6f-6147-4ec8-9190-4281488f6932', CAST(0x0000A8C500000000 AS DateTime), 105000, N'', N'B002', N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TongTien], [MaNhanVien], [MaBan], [TrangThai]) VALUES (N'862cfdd0-9d36-4492-af9b-57fa22edf638', CAST(0x0000A8C600000000 AS DateTime), 0, N'', N'B002', N'Chưa Thanh Toán')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TongTien], [MaNhanVien], [MaBan], [TrangThai]) VALUES (N'97558267-6b4f-4ebd-bed6-72c9f2f75690', CAST(0x0000A8C600000000 AS DateTime), 0, N'', N'B003', N'Chưa Thanh Toán')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TongTien], [MaNhanVien], [MaBan], [TrangThai]) VALUES (N'bde042b4-4f06-4ac9-b586-b6eab570183e', CAST(0x0000A8C600000000 AS DateTime), 0, N'donghai', N'B008', N'Chưa Thanh Toán')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TongTien], [MaNhanVien], [MaBan], [TrangThai]) VALUES (N'e9111d9f-ca1a-429c-bbb7-e9205b98d7d6', CAST(0x0000A8C600000000 AS DateTime), 210000, N'donghai', N'B001', N'Đã Thanh Toán')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TongTien], [MaNhanVien], [MaBan], [TrangThai]) VALUES (N'fe3dd9cd-e763-4f84-ba73-1a92e00d6beb', CAST(0x0000A8C600000000 AS DateTime), 40000, N'', N'B002', N'Đã Thanh Toán')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu]) VALUES (N'165bb4ee-a0ac-4cf1-b52c-d646bae5c38f', N'hhh')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu]) VALUES (N'1cc6e7e1-b24d-489e-90b3-89c7f42a051c', N'hhh')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu]) VALUES (N'95a90cf2-f47c-4615-8a68-5777ea69cfed', N'hhh')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [ChucVu], [SoDienThoai]) VALUES (N'NV001', N'Bui Dong Hai', N'09/10/1991', N'1096', N'Quan Ly', N'19001999')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [ChucVu], [SoDienThoai]) VALUES (N'NV002', N'THANH DANG', N'10/10/92', N'1097', N'NhanVien', N'19999')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [DuongDan], [GiaSanPham], [MaNguyenLieu]) VALUES (N'SP001', N'CAPUCINO', N'CAFE', N'E:\PRODUCT\CAPUCCINO.jpg', 35000, N'1')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [DuongDan], [GiaSanPham], [MaNguyenLieu]) VALUES (N'SP002', N'ESPRESSO', N'CAFE', N'E:\PRODUCT\ESPRESSO.jpg', 45000, N'1')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [DuongDan], [GiaSanPham], [MaNguyenLieu]) VALUES (N'SP003', N'LEMONADE', N'SODA', N'E:\PRODUCT\LEMONADE.jpg', 25000, N'1')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [DuongDan], [GiaSanPham], [MaNguyenLieu]) VALUES (N'SP004', N'BLACKBERRY', N'SODA', N'E:\PRODUCT\BLACK BERRY.jpg', 40000, N'1')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [DuongDan], [GiaSanPham], [MaNguyenLieu]) VALUES (N'SP005', N'BLUE SKY', N'COCTAIL', N'E:\PRODUCT\BLUESKY.jpg', 55000, N'1')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [DuongDan], [GiaSanPham], [MaNguyenLieu]) VALUES (N'SP006', N'MILK TEA', N'TEA', N'E:\PRODUCT\MILK TEA.jpg', 45000, N'1')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNhanVien]) VALUES (N'donghai', N'donghai', N'NV001')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [MaNhanVien]) VALUES (N'thanhdang', N'thanhdang', N'NV002')
