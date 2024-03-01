CREATE PROCEDURE [dbo].[uspRemoveEmployee]
    @IdEmployee INT
AS
BEGIN
    DELETE FROM [dbo].[Employee]
    WHERE IdEmployee = @IdEmployee;
END;
