CREATE TABLE [dbo].[CheckStockTB]
(
    [IdTransaction] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [productid] INT NOT NULL,
    [CarID] INT NULL,
    [TakingStockfromstore] INT NULL,
    [ReturningStockfromCar] INT NULL,
    [StockUnit] NVARCHAR(50) NULL,
    [IsReturnToStore] BIT NULL DEFAULT 0,
    [Datetime] DATE NULL,
    [IdEmployee] INT NULL, -- Matching the Employee table's primary key data type
    FOREIGN KEY ([productid]) REFERENCES [MainStoreTB]([productid]),
    FOREIGN KEY ([CarID]) REFERENCES [CarTable]([CarID]),
    FOREIGN KEY ([IdEmployee]) REFERENCES [Employee]([IdEmployee]) -- Foreign key constraint
);
