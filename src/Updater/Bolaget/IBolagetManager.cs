using System.Collections.Generic;
using System.Threading.Tasks;
using Updater.Entities;

namespace Updater.Bolaget
{
    public interface IBolagetManager
    {
        Task<List<Product>> GetProducts();

        Task<List<ProductWithStores>> GetProductsWithStores();

        Task<List<Store>> GetStores();

        Task<List<StoreWithProducts>> GetStoresWithProducts();

        Task<List<StoreProductsLink>> GetStoreProductsLinks();
    }
}