USE [BlogEngine]
GO

/****** Object:  Table [dbo].[Posts]    Script Date: 18/02/2023 11:19:05 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Posts](
	[Id] [int]IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[Author] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NOT NULL CHECK([Status] in ('Created', 'Published', 'Penddding Appoval', 'Rejected')) DEFAULT 'Created'

) ON [PRIMARY] 
GO
/****** Object:  Table [dbo].[Coments]    Script Date: 21/02/2023 7:20:10 p. m. ******/

CREATE TABLE [dbo].[Coments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Coment] [nvarchar](max) NULL,
	[PostId] [int] NULL,
 CONSTRAINT [PK_Coments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Coments]  WITH CHECK ADD  CONSTRAINT [FK_Coments_Posts] FOREIGN KEY([PostId])
REFERENCES [dbo].[Posts] ([Id])
GO

ALTER TABLE [dbo].[Coments] CHECK CONSTRAINT [FK_Coments_Posts]
GO

