using System.Collections.Generic;
using System.Threading.Tasks;
using Updater.DataStore.MySql.Repositories;
using Updater.Entities;
using Updater.Interfaces;

namespace Updater.DataStore.MySql
{
    public class MySqlDataStore : IProductStore, IStoreStore
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IStoreRepository _storeRepository;
        private readonly IStoreProductsLinkRepository _storeProductsLinkRepository;
        
        public MySqlDataStore(IProductsRepository productsRepository, IStoreRepository storeRepository, IStoreProductsLinkRepository storeProductsLinkRepository)
        {
            _productsRepository = productsRepository;
            _storeRepository = storeRepository;
            _storeProductsLinkRepository = storeProductsLinkRepository;
        }
        
        public async Task Save(List<Product> products)
        {
            foreach (var product in products)
            {
                await _productsRepository.Save(product);
            }
        }

        public async Task Save(List<Store> stores)
        {
            foreach (var store in stores)
            {
                await _storeRepository.Save(store);
            }
        }

        public async Task SaveProductLinks(List<StoreProductsLink> storeProductsLinks)
        {
            foreach (var storeProductsLink in storeProductsLinks)
            {
                await _storeProductsLinkRepository.Save(storeProductsLink);
            }
        }
    }
}