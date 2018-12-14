using System.Collections.Generic;
using System.Threading.Tasks;
using Updater.Entities;

namespace Updater.Interfaces
{
    public interface IBolagetManager
    {
        Task<List<Product>> GetProducts();

        Task<List<ProductWithStores>> GetProductsWithStores();

        Task<List<Store>> GetStores();

        Task<List<StoreWithProducts>> GetStoresWithProducts();
    }
}