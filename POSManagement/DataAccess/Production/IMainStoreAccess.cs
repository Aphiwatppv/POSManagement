using DataAccess.Models;

namespace DataAccess.Production
{
    public interface IMainStoreAccess
    {
        Task AddNewProduct(MainStore mainStore);
        Task AdjustProductDetail(int ProductId, MainStore mainStore);
        Task DecreaseStock(int productId, int amount);
        Task<IEnumerable<MainStore>> GetAllProduct();
        Task IncreaseStock(int productId, int amount);
        Task RemoveProduct(int ProductId);
    }
}