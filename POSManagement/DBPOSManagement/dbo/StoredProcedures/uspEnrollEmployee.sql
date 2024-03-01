CREATE PROCEDURE [dbo].[uspEnrollEmployee]
    @IdEmployee INT,
    @FirstName NVARCHAR(255),
    @LastName NVARCHAR(255),
    @Role NVARCHAR(100),
    @DateofBirth DATE,
    @Dateofenroll DATE
AS
BEGIN
    INSERT INTO [dbo].[Employee] ([IdEmployee], [FirstName], [LastName], [Role], [DateofBirth], [Dateofenroll])
    VALUES (@IdEmployee, @FirstName, @LastName, @Role, @DateofBirth, @Dateofenroll);
END;
