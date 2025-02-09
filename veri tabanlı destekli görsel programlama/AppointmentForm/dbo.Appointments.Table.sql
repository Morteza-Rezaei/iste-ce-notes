USE [iste]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 29.04.2024 16:51:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[AppointmentId] [int] IDENTITY(1,1) NOT NULL,
	[PatientName] [nvarchar](100) NULL,
	[PatientEmail] [nvarchar](100) NULL,
	[AppointmentDate] [datetime] NULL,
	[DoctorName] [nvarchar](100) NULL,
	[Department] [nvarchar](100) NULL,
 CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED 
(
	[AppointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Appointments] ON 

INSERT [dbo].[Appointments] ([AppointmentId], [PatientName], [PatientEmail], [AppointmentDate], [DoctorName], [Department]) VALUES (1, N'morteza', N'morteza@email.com', CAST(N'2024-04-10T20:14:25.000' AS DateTime), N'morteza', N'Kardiyoloji')
SET IDENTITY_INSERT [dbo].[Appointments] OFF
GO
