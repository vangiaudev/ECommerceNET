USE [master]
GO
/****** Object:  Database [DOANNET]    Script Date: 7/13/2022 2:14:59 PM ******/
CREATE DATABASE [DOANNET]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DOANNET', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DOANNET.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DOANNET_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DOANNET_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DOANNET] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DOANNET].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DOANNET] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DOANNET] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DOANNET] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DOANNET] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DOANNET] SET ARITHABORT OFF 
GO
ALTER DATABASE [DOANNET] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DOANNET] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DOANNET] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DOANNET] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DOANNET] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DOANNET] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DOANNET] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DOANNET] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DOANNET] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DOANNET] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DOANNET] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DOANNET] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DOANNET] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DOANNET] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DOANNET] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DOANNET] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [DOANNET] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DOANNET] SET RECOVERY FULL 
GO
ALTER DATABASE [DOANNET] SET  MULTI_USER 
GO
ALTER DATABASE [DOANNET] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DOANNET] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DOANNET] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DOANNET] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DOANNET] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DOANNET] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DOANNET] SET QUERY_STORE = OFF
GO
USE [DOANNET]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/13/2022 2:14:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Banner]    Script Date: 7/13/2022 2:15:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banner](
	[idBanner] [int] IDENTITY(1,1) NOT NULL,
	[hinhAnh] [nvarchar](max) NULL,
	[ngayTao] [datetime2](7) NOT NULL,
	[ngayBatDau] [datetime2](7) NOT NULL,
	[ngayKetThuc] [datetime2](7) NOT NULL,
	[url] [nvarchar](max) NULL,
	[UseridUser] [int] NULL,
 CONSTRAINT [PK_Banner] PRIMARY KEY CLUSTERED 
(
	[idBanner] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChinhSachGiaoHang]    Script Date: 7/13/2022 2:15:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChinhSachGiaoHang](
	[idChinhSachGiaoHang] [int] IDENTITY(1,1) NOT NULL,
	[tieuDe] [nvarchar](max) NULL,
	[noiDung] [nvarchar](max) NULL,
	[hinhAnh] [nvarchar](max) NULL,
	[ngayTao] [datetime2](7) NOT NULL,
	[ngayCapNhat] [datetime2](7) NOT NULL,
	[UseridUser] [int] NULL,
 CONSTRAINT [PK_ChinhSachGiaoHang] PRIMARY KEY CLUSTERED 
(
	[idChinhSachGiaoHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 7/13/2022 2:15:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[idCTDH] [int] IDENTITY(1,1) NOT NULL,
	[idDH] [int] NOT NULL,
	[tenSP] [nvarchar](max) NULL,
	[hinhSP] [nvarchar](max) NULL,
	[donGia] [int] NOT NULL,
	[soLuong] [int] NOT NULL,
	[thanhTien] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietDonHang] PRIMARY KEY CLUSTERED 
(
	[idCTDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DieuKhoanDichVu]    Script Date: 7/13/2022 2:15:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DieuKhoanDichVu](
	[idDieuKhoanDV] [int] IDENTITY(1,1) NOT NULL,
	[tieuDe] [nvarchar](max) NULL,
	[noiDung] [nvarchar](max) NULL,
	[hinhAnh] [nvarchar](max) NULL,
	[ngayTao] [datetime2](7) NOT NULL,
	[ngayCapNhat] [datetime2](7) NOT NULL,
	[UseridUser] [int] NULL,
 CONSTRAINT [PK_DieuKhoanDichVu] PRIMARY KEY CLUSTERED 
(
	[idDieuKhoanDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 7/13/2022 2:15:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[idDH] [int] IDENTITY(1,1) NOT NULL,
	[ngayDat] [datetime2](7) NOT NULL,
	[ngayCapNhat] [datetime2](7) NOT NULL,
	[hoDH] [nvarchar](10) NOT NULL,
	[tenDH] [nvarchar](50) NOT NULL,
	[diaChi] [nvarchar](200) NOT NULL,
	[eMail] [nvarchar](200) NOT NULL,
	[sdtDH] [nvarchar](10) NOT NULL,
	[ghiChu] [nvarchar](max) NULL,
	[tongTienHang] [int] NOT NULL,
	[maGiamGiaDH] [int] NOT NULL,
	[tongSoTien] [int] NOT NULL,
	[trangThai] [nvarchar](max) NULL,
	[idUser] [int] NOT NULL,
	[UseridUser] [int] NULL,
	[MaGiamGiacodeMGG] [nvarchar](450) NULL,
 CONSTRAINT [PK_DonHang] PRIMARY KEY CLUSTERED 
(
	[idDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GioHang]    Script Date: 7/13/2022 2:15:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioHang](
	[idGioHang] [int] IDENTITY(1,1) NOT NULL,
	[soLuong] [int] NOT NULL,
	[idUser] [int] NOT NULL,
	[SanPhamidSP] [int] NULL,
	[giasp] [int] NOT NULL,
	[tensp] [int] NOT NULL,
	[idsp] [int] NOT NULL,
 CONSTRAINT [PK_GioHang] PRIMARY KEY CLUSTERED 
(
	[idGioHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GioiThieu]    Script Date: 7/13/2022 2:15:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioiThieu](
	[idGioiThieu] [int] IDENTITY(1,1) NOT NULL,
	[tieuDe] [nvarchar](max) NULL,
	[noiDung] [nvarchar](max) NULL,
	[hinhAnh] [int] NOT NULL,
	[ngayTao] [datetime2](7) NOT NULL,
	[ngayCapNhat] [datetime2](7) NOT NULL,
	[UseridUser] [int] NULL,
 CONSTRAINT [PK_GioiThieu] PRIMARY KEY CLUSTERED 
(
	[idGioiThieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IPuser]    Script Date: 7/13/2022 2:15:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IPuser](
	[idIPuser] [int] IDENTITY(1,1) NOT NULL,
	[idUser] [int] NOT NULL,
	[diachiip] [nvarchar](max) NULL,
 CONSTRAINT [PK_IPuser] PRIMARY KEY CLUSTERED 
(
	[idIPuser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LienHe]    Script Date: 7/13/2022 2:15:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LienHe](
	[idLH] [int] IDENTITY(1,1) NOT NULL,
	[hoTen] [nvarchar](50) NOT NULL,
	[eMail] [nvarchar](200) NOT NULL,
	[tieuDe] [nvarchar](max) NOT NULL,
	[noiDung] [nvarchar](max) NOT NULL,
	[ngayGui] [datetime2](7) NOT NULL,
	[ngayCapNhat] [datetime2](7) NOT NULL,
	[trangThai] [nvarchar](max) NULL,
 CONSTRAINT [PK_LienHe] PRIMARY KEY CLUSTERED 
(
	[idLH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 7/13/2022 2:15:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSP](
	[idLoaiSP] [int] IDENTITY(1,1) NOT NULL,
	[tenLoaiSP] [nvarchar](50) NOT NULL,
	[hinhAnh] [nvarchar](max) NULL,
	[metaTitle] [nvarchar](max) NOT NULL,
	[trangThai] [nvarchar](max) NULL,
	[ngayTao] [datetime2](7) NOT NULL,
	[ngayCapNhat] [datetime2](7) NOT NULL,
	[idUser] [int] NOT NULL,
	[typeLoai] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiSP] PRIMARY KEY CLUSTERED 
(
	[idLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaGiamGia]    Script Date: 7/13/2022 2:15:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaGiamGia](
	[codeMGG] [nvarchar](450) NOT NULL,
	[tenMGG] [nvarchar](max) NULL,
	[giaTri] [int] NOT NULL,
	[soLuong] [int] NOT NULL,
	[trangThai] [nvarchar](max) NOT NULL,
	[ngayTao] [datetime2](7) NOT NULL,
	[ngayCapNhat] [datetime2](7) NOT NULL,
	[UseridUser] [int] NULL,
 CONSTRAINT [PK_MaGiamGia] PRIMARY KEY CLUSTERED 
(
	[codeMGG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyDinhChung]    Script Date: 7/13/2022 2:15:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinhChung](
	[idQuyDinhChung] [int] IDENTITY(1,1) NOT NULL,
	[tieuDe] [nvarchar](max) NULL,
	[noiDung] [nvarchar](max) NULL,
	[hinhAnh] [nvarchar](max) NULL,
	[ngayTao] [datetime2](7) NOT NULL,
	[ngayCapNhat] [datetime2](7) NOT NULL,
	[UseridUser] [int] NULL,
 CONSTRAINT [PK_QuyDinhChung] PRIMARY KEY CLUSTERED 
(
	[idQuyDinhChung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 7/13/2022 2:15:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[idSP] [int] IDENTITY(1,1) NOT NULL,
	[tenSP] [nvarchar](100) NOT NULL,
	[giaSP] [int] NOT NULL,
	[hinhAnh] [nvarchar](max) NULL,
	[luotXem] [int] NOT NULL,
	[soLuongKho] [int] NOT NULL,
	[moTa] [nvarchar](max) NULL,
	[idLoaiSP] [int] NOT NULL,
	[trangThai] [nvarchar](max) NULL,
	[ngayTao] [datetime2](7) NOT NULL,
	[ngayCapNhat] [datetime2](7) NOT NULL,
	[luotMua] [int] NOT NULL,
	[ThuongHieuidThuongHieu] [int] NULL,
	[UseridUser] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[idSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThuongHieu]    Script Date: 7/13/2022 2:15:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuongHieu](
	[idThuongHieu] [int] IDENTITY(1,1) NOT NULL,
	[tenThuongHieu] [nvarchar](100) NOT NULL,
	[hinhLogo] [nvarchar](max) NOT NULL,
	[sdtThuongHieu] [nvarchar](max) NULL,
	[emailThuongHieu] [nvarchar](200) NOT NULL,
	[trangThai] [nvarchar](max) NULL,
	[ngayTao] [datetime2](7) NOT NULL,
	[ngayCapNhat] [datetime2](7) NOT NULL,
	[idUser] [int] NOT NULL,
 CONSTRAINT [PK_ThuongHieu] PRIMARY KEY CLUSTERED 
(
	[idThuongHieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 7/13/2022 2:15:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[idUser] [int] IDENTITY(1,1) NOT NULL,
	[hoUser] [nvarchar](10) NOT NULL,
	[tenUser] [nvarchar](50) NOT NULL,
	[sdtUser] [nvarchar](10) NOT NULL,
	[emailUser] [nvarchar](200) NOT NULL,
	[matKhau] [nvarchar](max) NOT NULL,
	[gioiTinh] [int] NOT NULL,
	[ngaySinh] [datetime2](7) NOT NULL,
	[diaChi] [nvarchar](max) NULL,
	[hinhAVT] [nvarchar](max) NULL,
	[ngayTao] [datetime2](7) NOT NULL,
	[ngayCapNhat] [datetime2](7) NOT NULL,
	[hoatDongLanCuoi] [datetime2](7) NOT NULL,
	[trangThai] [nvarchar](max) NULL,
	[vaiTro] [nvarchar](max) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201223063036_dbinit', N'3.1.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201225075307_update', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201225160745_202012252300', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201225161529_202012252315', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201225191426_22012260214', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201230155453_2020123054', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210102195215_202101030252', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210104165207_202101042352', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210106095018_202101061650', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210106173825_202101070038', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210106181318_202101070113', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210106191402_202101070214', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210106201405_202101070313', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210107193044_202101080230', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210107195528_202101080255', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210109063506_202101081334', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210110060007_202101101259', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210110060211_202101101302', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210110093014_202101101629', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210110095821_202101101659', N'3.1.9')
GO
SET IDENTITY_INSERT [dbo].[Banner] ON 

INSERT [dbo].[Banner] ([idBanner], [hinhAnh], [ngayTao], [ngayBatDau], [ngayKetThuc], [url], [UseridUser]) VALUES (4, N'2022_07_12_06_37_32.jpg', CAST(N'2021-01-08T01:07:40.1690858' AS DateTime2), CAST(N'2022-01-01T01:07:00.0000000' AS DateTime2), CAST(N'2023-01-22T01:07:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Banner] ([idBanner], [hinhAnh], [ngayTao], [ngayBatDau], [ngayKetThuc], [url], [UseridUser]) VALUES (5, N'2022_07_12_06_43_37.jpg', CAST(N'2021-01-08T01:07:53.2068174' AS DateTime2), CAST(N'2022-01-01T01:07:00.0000000' AS DateTime2), CAST(N'2023-01-22T01:07:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Banner] ([idBanner], [hinhAnh], [ngayTao], [ngayBatDau], [ngayKetThuc], [url], [UseridUser]) VALUES (6, N'2022_07_12_06_38_16.jpg', CAST(N'2021-01-08T01:08:12.2154525' AS DateTime2), CAST(N'2022-01-01T01:08:00.0000000' AS DateTime2), CAST(N'2023-01-10T01:08:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Banner] ([idBanner], [hinhAnh], [ngayTao], [ngayBatDau], [ngayKetThuc], [url], [UseridUser]) VALUES (7, N'2022_07_12_06_38_35.jpg', CAST(N'2021-01-09T17:31:44.0305459' AS DateTime2), CAST(N'2022-01-01T17:31:00.0000000' AS DateTime2), CAST(N'2023-01-13T17:31:00.0000000' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Banner] OFF
GO
SET IDENTITY_INSERT [dbo].[DonHang] ON 

INSERT [dbo].[DonHang] ([idDH], [ngayDat], [ngayCapNhat], [hoDH], [tenDH], [diaChi], [eMail], [sdtDH], [ghiChu], [tongTienHang], [maGiamGiaDH], [tongSoTien], [trangThai], [idUser], [UseridUser], [MaGiamGiacodeMGG]) VALUES (1, CAST(N'2021-01-10T17:28:21.8833722' AS DateTime2), CAST(N'2021-01-10T17:28:21.8832781' AS DateTime2), N'd', N'd', N'd', N'vangiau.recca@gmail.com', N'd', N'dđ', 4095000, 0, 4095000, N'Đang xử lý', 0, NULL, NULL)
INSERT [dbo].[DonHang] ([idDH], [ngayDat], [ngayCapNhat], [hoDH], [tenDH], [diaChi], [eMail], [sdtDH], [ghiChu], [tongTienHang], [maGiamGiaDH], [tongSoTien], [trangThai], [idUser], [UseridUser], [MaGiamGiacodeMGG]) VALUES (2, CAST(N'2021-01-10T17:32:05.3329771' AS DateTime2), CAST(N'2021-01-10T17:32:05.3329121' AS DateTime2), N'Nguyễn Văn', N'Giàu', N'Bình Phan - Chợ Gạo - Tiền Giang - Việt Nam', N'vangiau.cityzens@gmail.com', N'0385642964', N'dđ', 2320000, 0, 2320000, N'Đang xử lý', 0, NULL, NULL)
INSERT [dbo].[DonHang] ([idDH], [ngayDat], [ngayCapNhat], [hoDH], [tenDH], [diaChi], [eMail], [sdtDH], [ghiChu], [tongTienHang], [maGiamGiaDH], [tongSoTien], [trangThai], [idUser], [UseridUser], [MaGiamGiacodeMGG]) VALUES (3, CAST(N'2021-01-10T17:33:58.5115519' AS DateTime2), CAST(N'2021-01-10T17:33:58.5114939' AS DateTime2), N'Nguyễn Văn', N'Giàu', N'Bình Phan - Chợ Gạo - Tiền Giang - Việt Nam', N'vangiau.cityzens@gmail.com', N'0385642964', N'dđ', 1450000, 0, 1450000, N'Đang xử lý', 0, NULL, NULL)
INSERT [dbo].[DonHang] ([idDH], [ngayDat], [ngayCapNhat], [hoDH], [tenDH], [diaChi], [eMail], [sdtDH], [ghiChu], [tongTienHang], [maGiamGiaDH], [tongSoTien], [trangThai], [idUser], [UseridUser], [MaGiamGiacodeMGG]) VALUES (5, CAST(N'2021-01-10T17:56:21.2283231' AS DateTime2), CAST(N'2021-01-10T17:56:21.2282639' AS DateTime2), N'Nguyễn Văn', N'Giàu', N'Bình Phan - Chợ Gạo - Tiền Giang - Việt Nam', N'vangiau.cityzens@gmail.com', N'0385642964', NULL, 585000, 0, 585000, N'Đang xử lý', 0, NULL, NULL)
INSERT [dbo].[DonHang] ([idDH], [ngayDat], [ngayCapNhat], [hoDH], [tenDH], [diaChi], [eMail], [sdtDH], [ghiChu], [tongTienHang], [maGiamGiaDH], [tongSoTien], [trangThai], [idUser], [UseridUser], [MaGiamGiacodeMGG]) VALUES (6, CAST(N'2021-01-10T18:07:08.6122653' AS DateTime2), CAST(N'2021-01-10T18:07:08.6122027' AS DateTime2), N'Nguyễn Văn', N'Giàu', N'Bình Phan - Chợ Gạo - Tiền Giang - Việt Nam', N'vangiau.cityzens@gmail.com', N'0385642964', NULL, 585000, 0, 585000, N'Đang xử lý', 0, NULL, NULL)
INSERT [dbo].[DonHang] ([idDH], [ngayDat], [ngayCapNhat], [hoDH], [tenDH], [diaChi], [eMail], [sdtDH], [ghiChu], [tongTienHang], [maGiamGiaDH], [tongSoTien], [trangThai], [idUser], [UseridUser], [MaGiamGiacodeMGG]) VALUES (8, CAST(N'2021-01-10T18:08:33.8562791' AS DateTime2), CAST(N'2021-01-10T18:08:33.8562147' AS DateTime2), N'Nguyễn Văn', N'Giàu', N'Bình Phan - Chợ Gạo - Tiền Giang - Việt Nam', N'vangiau.cityzens@gmail.com', N'0385642964', NULL, 585000, 0, 585000, N'Đang xử lý', 0, NULL, NULL)
INSERT [dbo].[DonHang] ([idDH], [ngayDat], [ngayCapNhat], [hoDH], [tenDH], [diaChi], [eMail], [sdtDH], [ghiChu], [tongTienHang], [maGiamGiaDH], [tongSoTien], [trangThai], [idUser], [UseridUser], [MaGiamGiacodeMGG]) VALUES (9, CAST(N'2021-01-10T18:08:38.6244402' AS DateTime2), CAST(N'2021-01-10T18:08:38.6244399' AS DateTime2), N'Nguyễn Văn', N'Giàu', N'Bình Phan - Chợ Gạo - Tiền Giang - Việt Nam', N'vangiau.cityzens@gmail.com', N'0385642964', NULL, 585000, 0, 585000, N'Đang xử lý', 0, NULL, NULL)
SET IDENTITY_INSERT [dbo].[DonHang] OFF
GO
SET IDENTITY_INSERT [dbo].[IPuser] ON 

INSERT [dbo].[IPuser] ([idIPuser], [idUser], [diachiip]) VALUES (1021, 1024, N'5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Safari/537.36')
INSERT [dbo].[IPuser] ([idIPuser], [idUser], [diachiip]) VALUES (2021, 2025, N'5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Safari/537.36')
SET IDENTITY_INSERT [dbo].[IPuser] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiSP] ON 

INSERT [dbo].[LoaiSP] ([idLoaiSP], [tenLoaiSP], [hinhAnh], [metaTitle], [trangThai], [ngayTao], [ngayCapNhat], [idUser], [typeLoai]) VALUES (1026, N'Áo thun nam', N'2022_07_12_06_51_27.jpg', N'Áo thun nam', N'Hiển thị', CAST(N'2022-07-12T06:49:00.3313487' AS DateTime2), CAST(N'2022-07-12T08:04:21.8114862' AS DateTime2), 1024, N'0')
INSERT [dbo].[LoaiSP] ([idLoaiSP], [tenLoaiSP], [hinhAnh], [metaTitle], [trangThai], [ngayTao], [ngayCapNhat], [idUser], [typeLoai]) VALUES (1027, N'Áo sơ mi nam', N'2022_07_12_06_54_02.jpg', N'Áo sơ mi nam', N'Hiển thị', CAST(N'2022-07-12T06:54:02.8610704' AS DateTime2), CAST(N'2022-07-12T09:12:32.4514026' AS DateTime2), 1024, N'0')
INSERT [dbo].[LoaiSP] ([idLoaiSP], [tenLoaiSP], [hinhAnh], [metaTitle], [trangThai], [ngayTao], [ngayCapNhat], [idUser], [typeLoai]) VALUES (1028, N'Áo khoác nam', N'2022_07_12_06_55_17.jpg', N'Áo khoác nam', N'Hiển thị', CAST(N'2022-07-12T06:55:17.5538831' AS DateTime2), CAST(N'2022-07-12T09:12:26.8483683' AS DateTime2), 1024, N'0')
INSERT [dbo].[LoaiSP] ([idLoaiSP], [tenLoaiSP], [hinhAnh], [metaTitle], [trangThai], [ngayTao], [ngayCapNhat], [idUser], [typeLoai]) VALUES (1029, N'Quần Jean nam', N'2022_07_12_06_56_32.jpg', N'Quần Jean nam', N'Hiển thị', CAST(N'2022-07-12T06:56:32.9648481' AS DateTime2), CAST(N'2022-07-12T11:53:19.7861049' AS DateTime2), 1024, N'0')
INSERT [dbo].[LoaiSP] ([idLoaiSP], [tenLoaiSP], [hinhAnh], [metaTitle], [trangThai], [ngayTao], [ngayCapNhat], [idUser], [typeLoai]) VALUES (1031, N'Áo thun nữ', N'2022_07_12_07_05_19.jpg', N'Áo thun nữ', N'Hiển thị', CAST(N'2022-07-12T07:05:19.4704089' AS DateTime2), CAST(N'2022-07-12T09:08:22.7856822' AS DateTime2), 1024, N'1')
INSERT [dbo].[LoaiSP] ([idLoaiSP], [tenLoaiSP], [hinhAnh], [metaTitle], [trangThai], [ngayTao], [ngayCapNhat], [idUser], [typeLoai]) VALUES (1032, N'Áo sơ mi nữ', N'2022_07_12_07_07_00.jpg', N'Áo sơ mi nữ', N'Hiển thị', CAST(N'2022-07-12T07:07:00.1477686' AS DateTime2), CAST(N'2022-07-12T09:12:16.6079510' AS DateTime2), 1024, N'1')
INSERT [dbo].[LoaiSP] ([idLoaiSP], [tenLoaiSP], [hinhAnh], [metaTitle], [trangThai], [ngayTao], [ngayCapNhat], [idUser], [typeLoai]) VALUES (1033, N'Chân váy', N'2022_07_12_07_07_45.jpg', N'Chân váy', N'Hiển thị', CAST(N'2022-07-12T07:07:45.6890010' AS DateTime2), CAST(N'2022-07-12T07:07:45.6890043' AS DateTime2), 1024, N'1')
INSERT [dbo].[LoaiSP] ([idLoaiSP], [tenLoaiSP], [hinhAnh], [metaTitle], [trangThai], [ngayTao], [ngayCapNhat], [idUser], [typeLoai]) VALUES (1034, N'Áo khoác nữ', N'2022_07_12_07_09_01.jpg', N'Áo khoác nữ', N'Hiển thị', CAST(N'2022-07-12T07:09:01.5183835' AS DateTime2), CAST(N'2022-07-12T12:11:42.1703557' AS DateTime2), 1024, N'1')
SET IDENTITY_INSERT [dbo].[LoaiSP] OFF
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (19, N'Áo Thun Cổ Tròn Valknut Ver3', 225000, N'2022_07_12_08_04_06.jpg', 3, 100, N'Áo Thun Cổ Tròn Đơn Giản Thần Cổ Đại Valknut Ver3 Chất liệu: Cotton Compact Thành phần: 100% Cotton - Thân thiện - Thấm hút thoát ẩm - Mềm mại - Kiểm soát mùi - Điều hòa nhiệt + Họa tiết in dẻo + in nhũ + Thêu 3D + zigzag - HDSD: + Nên giặt chung với sản phẩm cùng màu + Không dùng thuốc tẩy hoặc xà phòng có tính tẩy mạnh + Nên phơi trong bóng râm để giữ sp bền màu', 1026, N'Hiển thị', CAST(N'2022-07-12T08:04:06.6988423' AS DateTime2), CAST(N'2022-07-12T08:10:06.7992608' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (20, N'Áo Thun Cổ Tròn Tối Giản', 227000, N'2022_07_12_08_06_58.jpg', 0, 100, N'Áo Thun Cổ Tròn Tối Giản M13 Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton - Thân thiện - Thấm hút thoát ẩm - Mềm mại - Kiểm soát mùi - Điều hòa nhiệt + Họa tiết thêu 2D - HDSD: + Nên giặt chung với sản phẩm cùng màu + Không dùng thuốc tẩy hoặc xà phòng có tính tẩy mạnh + Nên phơi trong bóng râm để giữ sp bền màu', 1026, N'Hiển thị', CAST(N'2022-07-12T08:06:58.1193918' AS DateTime2), CAST(N'2022-07-12T08:10:53.8167349' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (21, N'Áo Thun Cổ Trụ Tối Giản J01', 150000, N'2022_07_12_08_09_34.jpg', 0, 100, N'Chất liệu: Cotton 4 Chiều Thành phần: 95% cotton 5% Spandex - Co giãn tốt - Độ bền cao', 1026, N'Hiển thị', CAST(N'2022-07-12T08:09:34.7903976' AS DateTime2), CAST(N'2022-07-12T08:09:34.7904089' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (22, N'Áo Thun Cổ Tròn Space Ver14', 199000, N'2022_07_12_08_13_07.jpg', 0, 100, N'Áo Thun Cổ Tròn Đơn Giản Ngân Hà Space Ver14 Chất liệu: Cotton Compact Thành phần: 100% Cotton - Thân thiện - Thấm hút thoát ẩm - Mềm mại - Kiểm soát mùi - Điều hòa nhiệt + Họa tiết thêu - HDSD: + Nên giặt chung với sản phẩm cùng màu + Không dùng thuốc tẩy hoặc xà phòng có tính tẩy mạnh + Nên phơi trong bóng râm để giữ sp bền màu', 1026, N'Hiển thị', CAST(N'2022-07-12T08:13:07.6451882' AS DateTime2), CAST(N'2022-07-12T08:13:07.6451930' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (23, N'Áo Thun Đơn Giản Ver58', 99000, N'2022_07_12_08_15_10.jpg', 0, 100, N'Áo Thun Cổ Tròn Đơn Giản Y Nguyên Bản Ver58 Chất liệu: Cotton Compact 2C Thành phần: 100% Cotton - Thân thiện - Thấm hút thoát ẩm - Mềm mại - Kiểm soát mùi - Điều hòa nhiệt + Họa tiết in bột nổi - HDSD: + Nên giặt chung với sản phẩm cùng màu + Không dùng thuốc tẩy hoặc xà phòng có tính tẩy mạnh + Nên phơi trong bóng râm để giữ sp bền màu', 1026, N'Hiển thị', CAST(N'2022-07-12T08:15:10.8421327' AS DateTime2), CAST(N'2022-07-12T08:15:10.8421379' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (24, N'Áo Thun Cổ Tròn M30', 199000, N'2022_07_12_08_17_33.jpg', 0, 100, N'Áo Thun Cổ Tròn Đơn Giản M30 Chất liệu: Cotton 4 chiều Thành phần: 92% cotton 8% spandex - Thân thiện - Thấm hút thoát ẩm - Mềm mại, ít nhăn - Co giãn tối ưu - Kiểm soát mùi - Điều hòa nhiệt + Họa tiết Thêu xù , May đắp TPR - HDSD: + Nên giặt chung với sản phẩm cùng màu + Không dùng thuốc tẩy hoặc xà phòng có tính tẩy mạnh + Nên phơi trong bóng râm để giữ sp bền màu', 1026, N'Hiển thị', CAST(N'2022-07-12T08:17:33.7038872' AS DateTime2), CAST(N'2022-07-12T08:17:33.7038920' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (25, N'Áo Thun Sweater Ver36', 225000, N'2022_07_12_08_19_30.jpg', 1, 100, N'Áo Thun Sweater Đơn Giản Y Nguyên Bản Ver36 - Chất liệu: French Terry - Thành phần: 100% Cotton - Thấm hút thoát ẩm - Mềm mại, ít nhăn - Co giãn tối ưu - Thân thiện môi trường + Cổ áo, cổ tay, lai áo được bo vải gân + Họa tiết in dẻo + thêu đắp giống', 1026, N'Hiển thị', CAST(N'2022-07-12T08:19:30.8017442' AS DateTime2), CAST(N'2022-07-12T08:19:30.8017547' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (26, N'Áo Thun Tay Dài Đơn Giản K01', 150000, N'2022_07_12_08_22_25.jpg', 0, 100, N'Chất liệu: Cotton 4 Chiều Thành phần: 95%cotton 5%spandex - Co dãn 4 chiều nên tạo được sự thoải mái khi mặc - Vải thấm hút mồ hôi tốt, thoáng khí', 1026, N'Hiển thị', CAST(N'2022-07-12T08:22:25.1726970' AS DateTime2), CAST(N'2022-07-12T08:46:23.2105231' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (27, N'Áo thun nữ GENVIET JEANS', 250000, N'2022_07_12_09_08_12.jpg', 0, 100, N'Sản phẩm được sản xuất bởi GENVIET', 1031, N'Hiển thị', CAST(N'2022-07-12T09:08:12.5555519' AS DateTime2), CAST(N'2022-07-12T09:08:12.5555562' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (28, N'Áo Polo Nữ Hàn Quốc Ver2', 185000, N'2022_07_12_11_32_46.jpg', 0, 100, N'Tự tin chống nắng suốt ngày dài, nàng diện ngay áo chống nắng 2 lớp thương hiệu Cardina. Công nghệ làm mát tức thì chắc chắn sẽ khiến mọi cô nàng mê mẩn.', 1031, N'Hiển thị', CAST(N'2022-07-12T11:32:46.5447991' AS DateTime2), CAST(N'2022-07-12T11:32:46.5449332' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (29, N'TC305T2206 - Áo Thun Nữ Cộc Tay Oversize', 135000, N'2022_07_12_11_37_04.jpg', 0, 100, N'Màu sắc: WHI1. Chât liệu Cotton thoáng khí', 1031, N'Hiển thị', CAST(N'2022-07-12T11:37:04.7257084' AS DateTime2), CAST(N'2022-07-12T11:37:04.7257172' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (30, N'Áo Thun Giữ Nhiệt Dài Tay', 199000, N'2022_07_12_11_38_53.jpg', 0, 100, N'Chất liệu: Thun lạnh Aircool Nhật Bản UPF50+ ngăn 97% tia UV Thương hiệu: Cardina Màu sắc: 13 phiên bản màu sắc cho nàng chọn lựa. Size: Đủ size cho nàng từ S đến XXL, 40kg đến 75kg', 1031, N'Hiển thị', CAST(N'2022-07-12T11:38:53.9365267' AS DateTime2), CAST(N'2022-07-12T11:38:53.9365379' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (31, N'Sơ Mi Tay Dài Tối Giản M11', 220000, N'2022_07_12_11_43_41.jpg', 0, 100, N'Chất liệu: Kate Thành phần: 12% modal và 88% superfine - Ít nhăn và dễ ủi - Nhanh khô và thoáng mát HDSD: - Áo sơ mi màu phơi trong bóng râm để tránh bạc màu phần vai áo - Áo sơ mi trắng có thể phơi ngoài nắng để áo trắng sáng hơn ( không phơi quá lâu )', 1027, N'Hiển thị', CAST(N'2022-07-12T11:43:41.3809608' AS DateTime2), CAST(N'2022-07-12T11:43:41.3809711' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (32, N'Sơ Mi Tay Ngắn Đơn Giản M27', 165000, N'2022_07_12_11_44_25.jpg', 0, 100, N'Sơ Mi Tay Ngắn Đơn Giản M27 Chất liệu : vải Kate Thành phần : 65% cotton 35% poly - Độ bền cao - Mềm mại - Nhanh khô - Thoáng mát + Họa tiết in dẻo, thêu x2D', 1027, N'Hiển thị', CAST(N'2022-07-12T11:44:25.0207583' AS DateTime2), CAST(N'2022-07-12T11:44:25.0207706' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (33, N'Sơ Mi Tay Dài Tối Giản N01', 285000, N'2022_07_12_11_45_19.jpg', 0, 100, N'Chất liệu: Vải cafe (Công nghệ sợi làm từ bã cafe) Thành phần: 50% cafe 50% Poly + Odor Control - Kiểm soát mùi + Fast Drying - Nhanh khô + Ice Cool Touch - Làm mát cơ thể + UV Protechtion - Chống nắng', 1027, N'Hiển thị', CAST(N'2022-07-12T11:45:19.2520853' AS DateTime2), CAST(N'2022-07-12T11:45:19.2520980' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (34, N'Sơ Mi Cổ Lãnh Tụ Đơn Giản Y Nguyên Bản Ver14 Chất liệu: Sơ Mi Cotton Thành phần: 100% cotton - May đ', 199000, N'2022_07_12_11_45_58.jpg', 0, 100, N'Sơ Mi Cổ Lãnh Tụ Đơn Giản Y Nguyên Bản Ver14 Chất liệu: Sơ Mi Cotton Thành phần: 100% cotton - May đắp logo', 1027, N'Hiển thị', CAST(N'2022-07-12T11:45:58.4939345' AS DateTime2), CAST(N'2022-07-12T11:45:58.4939622' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (35, N'Sơ Mi Cổ Lãnh Tụ Tối Giản M31', 225000, N'2022_07_12_11_46_47.jpg', 0, 100, N'Chất liệu : TY Ford Thành Phần :100% cotton - Thân thiện - Thấm hút thoát ẩm - Mềm mại', 1027, N'Hiển thị', CAST(N'2022-07-12T11:46:47.4624113' AS DateTime2), CAST(N'2022-07-12T11:46:47.4624281' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (36, N'Áo Khoác Lá Cổ Đơn Giản M17', 300000, N'2022_07_12_11_47_54.jpg', 0, 100, N'Chất liệu : Kaki Thành phần: 100% Cotton - Họa tiết thêu + may đắp logo', 1028, N'Hiển thị', CAST(N'2022-07-12T11:47:54.7102247' AS DateTime2), CAST(N'2022-07-12T11:47:54.7102344' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (37, N'Áo Khoác Classic Tối Giản Ver6', 299000, N'2022_07_12_11_48_31.jpg', 0, 100, N'Bản Ver6 Chất liệu: Vải Dù Thành phần: 100% poly - Chống tia UV - Cản gió - Nhanh khô - Bền màu tốt -Trượt nước + Túi trong tiện dụng + Reverse Coil Zipper (Những chiếc khoá túi này có bề mặt ngoài dẹp, phẳng trong khi răng khoá thì ở trong) - Tặng kèm túi đựng áo khoác', 1028, N'Hiển thị', CAST(N'2022-07-12T11:48:31.2825453' AS DateTime2), CAST(N'2022-07-12T11:48:31.2825531' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (38, N'Áo Khoác Cardigan Đơn Giản Y Nguyên Bản Ver46', 350000, N'2022_07_12_11_49_36.jpg', 0, 100, N'Chất liệu: COTTON DOUBLE FACE - Vải sợi Cotton được dệt theo "DOUBLE-FACE" có cấu trúc 2 bề mặt giống nhau, có thể sử dụng được cả 2 mặt vải . Thành phần: 87% Cotton 13% Polyester - Co giãn - Độ bền cao - Thoáng Khí - Nhanh khô - Thấm hút + Họa tiết thêu + thêu đắp giống simily + Miếng dán chống cộm hình thêu', 1028, N'Hiển thị', CAST(N'2022-07-12T11:49:16.1569153' AS DateTime2), CAST(N'2022-07-12T11:51:37.1480516' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (39, N' Áo Khoác Classic Tối Giản M3 Áo Khoác Classic Tối Giản M3 Áo Khoác Classic Tối Giản M3', 320000, N'2022_07_12_11_50_59.jpg', 0, 100, N'Chất liệu: Vảy cá CVC Thành phần: 60% cotton 40% poly - Mềm mại - Thoải mái và bền + Reverse Coil Zipper (Những chiếc khoá túi này có bề mặt ngoài dẹp, phẳng trong khi răng khoá thì ở trong) + Bo tay xỏ ngón đa dụng + Hai túi phía trước có dây kéo (để đựng vật dụng mang theo như: điện thoại, tai nghe,… ko bị rơi mất)', 1028, N'Hiển thị', CAST(N'2022-07-12T11:50:59.5815475' AS DateTime2), CAST(N'2022-07-12T11:50:59.5815525' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (40, N'Quần Jean Slimfit Tối Giản M7', 375000, N'2022_07_12_11_53_09.jpg', 0, 100, N'Chất liệu: Jean Cotton Thành phần: 100% cotton - Độ bền cao - Thoáng mát - Thoải mái + Kẹp logo #y2010 túi trước', 1029, N'Hiển thị', CAST(N'2022-07-12T11:53:09.0821975' AS DateTime2), CAST(N'2022-07-12T11:53:09.0822021' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (41, N'Áo Sơ Mi Nữ Thô Cộc Tay Túi Hộp', 150000, N'2022_07_12_11_56_01.jpg', 0, 100, N'Màu sắc: CAM1', 1032, N'Hiển thị', CAST(N'2022-07-12T11:56:01.4861391' AS DateTime2), CAST(N'2022-07-12T11:56:01.4861434' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (42, N'Áo Sơ Mi Kẻ Sọc Caro', 180000, N'2022_07_12_11_57_16.jpg', 0, 100, N'Màu sắc: KCA1', 1032, N'Hiển thị', CAST(N'2022-07-12T11:57:16.2454599' AS DateTime2), CAST(N'2022-07-12T11:57:16.2455699' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (43, N'Áo Sơmi Jean Cộc Tay Gia Đình', 220000, N'2022_07_12_11_58_18.jpg', 0, 100, N'Màu sắc: XCH1', 1032, N'Hiển thị', CAST(N'2022-07-12T11:58:18.0373299' AS DateTime2), CAST(N'2022-07-12T11:58:18.0373344' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (44, N'Áo Sơmi Jeans Cộc Tay Cổ Vuông Nhún Tay Bèo', 130000, N'2022_07_12_11_59_51.jpg', 0, 100, N'Màu sắc: XCH3', 1032, N'Hiển thị', CAST(N'2022-07-12T11:59:51.5880012' AS DateTime2), CAST(N'2022-07-12T11:59:51.5880057' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (45, N'Chân Váy Jeans Nữ', 180000, N'2022_07_12_12_01_42.jpg', 0, 100, N'Màu sắc: XCH2', 1033, N'Hiển thị', CAST(N'2022-07-12T12:01:42.9899234' AS DateTime2), CAST(N'2022-07-12T12:01:42.9899432' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (46, N'Chân Váy Jeans Nữ Ver3', 199000, N'2022_07_12_12_02_33.jpg', 0, 100, N'Màu sắc: XCH2', 1033, N'Hiển thị', CAST(N'2022-07-12T12:02:33.0783885' AS DateTime2), CAST(N'2022-07-12T12:02:33.0784001' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (47, N'Chân Váy Denim Dáng A Phối Khoá', 270000, N'2022_07_12_12_04_28.jpg', 0, 100, N'Màu sắc: Xanh chàm', 1033, N'Hiển thị', CAST(N'2022-07-12T12:04:28.9090846' AS DateTime2), CAST(N'2022-07-12T12:04:28.9090897' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (48, N'Chân Váy Jeans Nữ Gấu Cách Điệu', 210000, N'2022_07_12_12_05_39.jpg', 0, 100, N'Màu sắc: XCN1', 1033, N'Hiển thị', CAST(N'2022-07-12T12:05:39.4803073' AS DateTime2), CAST(N'2022-07-12T12:05:39.4803119' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (49, N'Quần Jean Slimfit Đơn Giản B35', 35000, N'2022_07_12_12_06_49.jpg', 0, 100, N'Chất liệu: Jean Cotton Thành phần: 98% cotton 2% spandex - Độ bền cao - Mặc mát, rất thoải mái.', 1026, N'Hiển thị', CAST(N'2022-07-12T12:06:49.1971783' AS DateTime2), CAST(N'2022-07-12T12:14:32.8780661' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (50, N'Quần Jean Slimfit Đơn Giản B42', 399000, N'2022_07_12_12_07_31.jpg', 0, 100, N'Chất liệu: Jean Cotton Thành phần: 99% cotton 1% spandex - Độ bền cao - Mang đến sự thoải mái ở phần hông và đùi nhưng vẫn rất gọn gàng HDSD: - Hãy lộn mặt trái của sản phẩm trước khi giặt để hạn chế bay màu vải. - Không nên sử dụng các chất tẩy rửa mạnh trong quá trình giặt.', 1029, N'Hiển thị', CAST(N'2022-07-12T12:07:31.9085069' AS DateTime2), CAST(N'2022-07-12T12:07:31.9085115' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (51, N'Quần Jean Slimfit Đơn Giản B19', 285000, N'2022_07_12_12_08_26.jpg', 0, 100, N'Chất liệu: Jean Cotton Thành phần: 98% cotton 2% spandex - Độ bền cao - Mặc mát, rất thoải mái.', 1029, N'Hiển thị', CAST(N'2022-07-12T12:08:26.4801638' AS DateTime2), CAST(N'2022-07-12T12:08:26.4801688' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (52, N'Quần Jean Slimfit Đặc Biệt M3', 290000, N'2022_07_12_12_09_55.jpg', 0, 100, N'Chất liệu: Jean Cotton Thành phần: 99% cotton 1% spandex - Mềm mại - Thoáng mát - Thấm hút HDSD: - Hãy lộn mặt trái của sản phẩm trước khi giặt để hạn chế bay màu vải. - Không nên sử dụng các chất tẩy rửa mạnh trong quá trình giặt.', 1029, N'Hiển thị', CAST(N'2022-07-12T12:09:55.3518174' AS DateTime2), CAST(N'2022-07-12T12:09:55.3518224' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (53, N'Áo Khoác Nhung Nữ', 200000, N'2022_07_12_12_14_05.jpg', 0, 100, N'Màu sắc: WGA2', 1034, N'Hiển thị', CAST(N'2022-07-12T12:11:33.3204854' AS DateTime2), CAST(N'2022-07-12T12:14:23.7885046' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (54, N'Áo Khoác Nữ Crop Top Oversize', 399000, N'2022_07_12_12_12_38.jpg', 0, 100, N'Màu sắc: WGA2', 1034, N'Hiển thị', CAST(N'2022-07-12T12:12:38.4263373' AS DateTime2), CAST(N'2022-07-12T12:12:38.4263425' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (55, N'Áo Khoác Một Lớp Jeans Nữ Túi Hộp', 199000, N'2022_07_12_12_13_46.jpg', 0, 100, N'Màu sắc: XCN2', 1034, N'Hiển thị', CAST(N'2022-07-12T12:13:46.0869906' AS DateTime2), CAST(N'2022-07-12T12:13:46.0869961' AS DateTime2), 0, NULL, NULL)
INSERT [dbo].[SanPham] ([idSP], [tenSP], [giaSP], [hinhAnh], [luotXem], [soLuongKho], [moTa], [idLoaiSP], [trangThai], [ngayTao], [ngayCapNhat], [luotMua], [ThuongHieuidThuongHieu], [UseridUser]) VALUES (56, N'Áo Khoác Jeans Nữ 1 Lớp', 299000, N'2022_07_12_12_15_56.jpg', 0, 100, N'Sản phẩm được sản xuất bởi GENVIET', 1034, N'Hiển thị', CAST(N'2022-07-12T12:15:56.3886032' AS DateTime2), CAST(N'2022-07-12T12:15:56.3886074' AS DateTime2), 0, NULL, NULL)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
SET IDENTITY_INSERT [dbo].[ThuongHieu] ON 

INSERT [dbo].[ThuongHieu] ([idThuongHieu], [tenThuongHieu], [hinhLogo], [sdtThuongHieu], [emailThuongHieu], [trangThai], [ngayTao], [ngayCapNhat], [idUser]) VALUES (1002, N'GUCCI', N'2022_07_12_12_28_06.jpg', N'0994552349', N'gucci.fashion@gmail.com', NULL, CAST(N'2022-07-12T12:28:06.8029457' AS DateTime2), CAST(N'2022-07-12T12:28:06.8031032' AS DateTime2), 1024)
SET IDENTITY_INSERT [dbo].[ThuongHieu] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([idUser], [hoUser], [tenUser], [sdtUser], [emailUser], [matKhau], [gioiTinh], [ngaySinh], [diaChi], [hinhAVT], [ngayTao], [ngayCapNhat], [hoatDongLanCuoi], [trangThai], [vaiTro]) VALUES (1024, N'Nguyễn Văn', N'Giàu', N'0385642964', N'vangiau.recca@gmail.com', N'21232f297a57a5a743894a0e4a801fc3', 1, CAST(N'2001-04-06T00:00:00.0000000' AS DateTime2), N'Chợ Gạo, Tiền Giang', N'2022_07_12_12_25_12.jpg', CAST(N'2022-07-10T17:58:32.0055324' AS DateTime2), CAST(N'2022-07-12T12:25:12.6450717' AS DateTime2), CAST(N'2022-07-12T14:17:32.9046271' AS DateTime2), N'Đang hoạt động', N'admin')
INSERT [dbo].[User] ([idUser], [hoUser], [tenUser], [sdtUser], [emailUser], [matKhau], [gioiTinh], [ngaySinh], [diaChi], [hinhAVT], [ngayTao], [ngayCapNhat], [hoatDongLanCuoi], [trangThai], [vaiTro]) VALUES (2025, N'Hồ Văn', N'Tý', N'0343479496', N'vangiau.mc@gmail.com', N'202cb962ac59075b964b07152d234b70', 1, CAST(N'1953-11-30T00:00:00.0000000' AS DateTime2), N'Bình Phan, Chợ Gạo, Tiền Giang', N'def.jpg', CAST(N'2022-07-12T13:41:47.8687830' AS DateTime2), CAST(N'2022-07-12T13:41:47.8688751' AS DateTime2), CAST(N'2022-07-12T14:19:52.3979782' AS DateTime2), N'Đang hoạt động', N'users')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
/****** Object:  Index [IX_Banner_UseridUser]    Script Date: 7/13/2022 2:15:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_Banner_UseridUser] ON [dbo].[Banner]
(
	[UseridUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ChinhSachGiaoHang_UseridUser]    Script Date: 7/13/2022 2:15:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_ChinhSachGiaoHang_UseridUser] ON [dbo].[ChinhSachGiaoHang]
(
	[UseridUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ChiTietDonHang_idDH]    Script Date: 7/13/2022 2:15:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_ChiTietDonHang_idDH] ON [dbo].[ChiTietDonHang]
(
	[idDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DieuKhoanDichVu_UseridUser]    Script Date: 7/13/2022 2:15:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_DieuKhoanDichVu_UseridUser] ON [dbo].[DieuKhoanDichVu]
(
	[UseridUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DonHang_MaGiamGiacodeMGG]    Script Date: 7/13/2022 2:15:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_DonHang_MaGiamGiacodeMGG] ON [dbo].[DonHang]
(
	[MaGiamGiacodeMGG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DonHang_UseridUser]    Script Date: 7/13/2022 2:15:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_DonHang_UseridUser] ON [dbo].[DonHang]
(
	[UseridUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_GioHang_idUser]    Script Date: 7/13/2022 2:15:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_GioHang_idUser] ON [dbo].[GioHang]
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_GioHang_SanPhamidSP]    Script Date: 7/13/2022 2:15:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_GioHang_SanPhamidSP] ON [dbo].[GioHang]
(
	[SanPhamidSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_GioiThieu_UseridUser]    Script Date: 7/13/2022 2:15:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_GioiThieu_UseridUser] ON [dbo].[GioiThieu]
(
	[UseridUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_IPuser_idUser]    Script Date: 7/13/2022 2:15:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_IPuser_idUser] ON [dbo].[IPuser]
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_LoaiSP_idUser]    Script Date: 7/13/2022 2:15:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_LoaiSP_idUser] ON [dbo].[LoaiSP]
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaGiamGia_UseridUser]    Script Date: 7/13/2022 2:15:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_MaGiamGia_UseridUser] ON [dbo].[MaGiamGia]
(
	[UseridUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_QuyDinhChung_UseridUser]    Script Date: 7/13/2022 2:15:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_QuyDinhChung_UseridUser] ON [dbo].[QuyDinhChung]
(
	[UseridUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SanPham_idLoaiSP]    Script Date: 7/13/2022 2:15:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_SanPham_idLoaiSP] ON [dbo].[SanPham]
(
	[idLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SanPham_ThuongHieuidThuongHieu]    Script Date: 7/13/2022 2:15:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_SanPham_ThuongHieuidThuongHieu] ON [dbo].[SanPham]
(
	[ThuongHieuidThuongHieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SanPham_UseridUser]    Script Date: 7/13/2022 2:15:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_SanPham_UseridUser] ON [dbo].[SanPham]
(
	[UseridUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ThuongHieu_idUser]    Script Date: 7/13/2022 2:15:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_ThuongHieu_idUser] ON [dbo].[ThuongHieu]
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietDonHang] ADD  DEFAULT ((0)) FOR [thanhTien]
GO
ALTER TABLE [dbo].[GioHang] ADD  DEFAULT ((0)) FOR [giasp]
GO
ALTER TABLE [dbo].[GioHang] ADD  DEFAULT ((0)) FOR [tensp]
GO
ALTER TABLE [dbo].[GioHang] ADD  DEFAULT ((0)) FOR [idsp]
GO
ALTER TABLE [dbo].[SanPham] ADD  DEFAULT ((0)) FOR [luotMua]
GO
ALTER TABLE [dbo].[Banner]  WITH CHECK ADD  CONSTRAINT [FK_Banner_User_UseridUser] FOREIGN KEY([UseridUser])
REFERENCES [dbo].[User] ([idUser])
GO
ALTER TABLE [dbo].[Banner] CHECK CONSTRAINT [FK_Banner_User_UseridUser]
GO
ALTER TABLE [dbo].[ChinhSachGiaoHang]  WITH CHECK ADD  CONSTRAINT [FK_ChinhSachGiaoHang_User_UseridUser] FOREIGN KEY([UseridUser])
REFERENCES [dbo].[User] ([idUser])
GO
ALTER TABLE [dbo].[ChinhSachGiaoHang] CHECK CONSTRAINT [FK_ChinhSachGiaoHang_User_UseridUser]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_DonHang_idDH] FOREIGN KEY([idDH])
REFERENCES [dbo].[DonHang] ([idDH])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_DonHang_idDH]
GO
ALTER TABLE [dbo].[DieuKhoanDichVu]  WITH CHECK ADD  CONSTRAINT [FK_DieuKhoanDichVu_User_UseridUser] FOREIGN KEY([UseridUser])
REFERENCES [dbo].[User] ([idUser])
GO
ALTER TABLE [dbo].[DieuKhoanDichVu] CHECK CONSTRAINT [FK_DieuKhoanDichVu_User_UseridUser]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_MaGiamGia_MaGiamGiacodeMGG] FOREIGN KEY([MaGiamGiacodeMGG])
REFERENCES [dbo].[MaGiamGia] ([codeMGG])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_MaGiamGia_MaGiamGiacodeMGG]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_User_UseridUser] FOREIGN KEY([UseridUser])
REFERENCES [dbo].[User] ([idUser])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_User_UseridUser]
GO
ALTER TABLE [dbo].[GioHang]  WITH CHECK ADD  CONSTRAINT [FK_GioHang_SanPham_SanPhamidSP] FOREIGN KEY([SanPhamidSP])
REFERENCES [dbo].[SanPham] ([idSP])
GO
ALTER TABLE [dbo].[GioHang] CHECK CONSTRAINT [FK_GioHang_SanPham_SanPhamidSP]
GO
ALTER TABLE [dbo].[GioHang]  WITH CHECK ADD  CONSTRAINT [FK_GioHang_User_idUser] FOREIGN KEY([idUser])
REFERENCES [dbo].[User] ([idUser])
GO
ALTER TABLE [dbo].[GioHang] CHECK CONSTRAINT [FK_GioHang_User_idUser]
GO
ALTER TABLE [dbo].[GioiThieu]  WITH CHECK ADD  CONSTRAINT [FK_GioiThieu_User_UseridUser] FOREIGN KEY([UseridUser])
REFERENCES [dbo].[User] ([idUser])
GO
ALTER TABLE [dbo].[GioiThieu] CHECK CONSTRAINT [FK_GioiThieu_User_UseridUser]
GO
ALTER TABLE [dbo].[IPuser]  WITH CHECK ADD  CONSTRAINT [FK_IPuser_User_idUser] FOREIGN KEY([idUser])
REFERENCES [dbo].[User] ([idUser])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[IPuser] CHECK CONSTRAINT [FK_IPuser_User_idUser]
GO
ALTER TABLE [dbo].[LoaiSP]  WITH CHECK ADD  CONSTRAINT [FK_LoaiSP_User_idUser] FOREIGN KEY([idUser])
REFERENCES [dbo].[User] ([idUser])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LoaiSP] CHECK CONSTRAINT [FK_LoaiSP_User_idUser]
GO
ALTER TABLE [dbo].[MaGiamGia]  WITH CHECK ADD  CONSTRAINT [FK_MaGiamGia_User_UseridUser] FOREIGN KEY([UseridUser])
REFERENCES [dbo].[User] ([idUser])
GO
ALTER TABLE [dbo].[MaGiamGia] CHECK CONSTRAINT [FK_MaGiamGia_User_UseridUser]
GO
ALTER TABLE [dbo].[QuyDinhChung]  WITH CHECK ADD  CONSTRAINT [FK_QuyDinhChung_User_UseridUser] FOREIGN KEY([UseridUser])
REFERENCES [dbo].[User] ([idUser])
GO
ALTER TABLE [dbo].[QuyDinhChung] CHECK CONSTRAINT [FK_QuyDinhChung_User_UseridUser]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSP_idLoaiSP] FOREIGN KEY([idLoaiSP])
REFERENCES [dbo].[LoaiSP] ([idLoaiSP])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSP_idLoaiSP]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_ThuongHieu_ThuongHieuidThuongHieu] FOREIGN KEY([ThuongHieuidThuongHieu])
REFERENCES [dbo].[ThuongHieu] ([idThuongHieu])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_ThuongHieu_ThuongHieuidThuongHieu]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_User_UseridUser] FOREIGN KEY([UseridUser])
REFERENCES [dbo].[User] ([idUser])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_User_UseridUser]
GO
ALTER TABLE [dbo].[ThuongHieu]  WITH CHECK ADD  CONSTRAINT [FK_ThuongHieu_User_idUser] FOREIGN KEY([idUser])
REFERENCES [dbo].[User] ([idUser])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ThuongHieu] CHECK CONSTRAINT [FK_ThuongHieu_User_idUser]
GO
USE [master]
GO
ALTER DATABASE [DOANNET] SET  READ_WRITE 
GO
