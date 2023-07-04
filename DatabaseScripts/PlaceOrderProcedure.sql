CREATE PROCEDURE placeOrder
	@orderDate DATE,
	@expectedDate DATE,
	@userId INT,
	@vendorId INT,
	@storeId INT,
	@orderId INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO OrderDetails(orderDate, expectedDeliveryDate, userID, vendorID, storeID) 
    VALUES (@orderDate, @expectedDate, @userId, @vendorId, @storeId);

    -- Get the newly added @userId primary key
    SET @orderID = SCOPE_IDENTITY();
END