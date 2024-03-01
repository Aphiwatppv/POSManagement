CREATE PROCEDURE [dbo].[uspAdjustTransaction]
    @IdTransaction INT,
    @ReturningStockfromCar INT
AS
BEGIN
    UPDATE [dbo].[CheckStockTB]
    SET [ReturningStockfromCar] = @ReturningStockfromCar,
        [IsReturnToStore] = CASE WHEN @ReturningStockfromCar IS NOT NULL THEN 1 ELSE [IsReturnToStore] END
    WHERE [IdTransaction] = @IdTransaction;
END;
