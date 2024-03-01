CREATE PROCEDURE [dbo].[uspDecreaseStock]
    @productid INT, 
    @amount INT
AS
BEGIN
    UPDATE [dbo].[MainStoreTB]
    SET [RemainingStock] = [RemainingStock] - @amount
    WHERE [productid] = @productid;
END;
