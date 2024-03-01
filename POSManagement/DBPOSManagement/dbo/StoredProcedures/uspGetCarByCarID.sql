CREATE PROCEDURE [dbo].[uspGetCarByCarID]
    @CarID INT
AS
BEGIN
    SELECT [CarID], [CarName]
    FROM [dbo].[CarTable]
    WHERE [CarID] = @CarID;
END;
