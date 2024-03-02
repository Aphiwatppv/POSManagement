CREATE PROCEDURE [dbo].[uspGetAllProducts]
AS
BEGIN
    SELECT [productid], [productname], [price], [PriceUnit], [RemainingStock], [StockUnit]
    FROM [dbo].[MainStoreTB];
END;
