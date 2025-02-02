USE [MegaCastings]
GO
/****** Object:  Table [dbo].[Apply]    Script Date: 03/12/2020 18:06:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Apply](
	[IdentifierOffer] [bigint] IDENTITY(1,1) NOT NULL,
	[IdentifierUsers] [bigint] NOT NULL,
 CONSTRAINT [PK_Apply] PRIMARY KEY CLUSTERED 
(
	[IdentifierOffer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 03/12/2020 18:06:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Identifier] [bigint] IDENTITY(1,1) NOT NULL,
	[Label] [nvarchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Identifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractType]    Script Date: 03/12/2020 18:06:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractType](
	[Identifier] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_ContractType] PRIMARY KEY CLUSTERED 
(
	[Identifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 03/12/2020 18:06:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Identifier] [bigint] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](150) NULL,
	[Lastname] [nvarchar](150) NULL,
	[Username] [nvarchar](150) NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[Admin] [bit] NOT NULL,
	[IdentifierGender] [bigint] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Identifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Filtre]    Script Date: 03/12/2020 18:06:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Filtre](
	[Identifier] [bigint] IDENTITY(1,1) NOT NULL,
	[Label] [nvarchar](30) NULL,
 CONSTRAINT [PK_Filtre] PRIMARY KEY CLUSTERED 
(
	[Identifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 03/12/2020 18:06:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[Identifier] [bigint] IDENTITY(1,1) NOT NULL,
	[Label] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Gender_1] PRIMARY KEY CLUSTERED 
(
	[Identifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 03/12/2020 18:06:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[Identifier] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[IdentifierJobType] [bigint] NOT NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[Identifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobType]    Script Date: 03/12/2020 18:06:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobType](
	[Identifier] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_JobType] PRIMARY KEY CLUSTERED 
(
	[Identifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Offer]    Script Date: 03/12/2020 18:06:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Offer](
	[Identifier] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Reference] [nvarchar](50) NULL,
	[IdentifierJob] [bigint] NOT NULL,
	[IdentifierContractType] [bigint] NOT NULL,
	[PublishDateTime] [datetime2](7) NULL,
	[Duration] [int] NOT NULL,
	[StartContractDate] [date] NULL,
	[PostCount] [int] NULL,
	[JobDescription] [nvarchar](2000) NULL,
	[ProfilDescription] [nvarchar](2000) NULL,
	[Street] [nvarchar](70) NULL,
	[City] [nvarchar](50) NULL,
	[ZipCode] [nchar](10) NULL,
	[IdentifierProducer] [bigint] NOT NULL,
	[IdentifierCategory] [bigint] NOT NULL,
	[IdentifierFilters] [bigint] NOT NULL,
	[IdentifierApply] [bigint] NULL,
 CONSTRAINT [PK_Offer] PRIMARY KEY CLUSTERED 
(
	[Identifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pack]    Script Date: 03/12/2020 18:06:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pack](
	[Identifier] [bigint] IDENTITY(1,1) NOT NULL,
	[Label] [nvarchar](150) NULL,
	[Price] [bigint] NULL,
 CONSTRAINT [PK_Pack] PRIMARY KEY CLUSTERED 
(
	[Identifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producer]    Script Date: 03/12/2020 18:06:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producer](
	[Identifier] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Url] [nvarchar](200) NULL,
	[IdentifierPack] [bigint] NOT NULL,
 CONSTRAINT [PK_Producer] PRIMARY KEY CLUSTERED 
(
	[Identifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 03/12/2020 18:06:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Identifier] [bigint] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](150) NULL,
	[Lastname] [nvarchar](150) NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](200) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Avatar] [nvarchar](2000) NULL,
	[IdentifierGender] [bigint] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Identifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Apply] ON 

INSERT [dbo].[Apply] ([IdentifierOffer], [IdentifierUsers]) VALUES (2, 15)
INSERT [dbo].[Apply] ([IdentifierOffer], [IdentifierUsers]) VALUES (3, 1)
INSERT [dbo].[Apply] ([IdentifierOffer], [IdentifierUsers]) VALUES (8, 11)
INSERT [dbo].[Apply] ([IdentifierOffer], [IdentifierUsers]) VALUES (9, 11)
INSERT [dbo].[Apply] ([IdentifierOffer], [IdentifierUsers]) VALUES (13, 16)
INSERT [dbo].[Apply] ([IdentifierOffer], [IdentifierUsers]) VALUES (21, 13)
INSERT [dbo].[Apply] ([IdentifierOffer], [IdentifierUsers]) VALUES (23, 16)
INSERT [dbo].[Apply] ([IdentifierOffer], [IdentifierUsers]) VALUES (26, 9)
INSERT [dbo].[Apply] ([IdentifierOffer], [IdentifierUsers]) VALUES (27, 15)
INSERT [dbo].[Apply] ([IdentifierOffer], [IdentifierUsers]) VALUES (28, 14)
SET IDENTITY_INSERT [dbo].[Apply] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Identifier], [Label]) VALUES (1, N'Cinema')
INSERT [dbo].[Category] ([Identifier], [Label]) VALUES (2, N'Musique')
INSERT [dbo].[Category] ([Identifier], [Label]) VALUES (3, N'Theatre')
INSERT [dbo].[Category] ([Identifier], [Label]) VALUES (4, N'Comedie')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[ContractType] ON 

INSERT [dbo].[ContractType] ([Identifier], [Name]) VALUES (1, N'CDI')
INSERT [dbo].[ContractType] ([Identifier], [Name]) VALUES (2, N'CDD')
INSERT [dbo].[ContractType] ([Identifier], [Name]) VALUES (3, N'Apprentissage')
INSERT [dbo].[ContractType] ([Identifier], [Name]) VALUES (4, N'Interim')
SET IDENTITY_INSERT [dbo].[ContractType] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Admin], [IdentifierGender]) VALUES (1, N'Creight', N'O''Duilleain', N'coduilleain0', N'MPDLHBzES', 0, 1)
INSERT [dbo].[Employee] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Admin], [IdentifierGender]) VALUES (2, N'West', N'Champniss', N'wchampniss1', N'SOlEfhzLnX', 1, 2)
INSERT [dbo].[Employee] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Admin], [IdentifierGender]) VALUES (3, N'Reube', N'Grieveson', N'rgrieveson2', N'VmOxXpbKMk', 0, 1)
INSERT [dbo].[Employee] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Admin], [IdentifierGender]) VALUES (4, N'Aggie', N'Layland', N'alayland3', N'nstf8Rzv', 0, 1)
INSERT [dbo].[Employee] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Admin], [IdentifierGender]) VALUES (5, N'Friedrick', N'Corss', N'fcorss4', N'XftgQipxP3', 0, 1)
INSERT [dbo].[Employee] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Admin], [IdentifierGender]) VALUES (6, N'Jerrome', N'Borgesio', N'jborgesio5', N'9kwONE681', 0, 1)
INSERT [dbo].[Employee] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Admin], [IdentifierGender]) VALUES (7, N'Hugibert', N'Bare', N'hbare6', N'Wcjrd7', 0, 1)
INSERT [dbo].[Employee] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Admin], [IdentifierGender]) VALUES (8, N'Davina', N'Stripling', N'dstripling7', N'rFC4rRHbETzk', 1, 1)
INSERT [dbo].[Employee] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Admin], [IdentifierGender]) VALUES (9, N'Bonni', N'Rowbottam', N'browbottam8', N'Bvfd3In', 0, 2)
INSERT [dbo].[Employee] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Admin], [IdentifierGender]) VALUES (10, N'Lilias', N'Englishby', N'lenglishby9', N'1zfBGHF7U53p', 1, 2)
INSERT [dbo].[Employee] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Admin], [IdentifierGender]) VALUES (11, N'Colline', N'Thacke', N'cthackea', N'7koqz3psB6', 1, 1)
INSERT [dbo].[Employee] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Admin], [IdentifierGender]) VALUES (12, N'Marilee', N'Mottinelli', N'mmottinellib', N'CjbQp00q', 1, 2)
INSERT [dbo].[Employee] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Admin], [IdentifierGender]) VALUES (13, N'Cthrine', N'Rearden', N'creardenc', N'u2S3f1h', 0, 1)
INSERT [dbo].[Employee] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Admin], [IdentifierGender]) VALUES (14, N'Inger', N'MacEvilly', N'imacevillyd', N'kLKNLvlOJm9', 0, 1)
INSERT [dbo].[Employee] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Admin], [IdentifierGender]) VALUES (15, N'Calvin', N'Blakeway', N'cblakewaye', N'jUuHXk', 0, 1)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Filtre] ON 

INSERT [dbo].[Filtre] ([Identifier], [Label]) VALUES (1, N'Research and Development')
INSERT [dbo].[Filtre] ([Identifier], [Label]) VALUES (2, N'Business Development')
INSERT [dbo].[Filtre] ([Identifier], [Label]) VALUES (3, N'Services')
INSERT [dbo].[Filtre] ([Identifier], [Label]) VALUES (4, N'Services')
INSERT [dbo].[Filtre] ([Identifier], [Label]) VALUES (5, N'Human Resources')
INSERT [dbo].[Filtre] ([Identifier], [Label]) VALUES (6, N'Support')
SET IDENTITY_INSERT [dbo].[Filtre] OFF
GO
SET IDENTITY_INSERT [dbo].[Gender] ON 

INSERT [dbo].[Gender] ([Identifier], [Label]) VALUES (1, N'Homme')
INSERT [dbo].[Gender] ([Identifier], [Label]) VALUES (2, N'Femme')
INSERT [dbo].[Gender] ([Identifier], [Label]) VALUES (3, N'Autres')
SET IDENTITY_INSERT [dbo].[Gender] OFF
GO
SET IDENTITY_INSERT [dbo].[Job] ON 

INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierJobType]) VALUES (1, N'Nuclear Power Engineer', 5)
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierJobType]) VALUES (2, N'Staff Scientist', 2)
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierJobType]) VALUES (3, N'Community Outreach Specialist', 5)
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierJobType]) VALUES (4, N'Database Administrator III', 3)
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierJobType]) VALUES (5, N'Help Desk Technician', 5)
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierJobType]) VALUES (6, N'Payment Adjustment Coordinator', 5)
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierJobType]) VALUES (7, N'Help Desk Operator', 1)
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierJobType]) VALUES (8, N'Research Assistant II', 3)
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierJobType]) VALUES (9, N'Librarian', 4)
INSERT [dbo].[Job] ([Identifier], [Name], [IdentifierJobType]) VALUES (10, N'Marketing Manager', 4)
SET IDENTITY_INSERT [dbo].[Job] OFF
GO
SET IDENTITY_INSERT [dbo].[JobType] ON 

INSERT [dbo].[JobType] ([Identifier], [Name]) VALUES (1, N'YAML')
INSERT [dbo].[JobType] ([Identifier], [Name]) VALUES (2, N'Successful Business Owner')
INSERT [dbo].[JobType] ([Identifier], [Name]) VALUES (3, N'Java Applets')
INSERT [dbo].[JobType] ([Identifier], [Name]) VALUES (4, N'Widgets')
INSERT [dbo].[JobType] ([Identifier], [Name]) VALUES (5, N'PDM Works')
SET IDENTITY_INSERT [dbo].[JobType] OFF
GO
SET IDENTITY_INSERT [dbo].[Offer] ON 

INSERT [dbo].[Offer] ([Identifier], [Name], [Reference], [IdentifierJob], [IdentifierContractType], [PublishDateTime], [Duration], [StartContractDate], [PostCount], [JobDescription], [ProfilDescription], [Street], [City], [ZipCode], [IdentifierProducer], [IdentifierCategory], [IdentifierFilters], [IdentifierApply]) VALUES (2, N'G.I. Joe: Retaliation', N'676171381427424878', 1, 1, CAST(N'2018-08-27T03:39:15.0000000' AS DateTime2), 13, CAST(N'2020-02-20' AS Date), 2, N'Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci.', N'Vestibulum rutrum rutrum neque.', N'19773 Jay Court', N'Villa Ojo de Agua', N'5250      ', 7, 4, 1, NULL)
INSERT [dbo].[Offer] ([Identifier], [Name], [Reference], [IdentifierJob], [IdentifierContractType], [PublishDateTime], [Duration], [StartContractDate], [PostCount], [JobDescription], [ProfilDescription], [Street], [City], [ZipCode], [IdentifierProducer], [IdentifierCategory], [IdentifierFilters], [IdentifierApply]) VALUES (3, N'Beneath Hill 60', N'5002355753105571', 1, 3, CAST(N'2019-02-21T07:33:37.0000000' AS DateTime2), 35, CAST(N'2018-12-17' AS Date), 3, N'Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi.', N'Nam nulla.', N'5089 Delaware Pass', N'Panjab', NULL, 9, 2, 4, NULL)
INSERT [dbo].[Offer] ([Identifier], [Name], [Reference], [IdentifierJob], [IdentifierContractType], [PublishDateTime], [Duration], [StartContractDate], [PostCount], [JobDescription], [ProfilDescription], [Street], [City], [ZipCode], [IdentifierProducer], [IdentifierCategory], [IdentifierFilters], [IdentifierApply]) VALUES (8, N'Band Wagon, The', N'5010125533511640', 5, 4, CAST(N'2018-06-26T14:37:57.0000000' AS DateTime2), 48, CAST(N'2020-10-07' AS Date), 4, N'Mauris lacinia sapien quis libero.', N'In hac habitasse platea dictumst.', N'4 Iowa Place', N'Rejoagung', NULL, 15, 3, 1, NULL)
INSERT [dbo].[Offer] ([Identifier], [Name], [Reference], [IdentifierJob], [IdentifierContractType], [PublishDateTime], [Duration], [StartContractDate], [PostCount], [JobDescription], [ProfilDescription], [Street], [City], [ZipCode], [IdentifierProducer], [IdentifierCategory], [IdentifierFilters], [IdentifierApply]) VALUES (9, N'Babbitt', N'3545985729975548', 2, 4, CAST(N'2018-12-31T21:12:16.0000000' AS DateTime2), 28, CAST(N'2019-02-11' AS Date), 5, N'Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.', N'Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla.', N'1 Lindbergh Trail', N'Balesari', NULL, 12, 2, 2, NULL)
INSERT [dbo].[Offer] ([Identifier], [Name], [Reference], [IdentifierJob], [IdentifierContractType], [PublishDateTime], [Duration], [StartContractDate], [PostCount], [JobDescription], [ProfilDescription], [Street], [City], [ZipCode], [IdentifierProducer], [IdentifierCategory], [IdentifierFilters], [IdentifierApply]) VALUES (13, N'Modern Romance', N'4195701846663276', 3, 2, CAST(N'2019-04-16T22:53:13.0000000' AS DateTime2), 2, CAST(N'2019-07-23' AS Date), 1, N'Nunc rhoncus dui vel sem.', N'Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.', N'4140 Ronald Regan Alley', N'Sokol’skoye', N'606670    ', 4, 1, 3, NULL)
SET IDENTITY_INSERT [dbo].[Offer] OFF
GO
SET IDENTITY_INSERT [dbo].[Pack] ON 

INSERT [dbo].[Pack] ([Identifier], [Label], [Price]) VALUES (1, N'Capital Goods', 368)
INSERT [dbo].[Pack] ([Identifier], [Label], [Price]) VALUES (2, N'Consumer Services', 498)
INSERT [dbo].[Pack] ([Identifier], [Label], [Price]) VALUES (3, N'Health Care', 428)
INSERT [dbo].[Pack] ([Identifier], [Label], [Price]) VALUES (4, N'Consumer Services', 380)
INSERT [dbo].[Pack] ([Identifier], [Label], [Price]) VALUES (5, N'Health Care', 335)
SET IDENTITY_INSERT [dbo].[Pack] OFF
GO
SET IDENTITY_INSERT [dbo].[Producer] ON 

INSERT [dbo].[Producer] ([Identifier], [Name], [UserName], [Password], [Url], [IdentifierPack]) VALUES (1, N'Konklux', N'vgoodbourn0', N'tdqU6nakvA', N'imdb.com', 1)
INSERT [dbo].[Producer] ([Identifier], [Name], [UserName], [Password], [Url], [IdentifierPack]) VALUES (2, N'Daltfresh', N'mhassell1', N'ABdq9f6F', N'purevolume.com', 2)
INSERT [dbo].[Producer] ([Identifier], [Name], [UserName], [Password], [Url], [IdentifierPack]) VALUES (3, N'Latlux', N'bdragge2', N'UQxrvm8xq', N'alexa.com', 3)
INSERT [dbo].[Producer] ([Identifier], [Name], [UserName], [Password], [Url], [IdentifierPack]) VALUES (4, N'Mat Lam Tam', N'rcaren3', N'wfUilq', N'taobao.com', 4)
INSERT [dbo].[Producer] ([Identifier], [Name], [UserName], [Password], [Url], [IdentifierPack]) VALUES (5, N'Vagram', N'awardel4', N'J06NFpBiP', N'hostgator.com', 5)
INSERT [dbo].[Producer] ([Identifier], [Name], [UserName], [Password], [Url], [IdentifierPack]) VALUES (6, N'Bamity', N'hjeays0', N'OcBz1Qf4D', N'cam.ac.uk', 4)
INSERT [dbo].[Producer] ([Identifier], [Name], [UserName], [Password], [Url], [IdentifierPack]) VALUES (7, N'Lotlux', N'chusk1', N'tObbvSZE7o', N'springer.com', 3)
INSERT [dbo].[Producer] ([Identifier], [Name], [UserName], [Password], [Url], [IdentifierPack]) VALUES (8, N'Sonair', N'nnore2', N'2AB9svX9zM5', N'arstechnica.com', 2)
INSERT [dbo].[Producer] ([Identifier], [Name], [UserName], [Password], [Url], [IdentifierPack]) VALUES (9, N'Overhold', N'vkidds3', N'UcrVVkIYBdx', N'pagesperso-orange.fr', 3)
INSERT [dbo].[Producer] ([Identifier], [Name], [UserName], [Password], [Url], [IdentifierPack]) VALUES (10, N'Cookley', N'dreinbeck4', N'67fZehq', N'tumblr.com', 5)
INSERT [dbo].[Producer] ([Identifier], [Name], [UserName], [Password], [Url], [IdentifierPack]) VALUES (11, N'Mat Lam Tam', N'ddecruse5', N'eIiCx42x', N'chron.com', 1)
INSERT [dbo].[Producer] ([Identifier], [Name], [UserName], [Password], [Url], [IdentifierPack]) VALUES (12, N'Asoka', N'psimmank6', N'LkKzd6', N'engadget.com', 2)
INSERT [dbo].[Producer] ([Identifier], [Name], [UserName], [Password], [Url], [IdentifierPack]) VALUES (13, N'Biodex', N'pedlestone7', N'VC6M80MgW1Dv', N'xing.com', 4)
INSERT [dbo].[Producer] ([Identifier], [Name], [UserName], [Password], [Url], [IdentifierPack]) VALUES (14, N'Gembucket', N'dmcfetridge8', N'LBPwBvSit1R', N'google.nl', 1)
INSERT [dbo].[Producer] ([Identifier], [Name], [UserName], [Password], [Url], [IdentifierPack]) VALUES (15, N'Aerified', N'atrays9', N'DOV84CUvuM', N'nasa.gov', 4)
SET IDENTITY_INSERT [dbo].[Producer] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (1, N'Thom', N'Cosin', N'tcosin0', N'kKnPZQtrY1', N'tcosin0@bigcartel.com', CAST(N'1963-09-03' AS Date), N'https://robohash.org/temporaiureveniam.jpg?size=50x50&set=set1', 2)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (2, N'Clea', N'Lunam', N'clunam1', N'AfHzXorbwV', N'clunam1@tmall.com', CAST(N'1905-04-15' AS Date), N'https://robohash.org/eosofficiaest.jpg?size=50x50&set=set1', 1)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (3, N'Mirabel', N'Gallego', N'mgallego2', N'fEGVBVKW', N'mgallego2@toplist.cz', CAST(N'2001-05-19' AS Date), N'https://robohash.org/culpaquasiet.jpg?size=50x50&set=set1', 2)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (4, N'Tabbie', N'Meaney', N'tmeaney3', N'KYMahZSBTk', N'tmeaney3@google.com.br', CAST(N'1950-09-29' AS Date), N'https://robohash.org/indelenitiaut.jpg?size=50x50&set=set1', 2)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (5, N'Neile', N'Stert', N'nstert4', N'wWdUSZAJ9d1P', N'nstert4@seattletimes.com', CAST(N'1994-05-01' AS Date), N'https://robohash.org/autsimiliquedolorum.jpg?size=50x50&set=set1', 1)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (6, N'Keeley', N'Bosley', N'kbosley5', N'U5H4Kfxo12T', N'kbosley5@free.fr', CAST(N'1943-02-09' AS Date), N'https://robohash.org/ipsamineos.jpg?size=50x50&set=set1', 1)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (7, N'Hector', N'Persse', N'hpersse6', N'5ZKO5GqXk5DM', N'hpersse6@twitpic.com', CAST(N'1984-05-09' AS Date), N'https://robohash.org/minimapariaturmaiores.jpg?size=50x50&set=set1', 2)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (8, N'Harrison', N'Seif', N'hseif7', N'ACAgEdK78x', N'hseif7@cornell.edu', CAST(N'1977-07-24' AS Date), N'https://robohash.org/consequunturiustodeserunt.jpg?size=50x50&set=set1', 1)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (9, N'Celine', N'Allanson', N'callanson8', N'pPr7XQwqnPO', N'callanson8@home.pl', CAST(N'1953-11-23' AS Date), N'https://robohash.org/utetnisi.jpg?size=50x50&set=set1', 2)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (10, N'Wilek', N'Barten', N'wbarten9', N'MhtfWy18d', N'wbarten9@g.co', CAST(N'1928-08-22' AS Date), N'https://robohash.org/nobistemporaitaque.jpg?size=50x50&set=set1', 2)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (11, N'Prentice', N'Tarr', N'ptarra', N'XkGEtdVcnmw', N'ptarra@twitpic.com', CAST(N'1957-02-03' AS Date), N'https://robohash.org/inciduntreiciendismolestiae.jpg?size=50x50&set=set1', 2)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (12, N'Vassily', N'Sciusscietto', N'vsciussciettob', N'vxMaRIc', N'vsciussciettob@amazon.co.jp', CAST(N'1986-07-08' AS Date), N'https://robohash.org/sedreiciendisquasi.jpg?size=50x50&set=set1', 1)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (13, N'Dicky', N'Ferbrache', N'dferbrachec', N'bqvm6VlKzqu', N'dferbrachec@zdnet.com', CAST(N'1986-09-24' AS Date), N'https://robohash.org/utdolorest.jpg?size=50x50&set=set1', 1)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (14, N'Quintana', N'Walentynowicz', N'qwalentynowiczd', N'h3wdrG', N'qwalentynowiczd@hibu.com', CAST(N'1920-10-14' AS Date), N'https://robohash.org/nonsedmagnam.jpg?size=50x50&set=set1', 1)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (15, N'Wolfy', N'Kix', N'wkixe', N'ML6sVKx2mTN', N'wkixe@usnews.com', CAST(N'1903-01-03' AS Date), N'https://robohash.org/veritatisipsamin.jpg?size=50x50&set=set1', 2)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (16, N'Bennett', N'Butting', N'bbuttingf', N'ph9V7d82YH0', N'bbuttingf@tamu.edu', CAST(N'1949-05-17' AS Date), N'https://robohash.org/enimvoluptatibusexercitationem.jpg?size=50x50&set=set1', 2)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (17, N'Maurise', N'Desborough', N'mdesboroughg', N'cEdfTNMI1J', N'mdesboroughg@cam.ac.uk', CAST(N'1933-02-14' AS Date), N'https://robohash.org/eumconsequaturfacere.jpg?size=50x50&set=set1', 2)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (18, N'Adlai', N'Muschette', N'amuschetteh', N'fRuha0JYejh', N'amuschetteh@bbb.org', CAST(N'1988-03-23' AS Date), N'https://robohash.org/rerumquidolores.jpg?size=50x50&set=set1', 2)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (19, N'Paul', N'Delaney', N'pdelaneyi', N'ZfCHZTX', N'pdelaneyi@wunderground.com', CAST(N'2005-05-20' AS Date), N'https://robohash.org/rerumsequiquaerat.jpg?size=50x50&set=set1', 2)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (20, N'Kynthia', N'Fulep', N'kfulepj', N'w2lze9XVpHVJ', N'kfulepj@vk.com', CAST(N'2002-10-07' AS Date), N'https://robohash.org/temporibusetquae.jpg?size=50x50&set=set1', 1)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (21, N'Norrie', N'Garcia', N'ngarciak', N'mIjJ8HR3', N'ngarciak@vinaora.com', CAST(N'1943-02-17' AS Date), N'https://robohash.org/voluptatesdoloreum.jpg?size=50x50&set=set1', 2)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (22, N'Filbert', N'Caston', N'fcastonl', N'VeDHg9Km3', N'fcastonl@cnet.com', CAST(N'2006-09-27' AS Date), N'https://robohash.org/eumreprehenderitenim.jpg?size=50x50&set=set1', 2)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (23, N'Elmo', N'Gally', N'egallym', N'1OWFAnhWFSJw', N'egallym@google.com.br', CAST(N'1908-07-18' AS Date), N'https://robohash.org/consequaturautdolor.jpg?size=50x50&set=set1', 1)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (24, N'Britt', N'Darrigoe', N'bdarrigoen', N'HkBNJpyKbCeg', N'bdarrigoen@eepurl.com', CAST(N'1932-03-09' AS Date), N'https://robohash.org/autemeumqui.jpg?size=50x50&set=set1', 2)
INSERT [dbo].[Users] ([Identifier], [Firstname], [Lastname], [Username], [Password], [Email], [BirthDate], [Avatar], [IdentifierGender]) VALUES (25, N'Riobard', N'Carles', N'rcarleso', N'k8pPb8liGMD', N'rcarleso@intel.com', CAST(N'1955-06-14' AS Date), N'https://robohash.org/corporismaximedolor.jpg?size=50x50&set=set1', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
/****** Object:  Index [PK_Gender]    Script Date: 03/12/2020 18:06:13 ******/
ALTER TABLE [dbo].[Gender] ADD  CONSTRAINT [PK_Gender] UNIQUE NONCLUSTERED 
(
	[Identifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [FK_Users]    Script Date: 03/12/2020 18:06:13 ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [FK_Users] UNIQUE NONCLUSTERED 
(
	[Identifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Apply]  WITH CHECK ADD  CONSTRAINT [FK_Apply_Users] FOREIGN KEY([IdentifierUsers])
REFERENCES [dbo].[Users] ([Identifier])
GO
ALTER TABLE [dbo].[Apply] CHECK CONSTRAINT [FK_Apply_Users]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Gender] FOREIGN KEY([IdentifierGender])
REFERENCES [dbo].[Gender] ([Identifier])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Gender]
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD  CONSTRAINT [FK_Job_JobType] FOREIGN KEY([IdentifierJobType])
REFERENCES [dbo].[JobType] ([Identifier])
GO
ALTER TABLE [dbo].[Job] CHECK CONSTRAINT [FK_Job_JobType]
GO
ALTER TABLE [dbo].[Offer]  WITH CHECK ADD  CONSTRAINT [FK_Offer_Apply] FOREIGN KEY([Identifier])
REFERENCES [dbo].[Apply] ([IdentifierOffer])
GO
ALTER TABLE [dbo].[Offer] CHECK CONSTRAINT [FK_Offer_Apply]
GO
ALTER TABLE [dbo].[Offer]  WITH CHECK ADD  CONSTRAINT [FK_Offer_Category] FOREIGN KEY([IdentifierCategory])
REFERENCES [dbo].[Category] ([Identifier])
GO
ALTER TABLE [dbo].[Offer] CHECK CONSTRAINT [FK_Offer_Category]
GO
ALTER TABLE [dbo].[Offer]  WITH CHECK ADD  CONSTRAINT [FK_Offer_ContractType] FOREIGN KEY([IdentifierContractType])
REFERENCES [dbo].[ContractType] ([Identifier])
GO
ALTER TABLE [dbo].[Offer] CHECK CONSTRAINT [FK_Offer_ContractType]
GO
ALTER TABLE [dbo].[Offer]  WITH CHECK ADD  CONSTRAINT [FK_Offer_Filtre] FOREIGN KEY([IdentifierFilters])
REFERENCES [dbo].[Filtre] ([Identifier])
GO
ALTER TABLE [dbo].[Offer] CHECK CONSTRAINT [FK_Offer_Filtre]
GO
ALTER TABLE [dbo].[Offer]  WITH CHECK ADD  CONSTRAINT [FK_Offer_Job] FOREIGN KEY([IdentifierJob])
REFERENCES [dbo].[Job] ([Identifier])
GO
ALTER TABLE [dbo].[Offer] CHECK CONSTRAINT [FK_Offer_Job]
GO
ALTER TABLE [dbo].[Offer]  WITH CHECK ADD  CONSTRAINT [FK_Offer_Producer] FOREIGN KEY([IdentifierProducer])
REFERENCES [dbo].[Producer] ([Identifier])
GO
ALTER TABLE [dbo].[Offer] CHECK CONSTRAINT [FK_Offer_Producer]
GO
ALTER TABLE [dbo].[Producer]  WITH CHECK ADD  CONSTRAINT [FK_Producer_Pack] FOREIGN KEY([IdentifierPack])
REFERENCES [dbo].[Pack] ([Identifier])
GO
ALTER TABLE [dbo].[Producer] CHECK CONSTRAINT [FK_Producer_Pack]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Gender] FOREIGN KEY([IdentifierGender])
REFERENCES [dbo].[Gender] ([Identifier])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Gender]
GO
USE [master]
GO
ALTER DATABASE [MegaCastings] SET  READ_WRITE 
GO
