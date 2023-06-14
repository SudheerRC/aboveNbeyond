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
INSERT [dbo].[Vendor] ([vendorID], [vendorName], [departmentName], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (1, 'coke beverages', 'soda', '65-South Street', 'Greenland', 'South Carolina', '30824', 'United States', '6541239877')
INSERT [dbo].[Vendor] ([vendorID], [vendorName], [departmentName], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (2, 'Mikes beverages', 'beer', '24-Town Hills', 'Brewman', 'Georgia', '30115', 'United States', '9987654321')
INSERT [dbo].[Vendor] ([vendorID], [vendorName], [departmentName], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (3, 'cigarette', 'tobacco', '2564-Brewman Road', 'Douglasville', 'Georgia', '30455', 'United States', '9874561234')
INSERT [dbo].[Vendor] ([vendorID], [vendorName], [departmentName], [streetAddress], [city], [state], [zipCode], [country], [phoneNumber]) VALUES (4, 'candy limited', 'chocolates', '65-South Street', 'Greenland', 'South Carolina', '30824', 'United States', '6541239877')
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
INSERT [dbo].[Stores] ([storeID], [ownerID], [streetAddress], [city], [state], [zipCode], [country]) VALUES (1, 1, '564-skyline view', 'Carrollton', 'Georgia', '30118', 'United States')
INSERT [dbo].[Stores] ([storeID], [ownerID], [streetAddress], [city], [state], [zipCode], [country]) VALUES (2, 2, '45-Old school road', 'Newnan', 'Georgia', '30112', 'United States')
SET IDENTITY_INSERT [dbo].[Stores] OFF

SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Inventory] ON
INSERT [dbo].[Inventory] ([inventoryID], [vendorID], [productID], [storeID], [purchasePrice], [sellingPrice], [quantity]) VALUES (1, 1, 2, 1, 2.29, 2.59, 120)
INSERT [dbo].[Inventory] ([inventoryID], [vendorID], [productID], [storeID], [purchasePrice], [sellingPrice], [quantity]) VALUES (2, 1, 4, 1, 2.29, 2.59, 80)
INSERT [dbo].[Inventory] ([inventoryID], [vendorID], [productID], [storeID], [purchasePrice], [sellingPrice], [quantity]) VALUES (3, 2, 5, 2, 1.99, 2.29, 100)
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