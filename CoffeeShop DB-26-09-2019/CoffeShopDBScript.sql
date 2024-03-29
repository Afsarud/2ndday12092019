USE [CoffeeShop]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 9/29/2019 6:52:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[Cus_ID] [int] IDENTITY(1,1) NOT NULL,
	[Customer_Name] [varchar](20) NULL,
	[Contact] [int] NULL,
	[Address] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Cus_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Item]    Script Date: 9/29/2019 6:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Item](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [varchar](20) NULL,
	[price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 9/29/2019 6:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[Cus_ID] [int] NULL,
	[ItemID] [int] NULL,
	[Queintity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Cus_ID], [Customer_Name], [Contact], [Address]) VALUES (44, N'Afsar', 234, N'sdfsdf')
INSERT [dbo].[Customer] ([Cus_ID], [Customer_Name], [Contact], [Address]) VALUES (45, N'Afsar', 234, N'sdfsdf')
INSERT [dbo].[Customer] ([Cus_ID], [Customer_Name], [Contact], [Address]) VALUES (46, N'Afsar', 234, N'sdfsdf')
INSERT [dbo].[Customer] ([Cus_ID], [Customer_Name], [Contact], [Address]) VALUES (47, N'sdad', 23, N'fsdf')
INSERT [dbo].[Customer] ([Cus_ID], [Customer_Name], [Contact], [Address]) VALUES (49, N'gdsfs', 343, N'vxcvx')
INSERT [dbo].[Customer] ([Cus_ID], [Customer_Name], [Contact], [Address]) VALUES (50, N'Afsar', 3423, N'sdfds')
INSERT [dbo].[Customer] ([Cus_ID], [Customer_Name], [Contact], [Address]) VALUES (51, N'Afsar', 32, N'dsadsd')
INSERT [dbo].[Customer] ([Cus_ID], [Customer_Name], [Contact], [Address]) VALUES (52, N'Afsar', 323, N'dsadsd')
SET IDENTITY_INSERT [dbo].[Customer] OFF
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([Cus_ID])
REFERENCES [dbo].[Customer] ([Cus_ID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([ItemID])
REFERENCES [dbo].[Item] ([ItemID])
GO
