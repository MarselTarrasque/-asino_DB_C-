USE [Casino_Vulkan0o]
GO
/****** Object:  Table [dbo].[Bank]    Script Date: 27.09.2024 13:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bank](
	[ID_bank] [int] IDENTITY(1,1) NOT NULL,
	[Name_bank] [nvarchar](40) NULL,
	[WebsiteURL] [nvarchar](40) NULL,
	[ZipCode] [nvarchar](40) NULL,
 CONSTRAINT [PK_Bank] PRIMARY KEY CLUSTERED 
(
	[ID_bank] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 27.09.2024 13:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ID_Client] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](40) NULL,
	[Password] [nvarchar](40) NULL,
	[Date_of_registration] [date] NULL,
	[Balance] [float] NULL,
	[Id_Role] [int] NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ID_Client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[History_Of_Matches]    Script Date: 27.09.2024 13:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History_Of_Matches](
	[ID_History_of_Match] [int] IDENTITY(1,1) NOT NULL,
	[ID_Match] [int] NULL,
	[ID_Client_Contested_History_of_Matches] [int] NULL,
	[Total_Win_History_Of_Match] [float] NULL,
 CONSTRAINT [PK_History_Of_Matches] PRIMARY KEY CLUSTERED 
(
	[ID_History_of_Match] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[History_of_rounds]    Script Date: 27.09.2024 13:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History_of_rounds](
	[ID_history_of_round] [int] IDENTITY(1,1) NOT NULL,
	[ID_round] [int] NULL,
	[Bet_round] [float] NULL,
	[Coefficent] [float] NULL,
	[Exodus_of_round] [nvarchar](40) NULL,
	[Reward] [float] NULL,
	[ID_history_of_match] [int] NULL,
 CONSTRAINT [PK_History_of_rounds] PRIMARY KEY CLUSTERED 
(
	[ID_history_of_round] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Matches]    Script Date: 27.09.2024 13:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Matches](
	[ID_Mactch] [int] IDENTITY(1,1) NOT NULL,
	[Quantity_of_rounds] [int] NULL,
	[deposit] [float] NULL,
	[Total_win] [float] NULL,
	[Date_Of_Matches] [date] NULL,
 CONSTRAINT [PK_Matches] PRIMARY KEY CLUSTERED 
(
	[ID_Mactch] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Replenishment transaction]    Script Date: 27.09.2024 13:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Replenishment transaction](
	[ID_Replenishment_Transaction] [int] IDENTITY(1,1) NOT NULL,
	[Sum] [float] NULL,
	[Name_Transaction] [nvarchar](50) NULL,
	[Id_trasaction] [int] NULL,
 CONSTRAINT [PK_Replenishment transaction] PRIMARY KEY CLUSTERED 
(
	[ID_Replenishment_Transaction] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 27.09.2024 13:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[ID_Role] [int] IDENTITY(1,1) NOT NULL,
	[Name_Role] [nvarchar](50) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[ID_Role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rounds]    Script Date: 27.09.2024 13:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rounds](
	[ID_round] [int] IDENTITY(1,1) NOT NULL,
	[ID_match] [int] NULL,
	[Bet_rounds] [float] NULL,
	[Coefficent] [float] NULL,
	[Exodus_of_round] [nvarchar](40) NULL,
	[Reward] [float] NULL,
 CONSTRAINT [PK_rounds] PRIMARY KEY CLUSTERED 
(
	[ID_round] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 27.09.2024 13:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction](
	[Id_trasaction] [int] IDENTITY(1,1) NOT NULL,
	[Id_Client] [int] NULL,
	[Date_Of_Transaction] [date] NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[Id_trasaction] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Withdrawal Transaction]    Script Date: 27.09.2024 13:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Withdrawal Transaction](
	[ID_of_withdrawal] [int] IDENTITY(1,1) NOT NULL,
	[Sum] [float] NULL,
	[Name_Transaction] [nvarchar](50) NULL,
	[Id_trasaction] [int] NULL,
 CONSTRAINT [PK_Withdrawal Transaction] PRIMARY KEY CLUSTERED 
(
	[ID_of_withdrawal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bank] ON 

INSERT [dbo].[Bank] ([ID_bank], [Name_bank], [WebsiteURL], [ZipCode]) VALUES (1, N'SBP', N'site', N'code')
SET IDENTITY_INSERT [dbo].[Bank] OFF
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([ID_Client], [Login], [Password], [Date_of_registration], [Balance], [Id_Role]) VALUES (5002, N'Ad', N'Ad', CAST(N'2024-09-16' AS Date), 0, 1)
INSERT [dbo].[Client] ([ID_Client], [Login], [Password], [Date_of_registration], [Balance], [Id_Role]) VALUES (5003, N'User', N'User', CAST(N'2024-09-16' AS Date), 4488771.1, 2)
INSERT [dbo].[Client] ([ID_Client], [Login], [Password], [Date_of_registration], [Balance], [Id_Role]) VALUES (6002, N'FDFDS', N'453534', CAST(N'2024-09-17' AS Date), 0, 1)
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Replenishment transaction] ON 

INSERT [dbo].[Replenishment transaction] ([ID_Replenishment_Transaction], [Sum], [Name_Transaction], [Id_trasaction]) VALUES (1, 3213, N'Пополнение', 13)
INSERT [dbo].[Replenishment transaction] ([ID_Replenishment_Transaction], [Sum], [Name_Transaction], [Id_trasaction]) VALUES (2, 129, N'Пополнение', 1002)
SET IDENTITY_INSERT [dbo].[Replenishment transaction] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([ID_Role], [Name_Role]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([ID_Role], [Name_Role]) VALUES (2, N'User')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Transaction] ON 

INSERT [dbo].[Transaction] ([Id_trasaction], [Id_Client], [Date_Of_Transaction]) VALUES (11, 5003, CAST(N'2024-09-16' AS Date))
INSERT [dbo].[Transaction] ([Id_trasaction], [Id_Client], [Date_Of_Transaction]) VALUES (12, 5003, CAST(N'2024-09-16' AS Date))
INSERT [dbo].[Transaction] ([Id_trasaction], [Id_Client], [Date_Of_Transaction]) VALUES (13, 5003, CAST(N'2024-09-16' AS Date))
INSERT [dbo].[Transaction] ([Id_trasaction], [Id_Client], [Date_Of_Transaction]) VALUES (14, 5003, CAST(N'2024-09-16' AS Date))
INSERT [dbo].[Transaction] ([Id_trasaction], [Id_Client], [Date_Of_Transaction]) VALUES (1002, 5003, CAST(N'2024-09-17' AS Date))
INSERT [dbo].[Transaction] ([Id_trasaction], [Id_Client], [Date_Of_Transaction]) VALUES (1003, 5003, CAST(N'2024-09-17' AS Date))
SET IDENTITY_INSERT [dbo].[Transaction] OFF
GO
SET IDENTITY_INSERT [dbo].[Withdrawal Transaction] ON 

INSERT [dbo].[Withdrawal Transaction] ([ID_of_withdrawal], [Sum], [Name_Transaction], [Id_trasaction]) VALUES (11, 4324, N'Вывод', 12)
INSERT [dbo].[Withdrawal Transaction] ([ID_of_withdrawal], [Sum], [Name_Transaction], [Id_trasaction]) VALUES (12, 32132, N'Вывод', 14)
INSERT [dbo].[Withdrawal Transaction] ([ID_of_withdrawal], [Sum], [Name_Transaction], [Id_trasaction]) VALUES (1007, 1000, N'Вывод', 1003)
SET IDENTITY_INSERT [dbo].[Withdrawal Transaction] OFF
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Roles] FOREIGN KEY([Id_Role])
REFERENCES [dbo].[Roles] ([ID_Role])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Roles]
GO
ALTER TABLE [dbo].[History_Of_Matches]  WITH CHECK ADD  CONSTRAINT [FK_History_Of_Matches_Client] FOREIGN KEY([ID_Client_Contested_History_of_Matches])
REFERENCES [dbo].[Client] ([ID_Client])
GO
ALTER TABLE [dbo].[History_Of_Matches] CHECK CONSTRAINT [FK_History_Of_Matches_Client]
GO
ALTER TABLE [dbo].[History_Of_Matches]  WITH CHECK ADD  CONSTRAINT [FK_History_Of_Matches_Matches] FOREIGN KEY([ID_Match])
REFERENCES [dbo].[Matches] ([ID_Mactch])
GO
ALTER TABLE [dbo].[History_Of_Matches] CHECK CONSTRAINT [FK_History_Of_Matches_Matches]
GO
ALTER TABLE [dbo].[History_of_rounds]  WITH CHECK ADD  CONSTRAINT [FK_History_of_rounds_History_Of_Matches] FOREIGN KEY([ID_history_of_match])
REFERENCES [dbo].[History_Of_Matches] ([ID_History_of_Match])
GO
ALTER TABLE [dbo].[History_of_rounds] CHECK CONSTRAINT [FK_History_of_rounds_History_Of_Matches]
GO
ALTER TABLE [dbo].[History_of_rounds]  WITH CHECK ADD  CONSTRAINT [FK_History_of_rounds_rounds1] FOREIGN KEY([ID_round])
REFERENCES [dbo].[rounds] ([ID_round])
GO
ALTER TABLE [dbo].[History_of_rounds] CHECK CONSTRAINT [FK_History_of_rounds_rounds1]
GO
ALTER TABLE [dbo].[Replenishment transaction]  WITH CHECK ADD  CONSTRAINT [FK_Replenishment transaction_Transaction] FOREIGN KEY([Id_trasaction])
REFERENCES [dbo].[Transaction] ([Id_trasaction])
GO
ALTER TABLE [dbo].[Replenishment transaction] CHECK CONSTRAINT [FK_Replenishment transaction_Transaction]
GO
ALTER TABLE [dbo].[rounds]  WITH CHECK ADD  CONSTRAINT [FK_rounds_Matches] FOREIGN KEY([ID_match])
REFERENCES [dbo].[Matches] ([ID_Mactch])
GO
ALTER TABLE [dbo].[rounds] CHECK CONSTRAINT [FK_rounds_Matches]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_Client] FOREIGN KEY([Id_Client])
REFERENCES [dbo].[Client] ([ID_Client])
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_Client]
GO
ALTER TABLE [dbo].[Withdrawal Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Withdrawal Transaction_Transaction] FOREIGN KEY([Id_trasaction])
REFERENCES [dbo].[Transaction] ([Id_trasaction])
GO
ALTER TABLE [dbo].[Withdrawal Transaction] CHECK CONSTRAINT [FK_Withdrawal Transaction_Transaction]
GO
