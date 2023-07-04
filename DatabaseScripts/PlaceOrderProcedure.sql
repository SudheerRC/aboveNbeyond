CREATE or alter PROCEDURE placeOrder
	@inventoryID INT,
	@orderDate DATE,
	@expectedDate DATE,
	@userId INT,
	@purchasePrice DECIMAL,
	@quantity INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    -- Insert new Order details record
    DECLARE @orderID INT;

    BEGIN TRY
    INSERT INTO OrderDetails(orderDate, expectedDeliveryDate, userID) 
    VALUES (@orderDate, @expectedDate, @userId);

    -- Get the newly added @userId primary key
    SET @orderID = SCOPE_IDENTITY();

    -- Insert the @orderID into the Orders table
    INSERT INTO Orders(orderID, inventoryID, purchasePrice, quantity) 
    VALUES (@orderID, @inventoryID, @purchasePrice, @quantity);
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RETURN;
    END CATCH;
    COMMIT TRANSACTION;
END