CREATE PROCEDURE [dbo].[uspAdjustEmployeeDetails]
    @IdEmployee INT,
    @FirstName NVARCHAR(255) = NULL,
    @LastName NVARCHAR(255) = NULL,
    @Role NVARCHAR(100) = NULL,
    @DateofBirth DATE = NULL,
    @Dateofenroll DATE = NULL
AS
BEGIN
    UPDATE [dbo].[Employee]
    SET FirstName = ISNULL(@FirstName, FirstName),
        LastName = ISNULL(@LastName, LastName),
        Role = ISNULL(@Role, Role),
        DateofBirth = ISNULL(@DateofBirth, DateofBirth),
        Dateofenroll = ISNULL(@Dateofenroll, Dateofenroll)
    WHERE IdEmployee = @IdEmployee;
END;
