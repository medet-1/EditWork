USE [master]
GO
/****** Object:  Database [Calisma]    Script Date: 11.12.2021 21:36:40 ******/
CREATE DATABASE [Calisma]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Calisma', FILENAME = N'C:\Users\90535\Calisma.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Calisma_log', FILENAME = N'C:\Users\90535\Calisma_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Calisma] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Calisma].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Calisma] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Calisma] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Calisma] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Calisma] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Calisma] SET ARITHABORT OFF 
GO
ALTER DATABASE [Calisma] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Calisma] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Calisma] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Calisma] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Calisma] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Calisma] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Calisma] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Calisma] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Calisma] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Calisma] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Calisma] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Calisma] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Calisma] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Calisma] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Calisma] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Calisma] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Calisma] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Calisma] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Calisma] SET  MULTI_USER 
GO
ALTER DATABASE [Calisma] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Calisma] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Calisma] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Calisma] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Calisma] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Calisma] SET QUERY_STORE = OFF
GO
USE [Calisma]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Calisma]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 11.12.2021 21:36:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teams]    Script Date: 11.12.2021 21:36:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teams](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Created] [datetime] NULL,
 CONSTRAINT [PK_Teams] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Works]    Script Date: 11.12.2021 21:36:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Works](
	[ID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[WorkID] [int] NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Beginning] [datetime] NULL,
	[Finish] [datetime] NULL,
	[Creat] [datetime] NULL,
	[Deleted] [bit] NOT NULL,
	[Effort] [int] NULL,
	[TeamID] [int] NOT NULL,
	[StatuID] [int] NOT NULL,
	[Changing] [datetime] NULL,
	[WorkType] [int] NULL,
 CONSTRAINT [PK_Works] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([ID], [Name]) VALUES (1, N'In-Flight')
INSERT [dbo].[Status] ([ID], [Name]) VALUES (2, N'Committed')
INSERT [dbo].[Status] ([ID], [Name]) VALUES (3, N'Estimating')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[Teams] ON 

INSERT [dbo].[Teams] ([ID], [Name], [Created]) VALUES (1, N'IcerikYonetimiKampanya', CAST(N'2021-11-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Teams] ([ID], [Name], [Created]) VALUES (2, N'Kredi', CAST(N'2021-11-18T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Teams] OFF
GO
SET IDENTITY_INSERT [dbo].[Works] ON 

INSERT [dbo].[Works] ([ID], [WorkID], [Name], [Beginning], [Finish], [Creat], [Deleted], [Effort], [TeamID], [StatuID], [Changing], [WorkType]) VALUES (1, 100, N'ATest', CAST(N'2021-02-01T00:00:00.000' AS DateTime), CAST(N'2021-02-20T00:00:00.000' AS DateTime), CAST(N'2021-12-07T10:28:08.877' AS DateTime), 0, 100, 1, 0, CAST(N'2021-12-07T10:28:08.877' AS DateTime), 2)
INSERT [dbo].[Works] ([ID], [WorkID], [Name], [Beginning], [Finish], [Creat], [Deleted], [Effort], [TeamID], [StatuID], [Changing], [WorkType]) VALUES (2, 100, N'ATasarım', CAST(N'2021-02-01T00:00:00.000' AS DateTime), CAST(N'2021-02-20T00:00:00.000' AS DateTime), CAST(N'2021-12-07T10:28:49.067' AS DateTime), 0, 123, 1, 0, CAST(N'2021-12-07T10:28:49.067' AS DateTime), 0)
INSERT [dbo].[Works] ([ID], [WorkID], [Name], [Beginning], [Finish], [Creat], [Deleted], [Effort], [TeamID], [StatuID], [Changing], [WorkType]) VALUES (3, 100, N'AAnaliz', CAST(N'2021-02-09T00:00:00.000' AS DateTime), CAST(N'2022-05-01T00:00:00.000' AS DateTime), CAST(N'2021-12-07T10:29:38.227' AS DateTime), 0, 123, 1, 1, CAST(N'2021-12-07T10:29:38.227' AS DateTime), 1)
INSERT [dbo].[Works] ([ID], [WorkID], [Name], [Beginning], [Finish], [Creat], [Deleted], [Effort], [TeamID], [StatuID], [Changing], [WorkType]) VALUES (4, 120, N'BTest', CAST(N'2021-02-10T00:00:00.000' AS DateTime), CAST(N'2021-04-05T00:00:00.000' AS DateTime), CAST(N'2021-12-07T10:30:41.640' AS DateTime), 0, 99, 2, 0, CAST(N'2021-12-07T10:30:41.640' AS DateTime), 2)
INSERT [dbo].[Works] ([ID], [WorkID], [Name], [Beginning], [Finish], [Creat], [Deleted], [Effort], [TeamID], [StatuID], [Changing], [WorkType]) VALUES (5, 120, N'BTasarım', CAST(N'2021-02-10T00:00:00.000' AS DateTime), CAST(N'2021-04-05T00:00:00.000' AS DateTime), CAST(N'2021-12-07T10:31:22.597' AS DateTime), 0, 91, 2, 0, CAST(N'2021-12-07T10:31:22.597' AS DateTime), 0)
INSERT [dbo].[Works] ([ID], [WorkID], [Name], [Beginning], [Finish], [Creat], [Deleted], [Effort], [TeamID], [StatuID], [Changing], [WorkType]) VALUES (6, 120, N'BAnaliz', CAST(N'2021-02-10T00:00:00.000' AS DateTime), CAST(N'2021-04-05T00:00:00.000' AS DateTime), CAST(N'2021-12-07T10:32:35.097' AS DateTime), 0, 88, 2, 0, CAST(N'2021-12-07T10:32:35.097' AS DateTime), 1)
INSERT [dbo].[Works] ([ID], [WorkID], [Name], [Beginning], [Finish], [Creat], [Deleted], [Effort], [TeamID], [StatuID], [Changing], [WorkType]) VALUES (7, 188, N'CTest', CAST(N'2021-10-10T00:00:00.000' AS DateTime), CAST(N'2022-03-03T00:00:00.000' AS DateTime), CAST(N'2021-12-07T10:33:30.647' AS DateTime), 0, 55, 1, 0, CAST(N'2021-12-07T10:33:30.647' AS DateTime), 2)
INSERT [dbo].[Works] ([ID], [WorkID], [Name], [Beginning], [Finish], [Creat], [Deleted], [Effort], [TeamID], [StatuID], [Changing], [WorkType]) VALUES (8, 188, N'CAnaliz', CAST(N'2021-10-10T00:00:00.000' AS DateTime), CAST(N'2022-03-03T00:00:00.000' AS DateTime), CAST(N'2021-12-07T10:34:20.973' AS DateTime), 0, 99, 1, 0, CAST(N'2021-12-07T10:34:20.973' AS DateTime), 1)
INSERT [dbo].[Works] ([ID], [WorkID], [Name], [Beginning], [Finish], [Creat], [Deleted], [Effort], [TeamID], [StatuID], [Changing], [WorkType]) VALUES (9, 188, N'CTasarım', CAST(N'2021-10-10T00:00:00.000' AS DateTime), CAST(N'2022-03-03T00:00:00.000' AS DateTime), CAST(N'2021-12-07T10:35:47.483' AS DateTime), 0, 190, 1, 1, CAST(N'2021-12-07T10:35:47.483' AS DateTime), 0)
INSERT [dbo].[Works] ([ID], [WorkID], [Name], [Beginning], [Finish], [Creat], [Deleted], [Effort], [TeamID], [StatuID], [Changing], [WorkType]) VALUES (1002, 189, N'DTest', CAST(N'2021-12-01T00:00:00.000' AS DateTime), CAST(N'2021-12-31T00:00:00.000' AS DateTime), CAST(N'2021-12-07T14:37:50.747' AS DateTime), 0, 22, 1, 0, CAST(N'2021-12-07T14:37:50.747' AS DateTime), 2)
INSERT [dbo].[Works] ([ID], [WorkID], [Name], [Beginning], [Finish], [Creat], [Deleted], [Effort], [TeamID], [StatuID], [Changing], [WorkType]) VALUES (1003, 189, N'DTest', CAST(N'2021-12-01T00:00:00.000' AS DateTime), CAST(N'2021-12-31T00:00:00.000' AS DateTime), CAST(N'2021-12-07T14:37:50.690' AS DateTime), 0, 22, 1, 0, CAST(N'2021-12-07T14:37:50.690' AS DateTime), 2)
INSERT [dbo].[Works] ([ID], [WorkID], [Name], [Beginning], [Finish], [Creat], [Deleted], [Effort], [TeamID], [StatuID], [Changing], [WorkType]) VALUES (1004, 190, N'DAnaliz', CAST(N'2021-04-02T00:00:00.000' AS DateTime), CAST(N'2021-04-30T00:00:00.000' AS DateTime), CAST(N'2021-12-07T14:38:54.793' AS DateTime), 0, 123, 1, 0, CAST(N'2021-12-07T14:38:54.793' AS DateTime), 1)
INSERT [dbo].[Works] ([ID], [WorkID], [Name], [Beginning], [Finish], [Creat], [Deleted], [Effort], [TeamID], [StatuID], [Changing], [WorkType]) VALUES (2002, 222, N'A1Test', CAST(N'2021-05-03T00:00:00.000' AS DateTime), CAST(N'2021-08-04T00:00:00.000' AS DateTime), CAST(N'2021-12-07T15:33:44.113' AS DateTime), 0, 121, 2, 0, CAST(N'2021-12-07T15:33:44.113' AS DateTime), 2)
INSERT [dbo].[Works] ([ID], [WorkID], [Name], [Beginning], [Finish], [Creat], [Deleted], [Effort], [TeamID], [StatuID], [Changing], [WorkType]) VALUES (2003, 222, N'A1Analiz', CAST(N'2021-06-04T00:00:00.000' AS DateTime), CAST(N'2021-08-04T00:00:00.000' AS DateTime), CAST(N'2021-12-07T15:34:20.137' AS DateTime), 0, 99, 2, 1, CAST(N'2021-12-07T15:34:20.137' AS DateTime), 1)
INSERT [dbo].[Works] ([ID], [WorkID], [Name], [Beginning], [Finish], [Creat], [Deleted], [Effort], [TeamID], [StatuID], [Changing], [WorkType]) VALUES (2004, 222, N'A1Tasarım', CAST(N'2021-03-01T00:00:00.000' AS DateTime), CAST(N'2021-10-01T00:00:00.000' AS DateTime), CAST(N'2021-12-07T15:34:58.523' AS DateTime), 0, 192, 2, 1, CAST(N'2021-12-07T15:34:58.523' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Works] OFF
GO
ALTER TABLE [dbo].[Works]  WITH CHECK ADD  CONSTRAINT [FK_Works_Teams] FOREIGN KEY([TeamID])
REFERENCES [dbo].[Teams] ([ID])
GO
ALTER TABLE [dbo].[Works] CHECK CONSTRAINT [FK_Works_Teams]
GO
USE [master]
GO
ALTER DATABASE [Calisma] SET  READ_WRITE 
GO
