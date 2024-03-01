CREATE PROCEDURE [dbo].[uspAddCar]
    @CarID INT,
    @CarName NVARCHAR(50)
AS
BEGIN
    INSERT INTO [dbo].[CarTable] ([CarID], [CarName])
    VALUES (@CarID, @CarName);
END;
