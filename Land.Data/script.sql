USE [master]
GO
/****** Object:  Database [LandProperties]    Script Date: 10.8.2015 г. 19:25:17 ******/
CREATE DATABASE [LandProperties]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LandProperties', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\LandProperties.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LandProperties_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\LandProperties_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
ALTER DATABASE [LandProperties] SET AUTO_CREATE_STATISTICS ON 
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
USE [LandProperties]
GO
/****** Object:  Table [dbo].[LandProperties]    Script Date: 10.8.2015 г. 19:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LandProperties](
	[MortageID] [int] NOT NULL,
	[UPI] [nvarchar](50) NOT NULL,
	[Area] [float] NOT NULL,
	[Picture] [nvarchar](50) NULL,
 CONSTRAINT [PK_LandProperties] PRIMARY KEY CLUSTERED 
(
	[UPI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LandPropertiesOwners]    Script Date: 10.8.2015 г. 19:25:18 ******/
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
/****** Object:  Table [dbo].[Mortages]    Script Date: 10.8.2015 г. 19:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mortages](
	[MortageID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Mortages] PRIMARY KEY CLUSTERED 
(
	[MortageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Owners]    Script Date: 10.8.2015 г. 19:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Owners](
	[OwnerID] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Picture] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Owners] PRIMARY KEY CLUSTERED 
(
	[OwnerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[LandProperties]  WITH CHECK ADD  CONSTRAINT [FK_LandProperties_Mortages] FOREIGN KEY([MortageID])
REFERENCES [dbo].[Mortages] ([MortageID])
GO
ALTER TABLE [dbo].[LandProperties] CHECK CONSTRAINT [FK_LandProperties_Mortages]
GO
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
USE [master]
GO
ALTER DATABASE [LandProperties] SET  READ_WRITE 
GO
