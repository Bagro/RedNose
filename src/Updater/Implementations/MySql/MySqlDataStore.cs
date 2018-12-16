using System.Collections.Generic;
using System.Threading.Tasks;
using Updater.Entities;
using Updater.Implementations.MySql.Interfaces;
using Updater.Interfaces;

namespace Updater.Implementations.MySql
{
    public class MySqlDataStore : IProductStore, IStoreStore
    {
        private readonly IProductsRepository _productsRepository;
        
        public MySqlDataStore(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }
        
        public async Task Save(List<Product> products)
        {
            foreach (var product in products)
            {
                await _productsRepository.Save(product);
            }
        }

        public Task Save(List<Updater.Entities.Store> stores)
        {
            throw new System.NotImplementedException();
        }

        public Task SaveProductLinks(List<StoreProductsLink> storeProductsLinks)
        {
            throw new System.NotImplementedException();
        }
    }
}