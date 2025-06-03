USE [dvorak13]
GO
/****** Object:  Table [dbo].[DnDClass]    Script Date: 31.05.2025 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DnDClass](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[druh] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DnDGender]    Script Date: 31.05.2025 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DnDGender](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[druh] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DnDRace]    Script Date: 31.05.2025 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DnDRace](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[druh] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DnDStats]    Script Date: 31.05.2025 16:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DnDStats](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[stat] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DnDClass] ON 
GO
INSERT [dbo].[DnDClass] ([id], [druh]) VALUES (1, N'')
GO
INSERT [dbo].[DnDClass] ([id], [druh]) VALUES (2, N'Artificer')
GO
INSERT [dbo].[DnDClass] ([id], [druh]) VALUES (3, N'Rogue')
GO
INSERT [dbo].[DnDClass] ([id], [druh]) VALUES (4, N'Barbarian')
GO
INSERT [dbo].[DnDClass] ([id], [druh]) VALUES (5, N'Bard')
GO
INSERT [dbo].[DnDClass] ([id], [druh]) VALUES (6, N'Cleric')
GO
INSERT [dbo].[DnDClass] ([id], [druh]) VALUES (7, N'Druid')
GO
INSERT [dbo].[DnDClass] ([id], [druh]) VALUES (8, N'Fighter')
GO
INSERT [dbo].[DnDClass] ([id], [druh]) VALUES (9, N'Monk')
GO
INSERT [dbo].[DnDClass] ([id], [druh]) VALUES (10, N'Paladin')
GO
INSERT [dbo].[DnDClass] ([id], [druh]) VALUES (11, N'Ranger')
GO
INSERT [dbo].[DnDClass] ([id], [druh]) VALUES (12, N'Sorcerer')
GO
INSERT [dbo].[DnDClass] ([id], [druh]) VALUES (13, N'Warlock')
GO
INSERT [dbo].[DnDClass] ([id], [druh]) VALUES (14, N'Wizard')
GO
SET IDENTITY_INSERT [dbo].[DnDClass] OFF
GO
SET IDENTITY_INSERT [dbo].[DnDGender] ON 
GO
INSERT [dbo].[DnDGender] ([id], [druh]) VALUES (1, N'')
GO
INSERT [dbo].[DnDGender] ([id], [druh]) VALUES (2, N'Muž')
GO
INSERT [dbo].[DnDGender] ([id], [druh]) VALUES (3, N'Žena')
GO
INSERT [dbo].[DnDGender] ([id], [druh]) VALUES (4, N'Jiné')
GO
SET IDENTITY_INSERT [dbo].[DnDGender] OFF
GO
SET IDENTITY_INSERT [dbo].[DnDRace] ON 
GO
INSERT [dbo].[DnDRace] ([id], [druh]) VALUES (2, N'')
GO
INSERT [dbo].[DnDRace] ([id], [druh]) VALUES (3, N'Dwarf')
GO
INSERT [dbo].[DnDRace] ([id], [druh]) VALUES (4, N'Dragonborn')
GO
INSERT [dbo].[DnDRace] ([id], [druh]) VALUES (5, N'Elf')
GO
INSERT [dbo].[DnDRace] ([id], [druh]) VALUES (6, N'Gnome')
GO
INSERT [dbo].[DnDRace] ([id], [druh]) VALUES (7, N'Goliath')
GO
INSERT [dbo].[DnDRace] ([id], [druh]) VALUES (8, N'Halfling')
GO
INSERT [dbo].[DnDRace] ([id], [druh]) VALUES (9, N'Human')
GO
INSERT [dbo].[DnDRace] ([id], [druh]) VALUES (10, N'Orc')
GO
INSERT [dbo].[DnDRace] ([id], [druh]) VALUES (11, N'Tiefling')
GO
INSERT [dbo].[DnDRace] ([id], [druh]) VALUES (12, N'Yuanti')
GO
INSERT [dbo].[DnDRace] ([id], [druh]) VALUES (13, N'Tabaxi')
GO
SET IDENTITY_INSERT [dbo].[DnDRace] OFF
GO
SET IDENTITY_INSERT [dbo].[DnDStats] ON 
GO
INSERT [dbo].[DnDStats] ([id], [stat]) VALUES (1, N'')
GO
INSERT [dbo].[DnDStats] ([id], [stat]) VALUES (2, N'Modifier')
GO
INSERT [dbo].[DnDStats] ([id], [stat]) VALUES (3, N'Strength')
GO
INSERT [dbo].[DnDStats] ([id], [stat]) VALUES (4, N'Dexterity')
GO
INSERT [dbo].[DnDStats] ([id], [stat]) VALUES (5, N'Constitution')
GO
INSERT [dbo].[DnDStats] ([id], [stat]) VALUES (6, N'Inteligence')
GO
INSERT [dbo].[DnDStats] ([id], [stat]) VALUES (7, N'Wisdom')
GO
INSERT [dbo].[DnDStats] ([id], [stat]) VALUES (8, N'Charisma')
GO
SET IDENTITY_INSERT [dbo].[DnDStats] OFF
GO
