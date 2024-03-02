CREATE TABLE [dbo].[MainStoreTB]
(
    [productid] INT NOT NULL PRIMARY KEY, 
    [productname] NVARCHAR(255) NULL, 
    [price] DECIMAL(13,2) NULL, 
    [PriceUnit] NVARCHAR(50) NULL, 
    [RemainingStock] INT NULL, 
    [StockUnit] NVARCHAR(50) NULL
)
