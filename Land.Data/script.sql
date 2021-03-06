USE [master]
GO
/****** Object:  Database [LandProperties]    Script Date: 13.08.2015 21:32:04 ******/
CREATE DATABASE [LandProperties]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LandProperties', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LandProperties.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LandProperties_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LandProperties_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LandProperties] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LandProperties].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LandProperties] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LandProperties] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LandProperties] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LandProperties] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LandProperties] SET ARITHABORT OFF 
GO
ALTER DATABASE [LandProperties] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LandProperties] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LandProperties] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LandProperties] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LandProperties] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LandProperties] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LandProperties] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LandProperties] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LandProperties] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LandProperties] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LandProperties] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LandProperties] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LandProperties] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LandProperties] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LandProperties] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LandProperties] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LandProperties] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LandProperties] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LandProperties] SET  MULTI_USER 
GO
ALTER DATABASE [LandProperties] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LandProperties] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LandProperties] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LandProperties] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [LandProperties] SET DELAYED_DURABILITY = DISABLED 
GO
USE [LandProperties]
GO
/****** Object:  Table [dbo].[LandProperties]    Script Date: 13.08.2015 21:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LandProperties](
	[UPI] [nvarchar](50) NOT NULL,
	[Area] [float] NOT NULL,
	[Picture] [nvarchar](50) NULL,
 CONSTRAINT [PK_LandProperties] PRIMARY KEY CLUSTERED 
(
	[UPI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LandPropertiesOwners]    Script Date: 13.08.2015 21:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LandPropertiesOwners](
	[UPI] [nvarchar](50) NOT NULL,
	[OwnerID] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LandPropertiesOwners] PRIMARY KEY CLUSTERED 
(
	[UPI] ASC,
	[OwnerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mortgages]    Script Date: 13.08.2015 21:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mortgages](
	[Date] [datetime] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[UPI] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Mortages_1] PRIMARY KEY CLUSTERED 
(
	[UPI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Owners]    Script Date: 13.08.2015 21:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Owners](
	[OwnerID] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Picture] [nvarchar](50) NULL,
 CONSTRAINT [PK_Owners] PRIMARY KEY CLUSTERED 
(
	[OwnerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[LandProperties] ([UPI], [Area], [Picture]) VALUES (N'ASD1', 8888, N'asd.jpg')
INSERT [dbo].[LandProperties] ([UPI], [Area], [Picture]) VALUES (N'SDF2', 8888, N'gfd.jpg')
INSERT [dbo].[LandProperties] ([UPI], [Area], [Picture]) VALUES (N'WER1', 5, N'fgfd.jpg')
INSERT [dbo].[LandPropertiesOwners] ([UPI], [OwnerID]) VALUES (N'ASD1', N'IVAN18')
INSERT [dbo].[LandPropertiesOwners] ([UPI], [OwnerID]) VALUES (N'ASD1', N'PESHO17')
INSERT [dbo].[LandPropertiesOwners] ([UPI], [OwnerID]) VALUES (N'SDF2', N'GEORGI1')
INSERT [dbo].[LandPropertiesOwners] ([UPI], [OwnerID]) VALUES (N'WER1', N'PESHO17')
INSERT [dbo].[Owners] ([OwnerID], [FirstName], [LastName], [Address], [Picture]) VALUES (N'GEORGI1', N'Georgiiii', N'Nikolov', N'Varna', N'vvv.jpg')
INSERT [dbo].[Owners] ([OwnerID], [FirstName], [LastName], [Address], [Picture]) VALUES (N'IVAN18', N'Ivancho', N'ivanov', N'Burgas', N'bbbb.jpg')
INSERT [dbo].[Owners] ([OwnerID], [FirstName], [LastName], [Address], [Picture]) VALUES (N'LALAAA!!', N'Mecho', N'Puch', N'Goliamata Gora', NULL)
INSERT [dbo].[Owners] ([OwnerID], [FirstName], [LastName], [Address], [Picture]) VALUES (N'PESHO17', N'Pesho', N'Petrov', N'Sofia', N'pppp.jpg')
INSERT [dbo].[Owners] ([OwnerID], [FirstName], [LastName], [Address], [Picture]) VALUES (N'SSSSSSS', N'Stefan', N'Ivanov', N'London', NULL)
INSERT [dbo].[Owners] ([OwnerID], [FirstName], [LastName], [Address], [Picture]) VALUES (N'STEFAN1', N'Stefann', N'Stefanov', N'Plovdiv', N'eeeee.png')
ALTER TABLE [dbo].[LandPropertiesOwners]  WITH CHECK ADD  CONSTRAINT [FK_LandPropertiesOwners_LandProperties] FOREIGN KEY([UPI])
REFERENCES [dbo].[LandProperties] ([UPI])
GO
ALTER TABLE [dbo].[LandPropertiesOwners] CHECK CONSTRAINT [FK_LandPropertiesOwners_LandProperties]
GO
ALTER TABLE [dbo].[LandPropertiesOwners]  WITH CHECK ADD  CONSTRAINT [FK_LandPropertiesOwners_Owners] FOREIGN KEY([OwnerID])
REFERENCES [dbo].[Owners] ([OwnerID])
GO
ALTER TABLE [dbo].[LandPropertiesOwners] CHECK CONSTRAINT [FK_LandPropertiesOwners_Owners]
GO
ALTER TABLE [dbo].[Mortgages]  WITH CHECK ADD  CONSTRAINT [FK_Mortages_LandProperties] FOREIGN KEY([UPI])
REFERENCES [dbo].[LandProperties] ([UPI])
GO
ALTER TABLE [dbo].[Mortgages] CHECK CONSTRAINT [FK_Mortages_LandProperties]
GO
USE [master]
GO
ALTER DATABASE [LandProperties] SET  READ_WRITE 
GO
