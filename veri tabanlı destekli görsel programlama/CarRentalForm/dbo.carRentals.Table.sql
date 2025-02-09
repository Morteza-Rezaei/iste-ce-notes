USE [iste]
GO
/****** Object:  Table [dbo].[carRentals]    Script Date: 29.04.2024 16:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carRentals](
	[RentalId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[PickupDate] [date] NOT NULL,
	[ReturnDate] [date] NOT NULL,
	[CarModel] [nvarchar](100) NOT NULL,
	[Price] [decimal](19, 4) NOT NULL,
	[Telefon] [int] NOT NULL,
 CONSTRAINT [PK_carRentals] PRIMARY KEY CLUSTERED 
(
	[RentalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[carRentals] ON 

INSERT [dbo].[carRentals] ([RentalId], [CustomerName], [Email], [PickupDate], [ReturnDate], [CarModel], [Price], [Telefon]) VALUES (1, N'', N'', CAST(N'2024-03-15' AS Date), CAST(N'2024-03-15' AS Date), N'', CAST(0.0000 AS Decimal(19, 4)), 0)
INSERT [dbo].[carRentals] ([RentalId], [CustomerName], [Email], [PickupDate], [ReturnDate], [CarModel], [Price], [Telefon]) VALUES (2, N'morteza', N'test', CAST(N'2024-03-15' AS Date), CAST(N'2024-03-15' AS Date), N'test', CAST(0.0000 AS Decimal(19, 4)), 0)
SET IDENTITY_INSERT [dbo].[carRentals] OFF
GO
