using System.Collections.Generic;
using System.Threading.Tasks;
using Updater.Entities;

namespace Updater.Bolaget
{
    public interface IBolagetRepository
    {
        Task<List<Product>> GetProducts();

        Task<List<Store>> GetStores();

        Task<List<StoreProductsLink>> GetStoreProductsLinks();
    }
}