CREATE PROCEDURE [dbo].[uspRemoveProduct]
    @productid INT
AS
BEGIN
    -- Optionally, you might want to check if the product exists before attempting to delete.
    IF EXISTS (SELECT 1 FROM [dbo].[MainStoreTB] WHERE [productid] = @productid)
    BEGIN
        DELETE FROM [dbo].[MainStoreTB]
        WHERE [productid] = @productid;
    END
    ELSE
    BEGIN
        -- Handle the case where the product does not exist.
        -- For example, you might want to raise an error or simply complete the procedure.
        RAISERROR ('Product not found', 16, 1);
    END
END;
