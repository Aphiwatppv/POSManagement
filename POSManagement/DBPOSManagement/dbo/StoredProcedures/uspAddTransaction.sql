CREATE PROCEDURE [dbo].[uspAddTransaction]
    @productid INT,
    @CarID INT,
    @TakingStockfromstore INT,
    @StockUnit NVARCHAR(50),
    @Datetime DATE,
    @IdEmployee INT
AS
BEGIN
    INSERT INTO [dbo].[CheckStockTB] ([productid], [CarID], [TakingStockfromstore], [StockUnit], [IsReturnToStore], [Datetime], [IdEmployee])
    VALUES (@productid, @CarID, @TakingStockfromstore, @StockUnit, 0, @Datetime, @IdEmployee);
END;
