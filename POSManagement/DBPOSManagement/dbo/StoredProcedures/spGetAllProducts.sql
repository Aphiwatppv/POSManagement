CREATE PROCEDURE [dbo].[uspGetAllProducts]
AS
BEGIN
    SELECT [productid], [productname], [price], [unit_unit], [RemainingStock], [StockUnit]
    FROM [dbo].[MainStoreTB];
END;
