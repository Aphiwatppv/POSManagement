CREATE PROCEDURE [dbo].[uspAddNewProduct]
    @productid INT,
    @productname NVARCHAR(255),
    @price DECIMAL(13,2),
    @PriceUnit NVARCHAR(50),
    @RemainingStock INT,
    @StockUnit NVARCHAR(50)
AS
BEGIN
    -- Insert the new product into the MainStoreTB table
    INSERT INTO [dbo].[MainStoreTB] ([productid], [productname], [price], [PriceUnit], [RemainingStock], [StockUnit])
    VALUES (@productid, @productname, @price, @PriceUnit, @RemainingStock, @StockUnit);
END;