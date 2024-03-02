CREATE PROCEDURE [dbo].[uspAdjustProductDetail]
    @productid INT,
    @productname NVARCHAR(255) = NULL, -- Optional parameters: use NULL as default to skip update if not provided
    @price DECIMAL(13,2) = NULL,
    @PriceUnit NVARCHAR(50) = NULL,
    @StockUnit NVARCHAR(50) = NULL
AS
BEGIN
    UPDATE [dbo].[MainStoreTB]
    SET [productname] = ISNULL(@productname, [productname]),
        [price] = ISNULL(@price, [price]),
        [PriceUnit] = ISNULL(@PriceUnit, [PriceUnit]),
        [StockUnit] = ISNULL(@StockUnit, [StockUnit])
    WHERE [productid] = @productid;
END;
