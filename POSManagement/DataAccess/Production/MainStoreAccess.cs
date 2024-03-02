using DataAccess.Models;
using DataAccess.SqlAccess;
using System.Diagnostics;

namespace DataAccess.Production;

public class MainStoreAccess : IMainStoreAccess
{
    private readonly ISqlAccess _sqlAccess;
    public MainStoreAccess(ISqlAccess sqlAccess)
    {
        _sqlAccess = sqlAccess;
    }

    #region Function for MainStore Table
    //MainStore Table 
    public async Task<IEnumerable<MainStore>> GetAllProduct()
        => await _sqlAccess.LoadData<MainStore, dynamic>(storedProcedure: "dbo.uspGetAllProducts", new { });

    public async Task AddNewProduct(MainStore mainStore)
    {
        if (mainStore == null) throw new ArgumentNullException(nameof(mainStore));
        await _sqlAccess.SaveData(storedProcedure: "dbo.uspAddNewProduct", new
        {
            productid = mainStore.ProductId,
            productname = mainStore.ProductName,
            price = mainStore.Price,
            PriceUnit = mainStore.PriceUnit,
            RemainingStock = mainStore.RemainingStock,
            StockUnit = mainStore.StockUnit
        });
    }


    public async Task RemoveProduct(int ProductId)
    {
        await _sqlAccess.SaveData(storedProcedure: "dbo.uspRemoveProduct", new
        {
            productID = ProductId
        });
    }

    public async Task AdjustProductDetail(int ProductId, MainStore mainStore)
    {
        if (mainStore == null) throw new ArgumentNullException(nameof(mainStore));
        await _sqlAccess.SaveData(storedProcedure: "dbo.uspAdjustProductDetail", new
        {
            ProductId = ProductId,
            productName = mainStore.ProductName,
            price = mainStore.Price,
            PriceUnit = mainStore.PriceUnit,
            StockUnit = mainStore.StockUnit,

        });
    }

    public async Task IncreaseStock(int productId, int amount)
    {
        await _sqlAccess.SaveData(storedProcedure: "dbo.uspIncreaseStock", new
        {
            ProductId = productId,
            amount = amount
        });
    }

    public async Task DecreaseStock(int productId, int amount)
    {
        await _sqlAccess.SaveData(storedProcedure: "dbo.uspDecreaseStock", new
        {
            ProductId = productId,
            amount = amount
        });
    }
    #endregion
}
