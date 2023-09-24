USE [MyDBMS]
GO
/****** Object:  Table [dbo].[Booth]    Script Date: 2022/6/10 下午 02:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booth](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[LineId] [nvarchar](50) NULL,
 CONSTRAINT [PK_Booth] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 2022/6/10 下午 02:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[LineId] [nvarchar](50) NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2022/6/10 下午 02:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[UnitPrice] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesOrder]    Script Date: 2022/6/10 下午 02:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesOrder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BoothId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[StaffId] [int] NOT NULL,
	[DeliveryPhone] [varchar](20) NOT NULL,
 CONSTRAINT [PK_DeliveryNote] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesOrderDetail]    Script Date: 2022/6/10 下午 02:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesOrderDetail](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UnitPrice] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 2022/6/10 下午 02:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
	[IsDriver] [bit] NOT NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Booth] ON 
GO
INSERT [dbo].[Booth] ([Id], [Name], [Phone], [LineId]) VALUES (1, N'陳品廷', N'0912345564', N'abcqqq')
GO
INSERT [dbo].[Booth] ([Id], [Name], [Phone], [LineId]) VALUES (2, N'王新一', N'0999875542', N'google9898')
GO
INSERT [dbo].[Booth] ([Id], [Name], [Phone], [LineId]) VALUES (3, N'林志玲', N'0987654321', N'goapPopo')
GO
INSERT [dbo].[Booth] ([Id], [Name], [Phone], [LineId]) VALUES (4, N'陳姿號', N'0945543218', N'howfun333')
GO
INSERT [dbo].[Booth] ([Id], [Name], [Phone], [LineId]) VALUES (5, N'鄧叉子', N'0932651222', N'whereisfork')
GO
INSERT [dbo].[Booth] ([Id], [Name], [Phone], [LineId]) VALUES (6, N'徐小明', N'0912547777', N'lilasikuta')
GO
INSERT [dbo].[Booth] ([Id], [Name], [Phone], [LineId]) VALUES (7, N'陳老王', N'0956785452', N'chen8857')
GO
INSERT [dbo].[Booth] ([Id], [Name], [Phone], [LineId]) VALUES (8, N'周接倫', N'0955998877', N'aliliop')
GO
INSERT [dbo].[Booth] ([Id], [Name], [Phone], [LineId]) VALUES (9, N'周湯好', N'0911223344', N'yoa77quko')
GO
INSERT [dbo].[Booth] ([Id], [Name], [Phone], [LineId]) VALUES (10, N'楊坤明', N'0915688977', N'wwwnaruto')
GO
SET IDENTITY_INSERT [dbo].[Booth] OFF
GO
SET IDENTITY_INSERT [dbo].[Member] ON 
GO
INSERT [dbo].[Member] ([Id], [Name], [Phone], [LineId]) VALUES (1, N'楊皓如', N'0955642312', N'yaumfa777')
GO
INSERT [dbo].[Member] ([Id], [Name], [Phone], [LineId]) VALUES (2, N'林宣', N'0998474111', N'lin000')
GO
INSERT [dbo].[Member] ([Id], [Name], [Phone], [LineId]) VALUES (3, N'金明儒', N'0912345785', N'gold88888')
GO
INSERT [dbo].[Member] ([Id], [Name], [Phone], [LineId]) VALUES (4, N'盧廣中', N'0966454421', N'g0966454421')
GO
INSERT [dbo].[Member] ([Id], [Name], [Phone], [LineId]) VALUES (5, N'陳怡伶', N'0944215478', N'chen10')
GO
INSERT [dbo].[Member] ([Id], [Name], [Phone], [LineId]) VALUES (6, N'王一一', N'0913256841', N'wang11')
GO
INSERT [dbo].[Member] ([Id], [Name], [Phone], [LineId]) VALUES (7, N'許甲乙', N'0989765123', N'shuAB')
GO
INSERT [dbo].[Member] ([Id], [Name], [Phone], [LineId]) VALUES (8, N'陳大茲', N'0915328155', N'ascioss56')
GO
INSERT [dbo].[Member] ([Id], [Name], [Phone], [LineId]) VALUES (9, N'徐若瑄', N'0946512348', N'yuiyu889')
GO
INSERT [dbo].[Member] ([Id], [Name], [Phone], [LineId]) VALUES (10, N'王心寧', N'0989615325', N'yunyunlin')
GO
INSERT [dbo].[Member] ([Id], [Name], [Phone], [LineId]) VALUES (11, N'蔡瓜吉', N'0910101114', N'gaugua')
GO
INSERT [dbo].[Member] ([Id], [Name], [Phone], [LineId]) VALUES (12, N'蔡宗翰', N'0911123555', N'chunsa5512')
GO
INSERT [dbo].[Member] ([Id], [Name], [Phone], [LineId]) VALUES (13, N'關心宜', N'0999885442', N'a0999885442')
GO
INSERT [dbo].[Member] ([Id], [Name], [Phone], [LineId]) VALUES (14, N'林怡萱', N'0944223333', N'20001288lin')
GO
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (1, N'筆記本', 60)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (2, N'相框', 120)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (3, N'手帕', 30)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (4, N'橡皮擦', 20)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (5, N'手工購物袋', 150)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (6, N'明信片', 35)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (7, N'檯燈', 450)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (8, N'公仔', 1500)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (9, N'地球儀', 1200)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (10, N'鉛筆盒', 200)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (11, N'原子筆', 45)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (12, N'雨傘', 130)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (13, N'保鮮盒', 250)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (14, N'馬克杯', 200)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (15, N'胸章', 80)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (16, N'收納盒', 250)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (17, N'地圖', 150)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (18, N'印章', 50)
GO
INSERT [dbo].[Product] ([Id], [Name], [UnitPrice]) VALUES (19, N'口罩', 10)
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[SalesOrder] ON 
GO
INSERT [dbo].[SalesOrder] ([Id], [BoothId], [MemberId], [StaffId], [DeliveryPhone]) VALUES (1, 2, 1, 6, N'0912345678')
GO
INSERT [dbo].[SalesOrder] ([Id], [BoothId], [MemberId], [StaffId], [DeliveryPhone]) VALUES (2, 3, 2, 2, N'')
GO
INSERT [dbo].[SalesOrder] ([Id], [BoothId], [MemberId], [StaffId], [DeliveryPhone]) VALUES (3, 2, 4, 3, N'')
GO
INSERT [dbo].[SalesOrder] ([Id], [BoothId], [MemberId], [StaffId], [DeliveryPhone]) VALUES (4, 5, 5, 4, N'')
GO
INSERT [dbo].[SalesOrder] ([Id], [BoothId], [MemberId], [StaffId], [DeliveryPhone]) VALUES (5, 4, 8, 6, N'')
GO
INSERT [dbo].[SalesOrder] ([Id], [BoothId], [MemberId], [StaffId], [DeliveryPhone]) VALUES (6, 1, 9, 4, N'')
GO
INSERT [dbo].[SalesOrder] ([Id], [BoothId], [MemberId], [StaffId], [DeliveryPhone]) VALUES (7, 2, 10, 2, N'')
GO
INSERT [dbo].[SalesOrder] ([Id], [BoothId], [MemberId], [StaffId], [DeliveryPhone]) VALUES (8, 3, 11, 1, N'')
GO
INSERT [dbo].[SalesOrder] ([Id], [BoothId], [MemberId], [StaffId], [DeliveryPhone]) VALUES (9, 6, 12, 5, N'')
GO
INSERT [dbo].[SalesOrder] ([Id], [BoothId], [MemberId], [StaffId], [DeliveryPhone]) VALUES (10, 10, 14, 5, N'')
GO
SET IDENTITY_INSERT [dbo].[SalesOrder] OFF
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (1, 2, 120, 2)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (1, 3, 30, 1)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (2, 1, 60, 2)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (3, 1, 60, 2)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (3, 4, 20, 20)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (3, 5, 150, 1)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (3, 6, 35, 10)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (4, 2, 120, 1)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (5, 1, 60, 5)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (6, 2, 120, 3)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (6, 3, 30, 1)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (6, 5, 150, 2)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (6, 14, 200, 1)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (7, 1, 60, 3)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (7, 7, 450, 1)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (8, 1, 60, 5)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (8, 2, 120, 2)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (9, 2, 120, 1)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (9, 8, 1500, 1)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (9, 9, 1200, 1)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (9, 10, 200, 1)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (9, 11, 45, 2)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (10, 2, 120, 1)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (10, 12, 130, 1)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (10, 13, 250, 1)
GO
INSERT [dbo].[SalesOrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity]) VALUES (10, 19, 10, 20)
GO
SET IDENTITY_INSERT [dbo].[Staff] ON 
GO
INSERT [dbo].[Staff] ([Id], [Name], [Phone], [IsAdmin], [IsDriver]) VALUES (1, N'王曉明', N'0912345678', 1, 0)
GO
INSERT [dbo].[Staff] ([Id], [Name], [Phone], [IsAdmin], [IsDriver]) VALUES (2, N'陳天兵', N'0932156785', 0, 1)
GO
INSERT [dbo].[Staff] ([Id], [Name], [Phone], [IsAdmin], [IsDriver]) VALUES (3, N'林小美', N'0978456156', 0, 1)
GO
INSERT [dbo].[Staff] ([Id], [Name], [Phone], [IsAdmin], [IsDriver]) VALUES (4, N'徐品潔', N'0910235487', 1, 0)
GO
INSERT [dbo].[Staff] ([Id], [Name], [Phone], [IsAdmin], [IsDriver]) VALUES (5, N'許大民', N'0988754645', 0, 1)
GO
INSERT [dbo].[Staff] ([Id], [Name], [Phone], [IsAdmin], [IsDriver]) VALUES (6, N'陳佐助', N'0912612354', 0, 1)
GO
INSERT [dbo].[Staff] ([Id], [Name], [Phone], [IsAdmin], [IsDriver]) VALUES (7, N'林明仁', N'0951232132', 0, 1)
GO
INSERT [dbo].[Staff] ([Id], [Name], [Phone], [IsAdmin], [IsDriver]) VALUES (8, N'陳玄峰', N'0913121232', 0, 1)
GO
INSERT [dbo].[Staff] ([Id], [Name], [Phone], [IsAdmin], [IsDriver]) VALUES (9, N'黃小一', N'0915465131', 0, 1)
GO
INSERT [dbo].[Staff] ([Id], [Name], [Phone], [IsAdmin], [IsDriver]) VALUES (10, N'林熙熙', N'0946486123', 0, 1)
GO
SET IDENTITY_INSERT [dbo].[Staff] OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'流水號' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Booth', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'攤位負責人姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Booth', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'攤位負責人電話' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Booth', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'攤位負責人LineId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Booth', @level2type=N'COLUMN',@level2name=N'LineId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'流水號' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'會員姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'會員電話' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'會員LineId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member', @level2type=N'COLUMN',@level2name=N'LineId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'流水號' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'商品名稱' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'單價' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'UnitPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'流水號' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SalesOrder', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'攤位流水號' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SalesOrder', @level2type=N'COLUMN',@level2name=N'BoothId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'會員流水號' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SalesOrder', @level2type=N'COLUMN',@level2name=N'MemberId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'員工流水號' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SalesOrder', @level2type=N'COLUMN',@level2name=N'StaffId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'訂單的電話，不與其他表的Phone關聯' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SalesOrder', @level2type=N'COLUMN',@level2name=N'DeliveryPhone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'訂單流水號' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SalesOrderDetail', @level2type=N'COLUMN',@level2name=N'OrderId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'商品流水號' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SalesOrderDetail', @level2type=N'COLUMN',@level2name=N'ProductId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'訂購當下的單價，不一定與Product.UnitPrice一致' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SalesOrderDetail', @level2type=N'COLUMN',@level2name=N'UnitPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'數量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SalesOrderDetail', @level2type=N'COLUMN',@level2name=N'Quantity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'流水號' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'員工姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'員工電話' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否為主管' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'IsAdmin'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否為司機' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'IsDriver'
GO
