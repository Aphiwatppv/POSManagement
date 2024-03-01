CREATE PROCEDURE [dbo].[uspAdjustCar]
    @CarID INT,
    @CarName NVARCHAR(50)
AS
BEGIN
    UPDATE [dbo].[CarTable]
    SET [CarName] = @CarName
    WHERE [CarID] = @CarID;
END;
