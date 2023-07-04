/* Check if database already exists and delete it if it does exist*/
IF EXISTS(SELECT 1 FROM master.dbo.sysdatabases WHERE name = 'MyStores') 
BEGIN
DROP DATABASE "MyStores"
END
GO

CREATE DATABASE "MyStores"
GO

USE [MyStores]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Product](
	[productID] [int] IDENTITY(1,1) NOT NULL,
	[productName] [varchar](50) NOT NULL,
	[productSize] [varchar](10),
	[description] [varchar](255),
	[departmentName] [varchar](50),
	[barcode] [varchar](20),
	[sellingPrice] [decimal](7,2),
	[productImage] [Image]
	
 CONSTRAINT [PK_Product] PRIMARY KEY 
(
	[productID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Vendor](
	[vendorID] [int] IDENTITY(1,1) NOT NULL,
	[vendorName] [varchar](50) NOT NULL,
	[streetAddress] [varchar](50),
	[city] [varchar](50),
	[state] [varchar](50),
	[zipCode] [varchar](50),
	[country] [varchar](50),
	[phoneNumber] [char](10),

 CONSTRAINT [PK_Vendor] PRIMARY KEY 
(
	[vendorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[UserDetails](
	[userID] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[dateOfBirth] [date],
	[gender] [varchar](20),
	[streetAddress] [varchar](50),
	[city] [varchar](50),
	[state] [varchar](50),
	[zipCode] [varchar](50),
	[country] [varchar](50),
	[phoneNumber] [char](10),

 CONSTRAINT [PK_UserDetails] PRIMARY KEY 
(
	[userID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Users](
	[password] [varchar](50) NOT NULL,
	[email] [varchar](255) NOT NULL,
	[userID] [int] NOT NULL REFERENCES UserDetails(userID),
 CONSTRAINT [PK_Users] PRIMARY KEY 
(
	[email] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Stores](
	[storeID] [int] IDENTITY(1,1) NOT NULL,
	[ownerID] [int] NOT NULL REFERENCES UserDetails(userID),
	[storeName] [varchar](50),
	[streetAddress] [varchar](50),
	[city] [varchar](50),
	[state] [varchar](50),
	[zipCode] [varchar](50),
	[country] [varchar](50),
	
 CONSTRAINT [PK_Stores] PRIMARY KEY 
(
	[storeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Inventory](
	[inventoryID] [int] IDENTITY(1,1) NOT NULL,
	[vendorID] [int] NOT NULL REFERENCES Vendor(vendorID),
	[productID] [int] NOT NULL REFERENCES Product(productID),
	[storeID] [int] NOT NULL REFERENCES Stores(storeID),
	[purchasePrice] [decimal](7,2),
	[sellingPrice] [decimal](7,2),
	[quantity] [int],
	
 CONSTRAINT [PK_Inventory] PRIMARY KEY 
(
	[inventoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[StoreVendors](
	[vendorID] [int] NOT NULL REFERENCES Vendor(vendorID),
	[storeID] [int] NOT NULL REFERENCES Stores(storeID),
 CONSTRAINT [PK_StoreVendors] PRIMARY KEY 
(
	[storeID] ASC,
	[vendorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[StoreManagers](
	[storeID] [int] NOT NULL REFERENCES Stores(storeID),
	[managerID] [int] NOT NULL REFERENCES UserDetails(userID),
 CONSTRAINT [PK_StoreManagers] PRIMARY KEY 
(
	[storeID] ASC,
	[managerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[OrderDetails](
	[orderID] [int] IDENTITY(1,1) NOT NULL,
	[orderDate] [date],
	[expectedDeliveryDate] [date],
	[deliveredDate] [date],
	[userID] [int] NOT NULL REFERENCES UserDetails(userID),
	[vendorID] [int] NOT NULL REFERENCES Vendor(vendorID),
	[storeID] [int] NOT NULL REFERENCES Stores(storeID)
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY 
(
	[orderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Orders](
	[orderID] [int] NOT NULL REFERENCES OrderDetails(orderID),
	[inventoryID] [int] NOT NULL REFERENCES Inventory(inventoryID),
	[purchasePrice] [decimal](7,2),
	[quantity] [int],
 CONSTRAINT [PK_Orders] PRIMARY KEY 
(
	[orderID] ASC,
	[inventoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
