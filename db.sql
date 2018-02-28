USE [MvcInternationalization]
GO
/****** Object:  Table [dbo].[Resources]    Script Date: 28.02.2018 Çarþamba 16:26:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resources](
	[Culture] [varchar](10) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Value] [nvarchar](4000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Name] ASC,
	[Culture] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
