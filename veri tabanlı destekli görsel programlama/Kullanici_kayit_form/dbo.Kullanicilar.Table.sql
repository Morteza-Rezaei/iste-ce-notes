USE [iste]
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 29.04.2024 16:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[Id] [int] NULL,
	[KullaniciAdi] [text] NULL,
	[Eposta] [text] NULL,
	[Sifre] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Kullanicilar] ([Id], [KullaniciAdi], [Eposta], [Sifre]) VALUES (NULL, N'', N'', N'')
INSERT [dbo].[Kullanicilar] ([Id], [KullaniciAdi], [Eposta], [Sifre]) VALUES (NULL, N'morteza', N'deneme', N'1234')
INSERT [dbo].[Kullanicilar] ([Id], [KullaniciAdi], [Eposta], [Sifre]) VALUES (NULL, N'ali', N'deneme', N'1234')
GO
