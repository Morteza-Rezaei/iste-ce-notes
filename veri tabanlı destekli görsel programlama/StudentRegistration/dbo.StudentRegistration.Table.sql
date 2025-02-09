USE [iste]
GO
/****** Object:  Table [dbo].[StudentRegistration]    Script Date: 29.04.2024 16:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentRegistration](
	[StudentId] [int] IDENTITY(100,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[EnrolledDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[StudentRegistration] ON 

INSERT [dbo].[StudentRegistration] ([StudentId], [FirstName], [LastName], [Email], [DateOfBirth], [EnrolledDate]) VALUES (1001, N'test', N'test soyadı', N'test@mail.com', CAST(N'2000-03-18' AS Date), CAST(N'2024-03-18T17:30:19.887' AS DateTime))
INSERT [dbo].[StudentRegistration] ([StudentId], [FirstName], [LastName], [Email], [DateOfBirth], [EnrolledDate]) VALUES (1002, N'test2', N'test soyadı', N'test@mail.com', CAST(N'2000-03-18' AS Date), CAST(N'2024-03-18T17:30:49.890' AS DateTime))
INSERT [dbo].[StudentRegistration] ([StudentId], [FirstName], [LastName], [Email], [DateOfBirth], [EnrolledDate]) VALUES (1003, N'Erdem', N'Akatay', N'erdem@mail.com', CAST(N'2001-08-11' AS Date), CAST(N'2024-03-18T17:43:04.180' AS DateTime))
SET IDENTITY_INSERT [dbo].[StudentRegistration] OFF
GO
