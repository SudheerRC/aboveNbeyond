USE DATABASE "MyStores"
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON
INSERT [dbo].[Product] ([productID], [productName], [productSize], [description], [departmentName], [barcode], [sellingPrice]) VALUES (1, 'Coca-cola classic', '20oz', 'classic flavoured soft drink for all kinds of people', 'soda', '049000000443', 2.29)
INSERT [dbo].[Product] ([productID], [productName], [productSize], [description], [departmentName], [barcode], [sellingPrice]) VALUES (2, 'Coca-cola vanilla', '24oz', 'cherry falvoured soft drink for all kinds of people', 'soda', '049000018011', 2.69)
INSERT [dbo].[Product] ([productID], [productName], [productSize], [description], [departmentName], [barcode], [sellingPrice]) VALUES (3, 'Coca-Cola Zero Sugar', '20oz', 'zero sugar classic flavoured soft drink for all kinds of people', 'soda', '000032000177', 2.29)
INSERT [dbo].[Product] ([productID], [productName], [productSize], [description], [departmentName], [barcode], [sellingPrice]) VALUES (4, 'Pepsi Cola ', '20oz', 'classic flavoured soft drink for all kinds of people', 'soda', '012000001291', 2.29)
INSERT [dbo].[Product] ([productID], [productName], [productSize], [description], [departmentName], [barcode], [sellingPrice]) VALUES (5, 'Michelob Superior', '16oz', 'Alcohol for adults only 21 years old', 'beer', '018200200113', 1.99)
INSERT [dbo].[Product] ([productID], [productName], [productSize], [description], [departmentName], [barcode], [sellingPrice]) VALUES (6, 'modelo 6pack', '12oz', 'Alcohol for adults only 21 years old', 'beer', '033544002094', 7.99)
INSERT [dbo].[Product] ([productID], [productName], [productSize], [description], [departmentName], [barcode], [sellingPrice]) VALUES (7, 'Newport', '20', 'Smoking kills only for adults', 'Tobacco', '026100005738', 8.22)
INSERT [dbo].[Product] ([productID], [productName], [productSize], [description], [departmentName], [barcode], [sellingPrice]) VALUES (8, 'Marlboro Menthol Smooth', '20', 'Smoking kills only for adults', 'Tobacco', '028200003034', 6.72)
INSERT [dbo].[Product] ([productID], [productName], [productSize], [description], [departmentName], [barcode], [sellingPrice]) VALUES (9, 'Marlboro 72S', '20', 'Smoking kills only for adults', 'Tobacco', '028200009630', 6.22)
INSERT [dbo].[Product] ([productID], [productName], [productSize], [description], [departmentName], [barcode], [sellingPrice]) VALUES (10, 'Zero Candy Bar King Size', '3.4oz', 'Chocolates for all kinds of people', 'Candy', '010700804273', 2.59)
INSERT [dbo].[Product] ([productID], [productName], [productSize], [description], [departmentName], [barcode], [sellingPrice]) VALUES (11, 'Reeses Pieces Peanut Butter Candy', '1.53oz', 'Chocolates for all kinds of people', 'Candy', '034000002481', 1.59)
SET IDENTITY_INSERT [dbo].[Product] OFF

SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Vendor] ON
INSERT [dbo].[Vendor] ([vendorID], [vendorName], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (1, 'coke beverages', '65-South Street', 'Greenland', 'South Carolina', '30824', 'United States', '6541239877')
INSERT [dbo].[Vendor] ([vendorID], [vendorName], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (2, 'Mikes beverages', '24-Town Hills', 'Brewman', 'Georgia', '30115', 'United States', '9987654321')
INSERT [dbo].[Vendor] ([vendorID], [vendorName], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (3, 'cigarette', '2564-Brewman Road', 'Douglasville', 'Georgia', '30455', 'United States', '9874561234')
INSERT [dbo].[Vendor] ([vendorID], [vendorName], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (4, 'candy limited', '65-South Street', 'Greenland', 'South Carolina', '30824', 'United States', '6541239877')
SET IDENTITY_INSERT [dbo].[Vendor] OFF

SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[UserDetails] ON
INSERT [dbo].[UserDetails] ([userID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (1, 'Mike', 'John', '9-8-1985', 'Male', '245-Beverely Hills', 'Newnan', 'Georgia', '30117', 'United States', '1112223344')
INSERT [dbo].[UserDetails] ([userID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (2, 'Milly', 'Jane', '1-5-2001', 'Female', '245-New Hills', 'Carrollton', 'Georgia', '30119', 'United States', '1233453344')
INSERT [dbo].[UserDetails] ([userID], [firstName], [lastName], [dateOfBirth], [gender], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (3, 'Yasmin', 'Habibi', '9-2-1995', 'Female', '2564-Brewman Road', 'Douglasville', 'Georgia', '30455', 'United States', '9874561234')
SET IDENTITY_INSERT [dbo].[UserDetails] OFF

SET ANSI_PADDING OFF
GO
INSERT [dbo].[Users] ([password], [email], [userID]) VALUES ('test@123', 'test123@gmail.com', 1)
INSERT [dbo].[Users] ([password], [email], [userID]) VALUES ('user@123', 'user123@gmail.com', 2)
INSERT [dbo].[Users] ([password], [email], [userID]) VALUES ('mystores@123', 'mystores@gmail.com', 3)

SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Stores] ON
INSERT [dbo].[Stores] ([storeID], [ownerID], [storeName], [streetAddress], [city], [state], [zipCode], [country], [status]) VALUES (1, 1, 'Skyline View Shoppette', '564-skyline view', 'Carrollton', 'Georgia', '30118', 'United States', 1)
INSERT [dbo].[Stores] ([storeID], [ownerID], [storeName], [streetAddress], [city], [state], [zipCode], [country], [status]) VALUES (2, 2, 'School road Store', '45-Old school road', 'Newnan', 'Georgia', '30112', 'United States', 1)
SET IDENTITY_INSERT [dbo].[Stores] OFF

SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Inventory] ON
INSERT [dbo].[Inventory] ([inventoryID], [vendorID], [productID], [storeID], [purchasePrice], [sellingPrice], [quantity], [defaultQuantity]) VALUES (1, 1, 2, 1, 2.29, 2.59, 120, 200)
INSERT [dbo].[Inventory] ([inventoryID], [vendorID], [productID], [storeID], [purchasePrice], [sellingPrice], [quantity], [defaultQuantity]) VALUES (2, 1, 4, 1, 2.29, 2.59, 80, 150)
INSERT [dbo].[Inventory] ([inventoryID], [vendorID], [productID], [storeID], [purchasePrice], [sellingPrice], [quantity], [defaultQuantity]) VALUES (3, 2, 5, 2, 1.99, 2.29, 100, 200)
SET IDENTITY_INSERT [dbo].[Inventory] OFF

SET ANSI_PADDING OFF
GO
INSERT [dbo].[StoreVendors] ([vendorID], [storeID]) VALUES (1, 1)
INSERT [dbo].[StoreVendors] ([vendorID], [storeID]) VALUES (2, 2)
INSERT [dbo].[StoreVendors] ([vendorID], [storeID]) VALUES (3, 2)
INSERT [dbo].[StoreVendors] ([vendorID], [storeID]) VALUES (4, 2)
INSERT [dbo].[StoreVendors] ([vendorID], [storeID]) VALUES (4, 1)
INSERT [dbo].[StoreVendors] ([vendorID], [storeID]) VALUES (3, 1)
INSERT [dbo].[StoreVendors] ([vendorID], [storeID]) VALUES (2, 1)

SET ANSI_PADDING OFF
GO
INSERT [dbo].[StoreManagers] ([storeID], [managerID]) VALUES (1, 1)
INSERT [dbo].[StoreManagers] ([storeID], [managerID]) VALUES (2, 1)

SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Sales] ON
INSERT [dbo].[Sales] ([saleID], [saleDateTime], [storeID], [total], [tax], [paymentType]) VALUES (1, '2023-07-15 13:23:44', 1, 106.46, 6.96, 'cash')
INSERT [dbo].[Sales] ([saleID], [saleDateTime], [storeID], [total], [tax], [paymentType]) VALUES (2, '2023-07-14 10:23:44', 1, 47.24, 3.09, 'card')
INSERT [dbo].[Sales] ([saleID], [saleDateTime], [storeID], [total], [tax], [paymentType]) VALUES (3, '2023-07-8 10:23:44', 1, 28.83, 1.88, 'card')
INSERT [dbo].[Sales] ([saleID], [saleDateTime], [storeID], [total], [tax], [paymentType]) VALUES (4, '2023-07-8 8:23:44', 1, 37.8, 2.47, 'card')
INSERT [dbo].[Sales] ([saleID], [saleDateTime], [storeID], [total], [tax], [paymentType]) VALUES (5, '2023-06-15 7:23:44', 1, 57.9, 4.05, 'cash')
INSERT [dbo].[Sales] ([saleID], [saleDateTime], [storeID], [total], [tax], [paymentType]) VALUES (6, '2023-06-11 7:15:44', 1, 36.15, 2.53, 'cash')
INSERT [dbo].[Sales] ([saleID], [saleDateTime], [storeID], [total], [tax], [paymentType]) VALUES (7, '2023-05-26 7:15:44', 1, 110.33, 7.21, 'card')
INSERT [dbo].[Sales] ([saleID], [saleDateTime], [storeID], [total], [tax], [paymentType]) VALUES (8, '2023-05-16 7:15:44', 1, 115.96, 7.58, 'card')
INSERT [dbo].[Sales] ([saleID], [saleDateTime], [storeID], [total], [tax], [paymentType]) VALUES (9, '2023-04-20 16:23:44', 1, 47.24, 3.09, 'cash')
INSERT [dbo].[Sales] ([saleID], [saleDateTime], [storeID], [total], [tax], [paymentType]) VALUES (10, '2023-04-6 8:23:44', 1, 18.04, 1.18, 'cash')
SET IDENTITY_INSERT [dbo].[Sales] OFF
  
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[SaleLineItem] ON
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity], [discount]) VALUES (1, 1, 4, 1.29)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity]) VALUES (1, 2, 3)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity]) VALUES (1, 9, 2)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity], [discount]) VALUES (1, 16, 4, 1.59)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity], [discount]) VALUES (2, 1, 4, 1.29)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity]) VALUES (2, 9, 3)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity]) VALUES (2, 16, 2)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity], [discount]) VALUES (3, 1, 4, 1.29)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity]) VALUES (3, 2, 3)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity], [discount]) VALUES (4, 1, 4, 1.29)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity]) VALUES (4, 2, 2)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity]) VALUES (4, 9, 5)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity], [discount]) VALUES (5, 1, 4, 1.29)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity]) VALUES (5, 2, 3)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity]) VALUES (5, 9, 2)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity], [discount]) VALUES (6, 2, 4, 1.29)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity]) VALUES (6, 15, 3)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity]) VALUES (6, 9, 2)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity], [discount]) VALUES (7, 2, 4, 1.29)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity], [discount]) VALUES (7, 16, 5, 1.59)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity]) VALUES (7, 9, 5)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity], [discount]) VALUES (8, 1, 5, 1.29)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity]) VALUES (8, 2, 4)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity]) VALUES (8, 9, 2)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity], [discount]) VALUES (8, 16, 4, 1.59)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity], [discount]) VALUES (9, 1, 4, 1.29)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity]) VALUES (9, 9, 3)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity]) VALUES (9, 16, 2)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity], [discount]) VALUES (10, 1, 5, 1.29)
INSERT [dbo].[SaleLineItem] ([saleID], [inventoryID], [quantity]) VALUES (10, 2, 4)
SET IDENTITY_INSERT [dbo].[SaleLineItem] OFF
