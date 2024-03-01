CREATE PROCEDURE [dbo].[uspRemoveCar]
    @CarID INT
AS
BEGIN
    DELETE FROM [dbo].[CarTable]
    WHERE [CarID] = @CarID;
END;
