USE [iste]
GO
/****** Object:  Table [dbo].[Reservations]    Script Date: 29.04.2024 16:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservations](
	[ReservationId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[CheckInDate] [date] NULL,
	[CheckOutDate] [date] NULL,
 CONSTRAINT [PK_Reservations] PRIMARY KEY CLUSTERED 
(
	[ReservationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Reservations] ON 

INSERT [dbo].[Reservations] ([ReservationId], [CustomerName], [Email], [CheckInDate], [CheckOutDate]) VALUES (1, N'Morteza', N'moradimurtaza84@gmail.com', CAST(N'2024-03-15' AS Date), CAST(N'2024-03-20' AS Date))
INSERT [dbo].[Reservations] ([ReservationId], [CustomerName], [Email], [CheckInDate], [CheckOutDate]) VALUES (2, N'Ali', N'Ali@gmail.com', CAST(N'2024-03-20' AS Date), CAST(N'2024-03-31' AS Date))
SET IDENTITY_INSERT [dbo].[Reservations] OFF
GO
