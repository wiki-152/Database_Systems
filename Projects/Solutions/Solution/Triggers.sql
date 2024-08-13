--TRIGGERS
--UPDATE INVENTORY AFTER SALE
CREATE TRIGGER update_inventory_after_sales
ON TransactionItems
AFTER INSERT 
AS
BEGIN
    UPDATE InventoryItems 
    SET QuantityInStock = QuantityInStock - i.Quantity
    FROM inserted
	JOIN Products p on p.ProductID=inserted.ProductID
	JOIN Recipes r on r.RecipeID=p.RECIPEID
	JOIN Instructions i on r.RecipeID=i.RecipeID
    WHERE InventoryItems.ItemID = i.IngredientID;
END;
GO

CREATE Or alter TRIGGER update_transactionprice
ON TransactionItems
AFTER INSERT 
AS
BEGIN
    UPDATE Transactions 
    SET TotalAmount = TotalAmount + inserted.Price*inserted.Quantity
    FROM inserted
	where Transactions.TransactionID=inserted.TransactionID
END;
GO

CREATE TRIGGER check_reorder_level
ON InventoryItems
AFTER UPDATE
AS
BEGIN
  IF EXISTS (SELECT * FROM inserted WHERE QuantityInStock <= ReorderThreshold)
  BEGIN
    SELECT 'Item needs reordering: ' + ItemName FROM inserted WHERE QuantityInStock <= ReorderThreshold; 
  END;
END;
GO 

--- Create a function to check for duplicate usernames
CREATE FUNCTION CheckDuplicateUsername(@UserName NVARCHAR(MAX))
RETURNS BIT
AS
BEGIN
    DECLARE @IsDuplicate BIT = 0;

    IF EXISTS (
        SELECT 1
        FROM Customers
        WHERE UserName = @UserName
        UNION
        SELECT 1
        FROM Employees
        WHERE UserName = @UserName
        UNION
        SELECT 1
        FROM Admins
        WHERE UserName = @UserName
        UNION
        SELECT 1
        FROM DataAnalyst
        WHERE UserName = @UserName
    )
    BEGIN
        SET @IsDuplicate = 1;
    END

    RETURN @IsDuplicate;
END
GO

-- Create or alter the trigger on the Customers table
CREATE OR ALTER TRIGGER CheckDuplicateUsername12
ON Customers
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @UserName NVARCHAR(MAX);

    -- Loop through each inserted row
    SELECT @UserName = UserName
    FROM inserted

    IF dbo.CheckDuplicateUsername(@UserName) = 1
    BEGIN
        RAISERROR('Username already in use.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END
GO
CREATE OR ALTER TRIGGER CheckDuplicateUsername13
ON Employees
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @UserName NVARCHAR(MAX);

    -- Loop through each inserted row
    SELECT @UserName = UserName
    FROM inserted

    IF dbo.CheckDuplicateUsername(@UserName) = 1
    BEGIN
        RAISERROR('Username already in use.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END
GO

CREATE OR ALTER TRIGGER CheckDuplicateUsername14
ON DataAnalyst
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @UserName NVARCHAR(MAX);

    -- Loop through each inserted row
    SELECT @UserName = UserName
    FROM inserted

    IF dbo.CheckDuplicateUsername(@UserName) = 1
    BEGIN
        RAISERROR('Username already in use.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END
GO

CREATE OR ALTER TRIGGER CheckDuplicateUsername15
ON Admins
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @UserName NVARCHAR(MAX);

    -- Loop through each inserted row
    SELECT @UserName = UserName
    FROM inserted

    IF dbo.CheckDuplicateUsername(@UserName) = 1
    BEGIN
        RAISERROR('Username already in use.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END
GO