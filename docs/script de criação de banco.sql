USE [master]
GO
/****** Object:  Database [DBMaterialControl]    Script Date: 13/07/2020 00:02:08 ******/
CREATE DATABASE [DBMaterialControl]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBMaterialControl', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DBMaterialControl.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBMaterialControl_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DBMaterialControl_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DBMaterialControl] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBMaterialControl].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBMaterialControl] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBMaterialControl] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBMaterialControl] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBMaterialControl] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBMaterialControl] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBMaterialControl] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBMaterialControl] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBMaterialControl] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBMaterialControl] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBMaterialControl] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBMaterialControl] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBMaterialControl] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBMaterialControl] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBMaterialControl] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBMaterialControl] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBMaterialControl] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBMaterialControl] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBMaterialControl] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBMaterialControl] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBMaterialControl] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBMaterialControl] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBMaterialControl] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBMaterialControl] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBMaterialControl] SET  MULTI_USER 
GO
ALTER DATABASE [DBMaterialControl] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBMaterialControl] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBMaterialControl] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBMaterialControl] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBMaterialControl] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBMaterialControl] SET QUERY_STORE = OFF
GO
USE [DBMaterialControl]
GO
/****** Object:  User [felipeaguiar]    Script Date: 13/07/2020 00:02:09 ******/
CREATE USER [felipeaguiar] FOR LOGIN [felipeaguiar] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 13/07/2020 00:02:09 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 13/07/2020 00:02:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](120) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Material]    Script Date: 13/07/2020 00:02:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Material](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](80) NOT NULL,
	[Description] [varchar](200) NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [decimal](18, 2) NOT NULL,
	[CreateDate] [datetime2](7) NULL,
	[LastUpdateDate] [datetime2](7) NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200711212839_createDatabase', N'2.2.6-servicing-10079')
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [CategoryName]) VALUES (1, N'Metais')
INSERT [dbo].[Category] ([Id], [CategoryName]) VALUES (18, N'Acessórios')
INSERT [dbo].[Category] ([Id], [CategoryName]) VALUES (23, N'Peças')
INSERT [dbo].[Category] ([Id], [CategoryName]) VALUES (24, N'Conjuntos')
INSERT [dbo].[Category] ([Id], [CategoryName]) VALUES (25, N'Plásticos')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Material] ON 

INSERT [dbo].[Material] ([Id], [Name], [Description], [Quantity], [UnitPrice], [CreateDate], [LastUpdateDate], [CategoryId]) VALUES (13, N'Cano PVC', N'10 cm - tigre', 28, CAST(0.50 AS Decimal(18, 2)), NULL, CAST(N'2020-07-13T02:12:59.7420000' AS DateTime2), 25)
INSERT [dbo].[Material] ([Id], [Name], [Description], [Quantity], [UnitPrice], [CreateDate], [LastUpdateDate], [CategoryId]) VALUES (14, N'Parafuso', N'8cm básico', 4, CAST(3.76 AS Decimal(18, 2)), NULL, CAST(N'2020-07-13T02:55:53.3090000' AS DateTime2), 18)
INSERT [dbo].[Material] ([Id], [Name], [Description], [Quantity], [UnitPrice], [CreateDate], [LastUpdateDate], [CategoryId]) VALUES (15, N'Braçadeira', N'modelo 15 cm - preto', 15, CAST(25.01 AS Decimal(18, 2)), CAST(N'2020-07-13T02:14:47.3530000' AS DateTime2), NULL, 23)
SET IDENTITY_INSERT [dbo].[Material] OFF
/****** Object:  Index [IX_Material_CategoryId]    Script Date: 13/07/2020 00:02:10 ******/
CREATE NONCLUSTERED INDEX [IX_Material_CategoryId] ON [dbo].[Material]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Material]  WITH CHECK ADD  CONSTRAINT [FK_Material_Category_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Material] CHECK CONSTRAINT [FK_Material_Category_CategoryId]
GO
USE [master]
GO
ALTER DATABASE [DBMaterialControl] SET  READ_WRITE 
GO
