CREATE TABLE [dbo].[Employee]
(
    [IdEmployee] INT NOT NULL PRIMARY KEY,
    [FirstName] NVARCHAR(255) NULL,
    [LastName] NVARCHAR(255) NULL,
    [Role] NVARCHAR(100) NULL,
    [DateofBirth] DATE NULL,
    [Dateofenroll] DATE NULL,
    [age] AS (DATEDIFF(YEAR, [DateofBirth], GETDATE()) - CASE WHEN (MONTH([DateofBirth]) > MONTH(GETDATE())) OR (MONTH([DateofBirth]) = MONTH(GETDATE()) AND DAY([DateofBirth]) > DAY(GETDATE())) THEN 1 ELSE 0 END),
    [experience] AS (DATEDIFF(YEAR, [Dateofenroll], GETDATE()) - CASE WHEN (MONTH([Dateofenroll]) > MONTH(GETDATE())) OR (MONTH([Dateofenroll]) = MONTH(GETDATE()) AND DAY([Dateofenroll]) > DAY(GETDATE())) THEN 1 ELSE 0 END)
);
