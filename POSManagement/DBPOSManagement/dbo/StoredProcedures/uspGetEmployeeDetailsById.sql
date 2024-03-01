CREATE PROCEDURE [dbo].[uspGetEmployeeDetailsById]
    @IdEmployee INT
AS
BEGIN
    SELECT IdEmployee, FirstName, LastName, Role, DateofBirth, Dateofenroll, age, experience
    FROM [dbo].[Employee]
    WHERE IdEmployee = @IdEmployee;
END;
