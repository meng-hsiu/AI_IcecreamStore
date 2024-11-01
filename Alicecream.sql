USE [master]
GO
/****** Object:  Database [AIicecreamDB]    Script Date: 2024/9/4 下午 10:10:10 ******/
CREATE DATABASE [AIicecreamDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AIicecreamDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AIicecreamDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AIicecreamDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AIicecreamDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [AIicecreamDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AIicecreamDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AIicecreamDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AIicecreamDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AIicecreamDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AIicecreamDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AIicecreamDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [AIicecreamDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AIicecreamDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AIicecreamDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AIicecreamDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AIicecreamDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AIicecreamDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AIicecreamDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AIicecreamDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AIicecreamDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AIicecreamDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AIicecreamDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AIicecreamDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AIicecreamDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AIicecreamDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AIicecreamDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AIicecreamDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AIicecreamDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AIicecreamDB] SET RECOVERY FULL 
GO
ALTER DATABASE [AIicecreamDB] SET  MULTI_USER 
GO
ALTER DATABASE [AIicecreamDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AIicecreamDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AIicecreamDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AIicecreamDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AIicecreamDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AIicecreamDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AIicecreamDB', N'ON'
GO
ALTER DATABASE [AIicecreamDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [AIicecreamDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [AIicecreamDB]
GO
/****** Object:  Table [dbo].[orderdetails]    Script Date: 2024/9/4 下午 10:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderdetails](
	[orderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[orderID] [int] NULL,
	[productID] [int] NULL,
	[quantity] [int] NULL,
	[unitprice] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 2024/9/4 下午 10:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[orderid] [int] IDENTITY(1,1) NOT NULL,
	[personid] [int] NULL,
	[orderprice] [int] NULL,
	[ordertime] [datetime] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[orderid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[persons]    Script Date: 2024/9/4 下午 10:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persons](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NULL,
	[account] [varchar](100) NULL,
	[password] [varchar](100) NULL,
	[email] [varchar](100) NULL,
	[birthday] [date] NULL,
	[role] [int] NULL,
	[state] [int] NULL,
 CONSTRAINT [PK_persons] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 2024/9/4 下午 10:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pname] [varchar](100) NULL,
	[price] [int] NULL,
	[pdesc] [varchar](500) NULL,
	[pimage] [varchar](100) NULL,
	[type] [varchar](50) NULL,
	[state] [int] NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[staff]    Script Date: 2024/9/4 下午 10:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[staff](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NULL,
	[account] [varchar](100) NULL,
	[password] [varchar](100) NULL,
	[email] [varchar](100) NULL,
	[birthday] [date] NULL,
	[role] [int] NULL,
	[state] [int] NULL,
 CONSTRAINT [PK_staff] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[orderdetails] ON 

INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (1, 1, 1, 4, 70)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (2, 1, 5, 3, 80)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (3, 2, 21, 5, 100)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (4, 2, 22, 2, 100)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (5, 2, 23, 4, 70)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (12, 3, 1, 1, 70)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (13, 3, 1, 1, 70)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (14, 3, 1, 1, 70)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (15, 3, 1, 6, 70)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (20, 5, 2, 1, 80)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (21, 5, 2, 4, 80)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (22, 5, 1, 5, 70)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (23, 5, 1, 5, 70)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (24, 5, 5, 1, 80)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (25, 5, 5, 2, 80)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (26, 6, 14, 8, 150)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (27, 6, 7, 8, 30)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (54, 8, 1, 2, 70)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (55, 8, 2, 2, 80)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (56, 8, 22, 3, 100)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (57, 8, 23, 3, 70)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (58, 8, 24, 2, 100)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (59, 8, 21, 1, 100)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (60, 8, 21, 1, 100)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (61, 8, 21, 1, 100)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (62, 8, 21, 3, 100)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (63, 9, 1, 1, 70)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (6, 2, 24, 3, 100)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (7, 2, 24, 3, 100)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (8, 2, 25, 1, 60)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (9, 2, 25, 1, 60)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (10, 2, 7, 1, 30)
INSERT [dbo].[orderdetails] ([orderDetailID], [orderID], [productID], [quantity], [unitprice]) VALUES (11, 2, 7, 1, 30)
SET IDENTITY_INSERT [dbo].[orderdetails] OFF
GO
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([orderid], [personid], [orderprice], [ordertime]) VALUES (1, 1, 520, CAST(N'2024-08-03T16:26:56.400' AS DateTime))
INSERT [dbo].[orders] ([orderid], [personid], [orderprice], [ordertime]) VALUES (2, 1, 1760, CAST(N'2024-08-03T21:12:11.277' AS DateTime))
INSERT [dbo].[orders] ([orderid], [personid], [orderprice], [ordertime]) VALUES (3, 1, 630, CAST(N'2024-08-06T17:14:25.737' AS DateTime))
INSERT [dbo].[orders] ([orderid], [personid], [orderprice], [ordertime]) VALUES (5, 1, 1340, CAST(N'2024-08-07T15:45:19.760' AS DateTime))
INSERT [dbo].[orders] ([orderid], [personid], [orderprice], [ordertime]) VALUES (6, 1, 1440, CAST(N'2024-08-16T23:40:01.190' AS DateTime))
INSERT [dbo].[orders] ([orderid], [personid], [orderprice], [ordertime]) VALUES (8, 2, 1610, CAST(N'2024-08-19T23:39:05.043' AS DateTime))
INSERT [dbo].[orders] ([orderid], [personid], [orderprice], [ordertime]) VALUES (9, 1, 70, CAST(N'2024-08-20T09:11:54.047' AS DateTime))
SET IDENTITY_INSERT [dbo].[orders] OFF
GO
SET IDENTITY_INSERT [dbo].[persons] ON 

INSERT [dbo].[persons] ([id], [name], [account], [password], [email], [birthday], [role], [state]) VALUES (1, N'admin', N'admin', N'admin', N'admin@admin.com.tw', CAST(N'1996-01-20' AS Date), 101, 1)
INSERT [dbo].[persons] ([id], [name], [account], [password], [email], [birthday], [role], [state]) VALUES (2, N'employee', N'employee', N'employee', N'employee@employee.com', CAST(N'1996-01-21' AS Date), 101, 1)
INSERT [dbo].[persons] ([id], [name], [account], [password], [email], [birthday], [role], [state]) VALUES (3, N'customer', N'customer', N'customer', N'customer@customer.com', CAST(N'1996-01-22' AS Date), 101, 1)
INSERT [dbo].[persons] ([id], [name], [account], [password], [email], [birthday], [role], [state]) VALUES (4, N'customer2', N'customer2', N'customer2', N'customer2@custom2.com', CAST(N'1996-01-23' AS Date), 101, 1)
INSERT [dbo].[persons] ([id], [name], [account], [password], [email], [birthday], [role], [state]) VALUES (6, N'test', N'test', N'test', N'test@test.com.tw', CAST(N'2024-08-01' AS Date), 101, 1)
INSERT [dbo].[persons] ([id], [name], [account], [password], [email], [birthday], [role], [state]) VALUES (7, N'test1', N'test1', N'test', N'test@test.com.tw', CAST(N'2024-08-01' AS Date), 101, 1)
INSERT [dbo].[persons] ([id], [name], [account], [password], [email], [birthday], [role], [state]) VALUES (9, N'test2', N'test2', N'test2', N'test1@test1.com', CAST(N'2024-08-19' AS Date), 101, 1)
INSERT [dbo].[persons] ([id], [name], [account], [password], [email], [birthday], [role], [state]) VALUES (10, N'test444', N'test4', N'test4', N'test4@test4.com.tw', CAST(N'2024-08-19' AS Date), 101, 0)
SET IDENTITY_INSERT [dbo].[persons] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (1, N'香蕉冰淇淋', 70, N'來自台灣風味的香蕉冰淇淋，是這個夏天不可或缺的美味。我們精選新鮮成熟的香蕉，搭配頂級的奶油，製成口感濃郁、香味濃郁的冰淇淋。每一口都彷彿是來自熱帶果園的天然香氣，清涼中帶著濃濃的甜美，讓您感受到炎炎夏日的涼爽享受。', N'icecream (1).png', N'冰淇淋', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (2, N'蜂蜜冰淇淋', 80, N'讓蜂蜜的甜美，與冰淇淋的濃郁完美融合。我們特別挑選天然的蜂蜜，搭配上乳脂的豐富，製成這款極具台灣風味的冰淇淋。每一口都如同在花田中漫步，感受到大自然的賜予，體驗一場口感豐富的奢華享受。', N'icecream (2).png', N'冰淇淋', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (3, N'抹茶冰淇淋', 90, N'來自日本的優雅，注入台灣的熱情。我們選用上等的抹茶粉，融入口感細膩的冰淇淋中，帶給您一種濃厚的抹茶香氣，同時又不失清爽。每一口都充滿了抹茶的獨特風味，讓您仿佛置身於京都的和風庭院，感受到東方美學的深邃魅力。', N'icecream (3).png', N'冰淇淋', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (4, N'芋頭冰淇淋', 70, N'甲仙特產的芋頭，以其獨特的濃郁香氣，成為這款冰淇淋的靈魂。我們選用上等的芋頭，精心製成濃郁順口的冰淇淋，每一口都帶給您濃濃的台灣味道。無論是香甜滑順的口感，還是濃濃的芋頭香氣，都能帶給您一場來自故鄉的美味旅程。', N'icecream (4).png', N'冰淇淋', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (5, N'草莓冰淇淋', 80, N'精選新鮮成熟的草莓，打造出這款滿滿果香的冰淇淋。每一口都充滿了草莓的甜美與清新，像是在草莓園中享受果實的豐盈。口感細膩、香氣四溢，讓您在炎炎夏日中，感受到一種粉紅色的清涼誘惑。', N'icecream (5).png', N'冰淇淋', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (6, N'巧克力冰淇淋', 70, N'濃郁的巧克力口味，成就了這款絕對不容錯過的冰淇淋。我們選用高品質的可可粉，混合奶油製成口感豐富的冰淇淋，每一口都散發出濃濃的巧克力香氣。無論是巧克力愛好者，還是尋找真正純粹冰淇淋享受的您，都能在這款冰淇淋中找到滿足。', N'icecream (6).png', N'冰淇淋', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (7, N'牛奶冰棒', 30, N'
來自於新鮮牛奶的純淨，我們精心製作出這款濃郁的牛奶冰棒。每一口都帶給您濃郁、滑順的奶香味道，如同一口牛奶的清涼享受。無添加色素和防腐劑，讓您放心享用這份來自大自然的美好滋味。', N'popsicle (1).png', N'冰棒', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (8, N'蘇打冰棒', 30, N'清新的蘇打冰棒，猶如在舌尖上舞動的氣泡。我們選用上等的蘇打水，製成清爽的冰棒，每一口都帶給您微妙的氣泡感受。無論是消暑還是清新口感，都能在炎炎夏日中，為您帶來一絲涼意。', N'popsicle (2).png', N'冰棒', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (9, N'巧克力冰棒', 30, N'巧克力冰棒，絕對是巧克力愛好者的最愛。我們選用頂級可可粉，融入濃濃的奶油，每一口都充滿了誘人的巧克力香氣和口感。無論是冰涼的外表還是濃郁的內心，都能滿足您對美味的所有期待。', N'popsicle (3).png', N'冰棒', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (10, N'蜂蜜冰棒', 45, N'蜂蜜冰棒，來自於大自然的純淨甜蜜。我們選用上等的蜂蜜，製成清涼可口的冰棒，每一口都充滿了蜜糖的香甜與濃郁。無論是清爽的口感還是甜美的香氣，都能帶給您一場甜蜜的味覺旅程。', N'popsicle (4).png', N'冰棒', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (11, N'草莓冰棒', 40, N'融入了新鮮成熟的草莓風味。每一口都充滿了草莓的甜美與清新，彷彿置身於草莓園中的果實盛宴。無論是果肉的香甜還是冰涼的口感，都能在炎炎夏日中，為您帶來一絲粉紅色的清涼享受。', N'popsicle (5).png', N'冰棒', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (12, N'芒果冰棒', 40, N'源自於熱帶的豐盛。我們選用新鮮成熟的芒果，搭配上清新的冰涼口感，每一口都散發出濃濃的芒果香氣。無論是果肉的香甜還是果汁的清涼，都能為您帶來一場熱帶風情的口感盛宴。', N'popsicle (6).png', N'冰棒', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (13, N'西瓜冰棒', 35, N'將新鮮的西瓜果汁凝結成冰涼的口感。每一口都充滿了西瓜的甜美和水分，如同在西瓜田間享受清涼的果汁。無論是西瓜的爽脆還是果肉的香甜，都能在炎炎夏日中，帶給您一絲清涼和滿足。', N'popsicle (7).png', N'冰棒', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (14, N'香蕉聖代', 150, N'結合了新鮮香蕉的濃郁與冰淇淋的滑順。每一口都充滿了香蕉的甜美與奶油的濃厚，彷彿是一場來自熱帶的甜蜜盛宴。無論是香蕉的香甜還是冰淇淋的滑順，都能在炎炎夏日中，為您帶來一絲清涼和滿足。', N'sundae (1).png', N'聖代', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (15, N'焦糖聖代', 150, N'經典中的經典。我們選用上等的焦糖醬，融合奶油製成濃郁的冰淇淋，每一口都充滿了焦糖的香甜與濃厚。無論是焦糖的深邃還是冰淇淋的滑順，都能帶給您一場口感豐富的美味享受。', N'sundae (2).png', N'聖代', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (16, N'芒果聖代', 170, N'選用新鮮成熟的芒果，搭配上滑順的冰淇淋，每一口都散發出濃濃的芒果香氣。無論是果肉的香甜還是冰淇淋的滑順，都能為您帶來一場熱帶風情的口感盛宴。', N'sundae (3).png', N'聖代', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (17, N'薄荷巧克力聖代', 150, N'結合了清新的薄荷和濃郁的巧克力。我們選用頂級的可可粉，融入濃濃的奶油，並添加清涼的薄荷香精，每一口都充滿了獨特的香味和口感。無論是巧克力的濃郁還是薄荷的清新，都能為您帶來一場冰涼的味蕾饗宴。', N'sundae (4).png', N'聖代', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (18, N'草莓聖代', 150, N'將新鮮成熟的草莓與濃郁的冰淇淋完美結合。每一口都充滿了草莓的甜美與奶油的滑順，彷彿在草莓園中享受果實的豐盈。無論是果肉的香甜還是冰淇淋的濃郁，都能在炎炎夏日中，為您帶來一絲粉紅色的清涼享受。', N'sundae (5).png', N'聖代', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (19, N'香草聖代', 150, N'以純淨的香草香氣融合奶油的滑順口感。每一口都帶給您清新、淡雅的香草風味，如同置身於香草田間的清涼中。無論是香草的清新還是冰淇淋的滑順，都能在炎炎夏日中，為您帶來一場清涼宜人的口感享受。', N'sundae (6).png', N'聖代', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (20, N'西瓜聖代', 160, N'將新鮮的西瓜果汁融入濃郁的冰淇淋中。每一口都充滿了西瓜的甜美與水分，彷彿在西瓜田間享受清涼的果汁。無論是西瓜的爽脆還是冰淇淋的滑順，都能在炎炎夏日中，為您帶來一絲清涼和滿足。', N'sundae (8).png', N'聖代', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (21, N'卡布奇諾', 100, N'卡布奇諾，是咖啡與奶泡的極致融合。我們選用上等的咖啡豆，以獨特的烘焙技術烘出濃郁的咖啡香氣，再加上豐富奶泡的層次感，每一口都充滿了濃濃的咖啡香與奶香。無論是早晨的一杯還是下午的伴侶，都能帶給您一份來自義大利風情的完美享受。', N'drink (1).png', N'飲料', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (22, N'可可亞', 100, N'將頂級的可可粉與滑順的奶泡完美混合。每一口都充滿了濃郁的巧克力香氣與奶香的濃郁，如同享受一口口感豐富的巧克力饗宴。無論是冬日的暖心還是夏日的清涼，都能在這杯可可亞中找到美好的味覺體驗。', N'drink (2).png', N'飲料', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (23, N'黑咖啡', 70, N'純粹的咖啡豆烘焙而成，呈現出濃郁的咖啡香氣與獨特的苦味。每一口都帶給您簡單而純粹的咖啡享受，如同一場來自咖啡田間的自然饗宴。無論是清晨的提神良品還是下午的休憩選擇，都能在這杯黑咖啡中感受到咖啡的真正魅力。', N'drink (3).png', N'飲料', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (24, N'拿鐵', 100, N'咖啡與奶泡的極致和諧。我們選用上等的咖啡豆，以獨特的烘焙技術烘出濃郁的咖啡香氣，再加上滑順的奶泡，每一口都充滿了咖啡的深邃與奶香的濃郁。無論是享受咖啡的苦甜還是奶泡的柔順，都能在這杯拿鐵中找到平衡與滿足。', N'drink (4).png', N'飲料', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (25, N'波霸奶茶', 60, N'結合了茶香、奶香與Q彈的珍珠。我們選用上等的茶葉，搭配新鮮的牛奶與彈牙的珍珠，每一口都充滿了茶香與奶香的和諧，以及珍珠帶來的口感驚喜。無論是喜愛甜美的口味還是經典的台灣風情，都能在這杯波霸奶茶中找到心靈的慰藉與享受。', N'drink (5).png', N'飲料', 1)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (29, N'測試用咖啡', 999, N'213123213312', N'2408051451131000.png', N'飲料', 0)
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage], [type], [state]) VALUES (30, N'測試用聖代', 9999, N'sdlkjsadalskjd', N'2408192346281000.png', N'聖代', 0)
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[staff] ON 

INSERT [dbo].[staff] ([id], [name], [account], [password], [email], [birthday], [role], [state]) VALUES (1, N'admin', N'admin', N'admin', N'admin@admin.com.tw1', CAST(N'1996-01-20' AS Date), 1, 1)
INSERT [dbo].[staff] ([id], [name], [account], [password], [email], [birthday], [role], [state]) VALUES (2, N'boos', N'boss', N'boss', N'boss@boss.com', CAST(N'1996-01-21' AS Date), 11, 1)
INSERT [dbo].[staff] ([id], [name], [account], [password], [email], [birthday], [role], [state]) VALUES (3, N'manager', N'manager', N'manager', N'manager@manager.com', CAST(N'1996-01-22' AS Date), 12, 1)
INSERT [dbo].[staff] ([id], [name], [account], [password], [email], [birthday], [role], [state]) VALUES (4, N'employee', N'employee', N'employee', N'employee@employee.com', CAST(N'1996-01-23' AS Date), 21, 1)
SET IDENTITY_INSERT [dbo].[staff] OFF
GO
USE [master]
GO
ALTER DATABASE [AIicecreamDB] SET  READ_WRITE 
GO
