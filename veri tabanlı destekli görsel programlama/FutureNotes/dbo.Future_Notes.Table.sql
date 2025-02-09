USE [iste]
GO
/****** Object:  Table [dbo].[Future_Notes]    Script Date: 29.04.2024 16:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Future_Notes](
	[id] [int] IDENTITY(100,1) NOT NULL,
	[recipients] [nvarchar](100) NULL,
	[note] [nvarchar](1000) NULL,
	[display_date] [datetime] NOT NULL,
	[created_at] [datetime] NOT NULL,
 CONSTRAINT [PK_Future_Notes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Future_Notes] ON 

INSERT [dbo].[Future_Notes] ([id], [recipients], [note], [display_date], [created_at]) VALUES (114, N'', N'', CAST(N'2024-04-29T02:23:50.000' AS DateTime), CAST(N'2024-04-29T02:23:46.000' AS DateTime))
INSERT [dbo].[Future_Notes] ([id], [recipients], [note], [display_date], [created_at]) VALUES (115, N'fsdf', N'dfasdf', CAST(N'2024-04-29T02:33:09.000' AS DateTime), CAST(N'2024-04-29T02:31:18.003' AS DateTime))
INSERT [dbo].[Future_Notes] ([id], [recipients], [note], [display_date], [created_at]) VALUES (116, N'', N'', CAST(N'2024-04-29T02:40:23.000' AS DateTime), CAST(N'2024-04-29T02:39:30.780' AS DateTime))
INSERT [dbo].[Future_Notes] ([id], [recipients], [note], [display_date], [created_at]) VALUES (117, N'as', N'sadfasdf', CAST(N'2024-04-29T03:04:01.000' AS DateTime), CAST(N'2024-04-29T03:03:17.603' AS DateTime))
INSERT [dbo].[Future_Notes] ([id], [recipients], [note], [display_date], [created_at]) VALUES (118, N'asfasdf', N'sdfasdfasdfasdfasdf', CAST(N'2024-04-29T03:09:10.000' AS DateTime), CAST(N'2024-04-29T03:08:26.240' AS DateTime))
INSERT [dbo].[Future_Notes] ([id], [recipients], [note], [display_date], [created_at]) VALUES (119, N'', N'', CAST(N'2024-04-29T03:11:50.000' AS DateTime), CAST(N'2024-04-29T03:10:57.217' AS DateTime))
INSERT [dbo].[Future_Notes] ([id], [recipients], [note], [display_date], [created_at]) VALUES (120, N'', N'', CAST(N'2024-04-29T03:12:20.000' AS DateTime), CAST(N'2024-04-29T03:11:28.287' AS DateTime))
INSERT [dbo].[Future_Notes] ([id], [recipients], [note], [display_date], [created_at]) VALUES (121, N'', N'', CAST(N'2024-04-29T03:13:00.000' AS DateTime), CAST(N'2024-04-29T03:11:36.127' AS DateTime))
INSERT [dbo].[Future_Notes] ([id], [recipients], [note], [display_date], [created_at]) VALUES (122, N'', N'', CAST(N'2024-04-29T03:15:05.000' AS DateTime), CAST(N'2024-04-29T03:14:56.657' AS DateTime))
INSERT [dbo].[Future_Notes] ([id], [recipients], [note], [display_date], [created_at]) VALUES (123, N'dsdfcZXc', N'// Eğer notun görüntüleme tarihi şu anki tarihe eşitse
// bu yüzden sadece saat ve dakika kıyası yapılır
// tarih saat ve dakikayi önce değişkene atarız
int year = ((DateTime)reader["display_date"]).Year;
int month = ((DateTime)reader["display_date"]).Month;
int day = ((DateTime)reader["display_date"]).Day;
int hour = ((DateTime)reader["display_date"]).Hour;
int minute = ((DateTime)reader["display_date"]).Minute;

DateTime displayDate = new DateTime(year, month, day, hour, minute, 0);

// şu anki tarihi alırız
DateTime now = DateTime.Now;
now = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0);

if (DateTime.Compare(displayDate, now) == 0)
{
    MessageBox.Show(reader["note"].ToString(), "Not");
    // mesajı sadece bir kez göstermek döngüyü kırar
    break;
}', CAST(N'2024-04-29T03:20:40.340' AS DateTime), CAST(N'2024-04-29T03:20:45.800' AS DateTime))
INSERT [dbo].[Future_Notes] ([id], [recipients], [note], [display_date], [created_at]) VALUES (124, N'', N'if (DateTime.Compare(comparisonDate, DateTime.Now) <= 0)
{
    // Show message box
}', CAST(N'2024-04-29T03:20:47.083' AS DateTime), CAST(N'2024-04-29T03:21:32.620' AS DateTime))
SET IDENTITY_INSERT [dbo].[Future_Notes] OFF
GO
