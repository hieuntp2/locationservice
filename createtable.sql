create database [locationservice]
go

USE [locationservice]
GO
/****** Object:  Table [dbo].[location]    Script Date: 06/15/2015 16:07:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[location](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[X] [nvarchar](10) NOT NULL,
	[Y] [nvarchar](50) NOT NULL,
	[time] [datetime] NOT NULL,
	[message] [nvarchar](255) NOT NULL,
	[uploadtime] [datetime] NOT NULL,
 CONSTRAINT [PK_location] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
