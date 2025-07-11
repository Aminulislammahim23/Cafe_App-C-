USE [master]
GO
/****** Object:  Database [CafeDB]    Script Date: 7/9/2025 7:30:28 PM ******/
CREATE DATABASE [CafeDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CafeDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CafeDB.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CafeDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CafeDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CafeDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CafeDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CafeDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CafeDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CafeDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CafeDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CafeDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CafeDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CafeDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CafeDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CafeDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CafeDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CafeDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CafeDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CafeDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CafeDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CafeDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CafeDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CafeDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CafeDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CafeDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CafeDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CafeDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CafeDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CafeDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CafeDB] SET  MULTI_USER 
GO
ALTER DATABASE [CafeDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CafeDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CafeDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CafeDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [CafeDB]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 7/9/2025 7:30:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[OrderID] [nvarchar](20) NULL,
	[ItemName] [varchar](50) NULL,
	[UnitPrice] [float] NULL,
	[Qty] [int] NULL,
	[Amount] [float] NULL,
	[SellerID] [nvarchar](20) NULL,
	[MemberID] [nvarchar](20) NULL,
	[Category] [varchar](80) NULL,
	[PayBy] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 7/9/2025 7:30:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [nvarchar](30) NULL,
	[Name] [varchar](10) NULL,
	[Phone] [nvarchar](20) NULL,
	[Role] [varchar](10) NULL,
	[Amount] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InfoData]    Script Date: 7/9/2025 7:30:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InfoData](
	[ID] [varchar](50) NOT NULL,
	[Name] [varchar](80) NULL,
	[Password] [varchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Role] [nvarchar](20) NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notice]    Script Date: 7/9/2025 7:30:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notice](
	[Notice] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderList]    Script Date: 7/9/2025 7:30:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderList](
	[Serial] [nvarchar](10) NULL,
	[ItemName] [varchar](50) NULL,
	[Category] [varchar](80) NULL,
	[UnitPrice] [float] NULL,
	[Qty] [int] NULL,
	[Amount] [float] NULL,
	[DateAndTime] [nvarchar](50) NULL,
	[OrderID] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 7/9/2025 7:30:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ItemID] [varchar](50) NOT NULL,
	[IName] [varchar](80) NULL,
	[ICategory] [nvarchar](50) NULL,
	[IPrice] [float] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TotalBill]    Script Date: 7/9/2025 7:30:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TotalBill](
	[ItemName] [varchar](80) NULL,
	[Category] [varchar](80) NULL,
	[UnitPrice] [float] NULL,
	[Qty] [int] NULL,
	[Amount] [float] NULL,
	[DateAndTime] [nvarchar](50) NULL,
	[SellerID] [nvarchar](20) NULL,
	[MemberID] [nvarchar](20) NULL,
	[OrderID] [nvarchar](20) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Customer] ([ID], [Name], [Phone], [Role], [Amount]) VALUES (N'c-001', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[InfoData] ([ID], [Name], [Password], [Phone], [Role]) VALUES (N'a-001', N'mahim', N'552299', N'01629942052', N'admin')
GO
INSERT [dbo].[Product] ([ItemID], [IName], [ICategory], [IPrice]) VALUES (N'pd-2', N'banana juices', N'fresh juices', 50)
INSERT [dbo].[Product] ([ItemID], [IName], [ICategory], [IPrice]) VALUES (N'pd-3', N'apple juice', N'fresh juices', 70)
GO
USE [master]
GO
ALTER DATABASE [CafeDB] SET  READ_WRITE 
GO
