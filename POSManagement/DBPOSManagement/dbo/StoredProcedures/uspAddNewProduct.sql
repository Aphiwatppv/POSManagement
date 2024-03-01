CREATE PROCEDURE [dbo].[uspAddNewProduct]
    @productid INT,
    @productname NVARCHAR(255),
    @price DECIMAL(13,2),
    @unit_unit NVARCHAR(50),
    @RemainingStock INT,
    @StockUnit NVARCHAR(50)
AS
BEGIN
    -- Insert the new product into the MainStoreTB table
    INSERT INTO [dbo].[MainStoreTB] ([productid], [productname], [price], [unit_unit], [RemainingStock], [StockUnit])
    VALUES (@productid, @productname, @price, @unit_unit, @RemainingStock, @StockUnit);
END;