CREATE or alter PROCEDURE registerUser
    @firstName NVARCHAR(50),
    @lastName NVARCHAR(50),
    @dateOfBirth DATE,
    @gender NVARCHAR(20),
    @streetAddress NVARCHAR(50),
    @city NVARCHAR(50),
    @state NVARCHAR(50),
    @zipCode NVARCHAR(50),
    @country NVARCHAR(50),
    @phoneNumber NCHAR(10),
    @email NVARCHAR(255),
    @password NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    -- Insert new user details record
    DECLARE @userId INT;
    BEGIN TRY
    INSERT INTO UserDetails(firstName,lastName,dateOfBirth,gender,streetAddress,city,state,zipCode,country,phoneNumber) 
    VALUES (@firstName, @lastName, @dateOfBirth, @gender, @streetAddress, @city, @state, @zipCode, @country, @phoneNumber);

    -- Get the newly added @userId primary key
    SET @userId = SCOPE_IDENTITY();

    -- Insert the @userId into the Users table
    INSERT INTO Users(email, password, userID) VALUES (@email, @password, @userId);
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        RETURN;
    END CATCH;
    COMMIT TRANSACTION;
END