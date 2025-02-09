USE [iste]
GO
/****** Object:  Table [dbo].[Kitaplar]    Script Date: 29.04.2024 16:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitaplar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KitapAdi] [text] NULL,
	[Yazar] [text] NULL,
	[YayinYili] [date] NULL,
 CONSTRAINT [PK_Kitaplar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kitaplar] ON 

INSERT [dbo].[Kitaplar] ([Id], [KitapAdi], [Yazar], [YayinYili]) VALUES (3, N'Ben', N'test', CAST(N'2023-12-05' AS Date))
INSERT [dbo].[Kitaplar] ([Id], [KitapAdi], [Yazar], [YayinYili]) VALUES (4, N'sdfasdf', N'test', CAST(N'2023-12-05' AS Date))
SET IDENTITY_INSERT [dbo].[Kitaplar] OFF
GO
