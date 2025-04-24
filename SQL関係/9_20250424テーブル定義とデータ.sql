USE [TEST_DB]
GO
/****** Object:  Table [dbo].[IM_STAFF]    Script Date: 2025/04/24 9:47:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IM_STAFF]') AND type in (N'U'))
DROP TABLE [dbo].[IM_STAFF]
GO
/****** Object:  Table [dbo].[IM_ITEM_CLASS]    Script Date: 2025/04/24 9:47:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IM_ITEM_CLASS]') AND type in (N'U'))
DROP TABLE [dbo].[IM_ITEM_CLASS]
GO
/****** Object:  Table [dbo].[IM_ITEM]    Script Date: 2025/04/24 9:47:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IM_ITEM]') AND type in (N'U'))
DROP TABLE [dbo].[IM_ITEM]
GO
/****** Object:  Table [dbo].[ID_IO_HISTORY]    Script Date: 2025/04/24 9:47:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ID_IO_HISTORY]') AND type in (N'U'))
DROP TABLE [dbo].[ID_IO_HISTORY]
GO
/****** Object:  Table [dbo].[ID_IO_HISTORY]    Script Date: 2025/04/24 9:47:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ID_IO_HISTORY](
	[HistoryCD] [int] IDENTITY(1,1) NOT NULL,
	[IODate] [date] NULL,
	[ItemCD] [int] NULL,
	[IsReceived] [bit] NULL,
	[Moving] [int] NULL,
	[StaffCD] [int] NULL,
	[Remarks] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[HistoryCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IM_ITEM]    Script Date: 2025/04/24 9:47:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IM_ITEM](
	[ItemClassCD] [int] NULL,
	[ItemCD] [int] NOT NULL,
	[ItemName] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IM_ITEM_CLASS]    Script Date: 2025/04/24 9:47:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IM_ITEM_CLASS](
	[ItemClassCD] [int] NOT NULL,
	[ItemClassName] [nvarchar](30) NULL,
	[Stocks] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemClassCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IM_STAFF]    Script Date: 2025/04/24 9:47:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IM_STAFF](
	[StaffCD] [int] IDENTITY(1000,1) NOT NULL,
	[Password] [varchar](8) NULL,
	[StaffName] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ID_IO_HISTORY] ON 
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (27, CAST(N'2025-04-01' AS Date), 11, 1, 1000, 1001, N'初期在庫')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (28, CAST(N'2025-04-01' AS Date), 12, 1, 2000, 1001, N'初期在庫')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (29, CAST(N'2025-04-01' AS Date), 13, 1, 3000, 1001, N'初期在庫')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (30, CAST(N'2025-04-02' AS Date), 21, 1, 1000, 1001, N'初期在庫')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (31, CAST(N'2025-04-02' AS Date), 22, 1, 2000, 1001, N'初期在庫')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (32, CAST(N'2025-04-02' AS Date), 23, 1, 3000, 1001, N'初期在庫')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (33, CAST(N'2025-04-02' AS Date), 24, 1, 4000, 1001, N'初期在庫')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (34, CAST(N'2025-04-03' AS Date), 31, 1, 1000, 1001, N'初期在庫')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (35, CAST(N'2025-04-03' AS Date), 32, 1, 2000, 1001, N'初期在庫')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (36, CAST(N'2025-04-03' AS Date), 33, 1, 3000, 1001, N'初期在庫')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (37, CAST(N'2025-04-03' AS Date), 34, 1, 4000, 1001, N'初期在庫')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (38, CAST(N'2025-04-04' AS Date), 41, 1, 1000, 1001, N'初期在庫')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (39, CAST(N'2025-04-05' AS Date), 51, 1, 1000, 1001, N'初期在庫')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (40, CAST(N'2025-04-21' AS Date), 11, 1, 500, 1001, N'')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (41, CAST(N'2025-04-21' AS Date), 12, 0, 500, 1001, N'')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (42, CAST(N'2025-04-21' AS Date), 13, 0, 3000, 1001, N'')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (43, CAST(N'2025-04-20' AS Date), 11, 1, 200, 1001, N'')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (44, CAST(N'2025-04-21' AS Date), 11, 0, 1000, 1000, N'')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (45, CAST(N'2025-04-21' AS Date), 11, 0, 500, 1000, N'')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (1043, CAST(N'2025-04-08' AS Date), 21, 1, 100, 1001, N'')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (1044, CAST(N'2025-04-09' AS Date), 21, 1, 3000, 1001, N'')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (1045, CAST(N'2025-04-10' AS Date), 21, 1, 200, 1001, N'')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (1046, CAST(N'2025-04-11' AS Date), 21, 0, 100, 1001, N'')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (1047, CAST(N'2025-04-12' AS Date), 21, 1, 500, 1001, N'')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (1048, CAST(N'2025-04-13' AS Date), 21, 0, 100, 1001, N'')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (1049, CAST(N'2025-04-14' AS Date), 21, 1, 200, 1001, N'')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (1050, CAST(N'2025-04-16' AS Date), 21, 0, 500, 1001, N'')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (1051, CAST(N'2025-04-18' AS Date), 21, 0, 200, 1001, N'')
GO
INSERT [dbo].[ID_IO_HISTORY] ([HistoryCD], [IODate], [ItemCD], [IsReceived], [Moving], [StaffCD], [Remarks]) VALUES (1052, CAST(N'2025-04-20' AS Date), 21, 0, 100, 1001, N'')
GO
SET IDENTITY_INSERT [dbo].[ID_IO_HISTORY] OFF
GO
INSERT [dbo].[IM_ITEM] ([ItemClassCD], [ItemCD], [ItemName]) VALUES (1, 11, N'ボールペン　赤')
GO
INSERT [dbo].[IM_ITEM] ([ItemClassCD], [ItemCD], [ItemName]) VALUES (1, 12, N'ボールペン　青')
GO
INSERT [dbo].[IM_ITEM] ([ItemClassCD], [ItemCD], [ItemName]) VALUES (1, 13, N'ボールペン　緑')
GO
INSERT [dbo].[IM_ITEM] ([ItemClassCD], [ItemCD], [ItemName]) VALUES (2, 21, N'A3用紙')
GO
INSERT [dbo].[IM_ITEM] ([ItemClassCD], [ItemCD], [ItemName]) VALUES (2, 22, N'A4用紙')
GO
INSERT [dbo].[IM_ITEM] ([ItemClassCD], [ItemCD], [ItemName]) VALUES (2, 23, N'B3用紙')
GO
INSERT [dbo].[IM_ITEM] ([ItemClassCD], [ItemCD], [ItemName]) VALUES (2, 24, N'A4用紙')
GO
INSERT [dbo].[IM_ITEM] ([ItemClassCD], [ItemCD], [ItemName]) VALUES (3, 31, N'マーカー　赤')
GO
INSERT [dbo].[IM_ITEM] ([ItemClassCD], [ItemCD], [ItemName]) VALUES (3, 32, N'マーカー　青')
GO
INSERT [dbo].[IM_ITEM] ([ItemClassCD], [ItemCD], [ItemName]) VALUES (3, 33, N'マーカー　緑')
GO
INSERT [dbo].[IM_ITEM] ([ItemClassCD], [ItemCD], [ItemName]) VALUES (3, 34, N'マーカー　黄')
GO
INSERT [dbo].[IM_ITEM] ([ItemClassCD], [ItemCD], [ItemName]) VALUES (4, 41, N'筆箱　赤')
GO
INSERT [dbo].[IM_ITEM] ([ItemClassCD], [ItemCD], [ItemName]) VALUES (5, 51, N'シャープペンシル ')
GO
INSERT [dbo].[IM_ITEM_CLASS] ([ItemClassCD], [ItemClassName], [Stocks]) VALUES (1, N'ボールペン', 10)
GO
INSERT [dbo].[IM_ITEM_CLASS] ([ItemClassCD], [ItemClassName], [Stocks]) VALUES (2, N'用紙', 100)
GO
INSERT [dbo].[IM_ITEM_CLASS] ([ItemClassCD], [ItemClassName], [Stocks]) VALUES (3, N'マーカー', 50)
GO
INSERT [dbo].[IM_ITEM_CLASS] ([ItemClassCD], [ItemClassName], [Stocks]) VALUES (4, N'筆箱', 30)
GO
INSERT [dbo].[IM_ITEM_CLASS] ([ItemClassCD], [ItemClassName], [Stocks]) VALUES (5, N'シープペンシル', 30)
GO
SET IDENTITY_INSERT [dbo].[IM_STAFF] ON 
GO
INSERT [dbo].[IM_STAFF] ([StaffCD], [Password], [StaffName]) VALUES (1000, N'12345678', N'テスト')
GO
INSERT [dbo].[IM_STAFF] ([StaffCD], [Password], [StaffName]) VALUES (1001, N'11112222', N'三田井')
GO
INSERT [dbo].[IM_STAFF] ([StaffCD], [Password], [StaffName]) VALUES (1002, N'33334444', N'谷')
GO
SET IDENTITY_INSERT [dbo].[IM_STAFF] OFF
GO
