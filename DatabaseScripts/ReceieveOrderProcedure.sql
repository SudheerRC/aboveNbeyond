CREATE or alter PROCEDURE receiveOrder
    @newQuantity INT,
    @deliveredDate DATE,
    @orderId INT,
    @inventoryId INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;
   
    BEGIN TRY
    Update Inventory SET quantity = quantity + @newQuantity where inventoryID = @inventoryId;

    -- Update the @delivered date into the order details table
    Update OrderDetails SET deliveredDate = @deliveredDate where orderID = @orderId;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RETURN;
    END CATCH;
    COMMIT TRANSACTION;
END