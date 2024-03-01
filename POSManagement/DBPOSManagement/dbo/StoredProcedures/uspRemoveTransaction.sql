CREATE PROCEDURE [dbo].[uspRemoveTransaction]
    @IdTransaction INT
AS
BEGIN
    -- Optionally, check if the transaction exists before attempting to delete
    IF EXISTS (SELECT 1 FROM [dbo].[CheckStockTB] WHERE [IdTransaction] = @IdTransaction)
    BEGIN
        DELETE FROM [dbo].[CheckStockTB]
        WHERE [IdTransaction] = @IdTransaction;
    END
    ELSE
    BEGIN
        -- Handle the case where the transaction does not exist
        -- For example, you might want to raise an error or return a status indicating the transaction was not found
        RAISERROR ('Transaction not found', 16, 1);
    END
END;
