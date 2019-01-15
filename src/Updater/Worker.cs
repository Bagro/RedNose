using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Schemas;
using Updater.Entities;
using Updater.Interfaces;

namespace Updater
{
    public class Worker : IWorker
    {
        private readonly IBolagetManager _bolagetManager;
        private readonly IProductStore _productStore;
        private readonly IStoreStore _storeStore;

        public Worker(IBolagetManager bolagetManager, IProductStore productStore, IStoreStore storeStore)
        {
            _bolagetManager = bolagetManager;
            _productStore = productStore;
            _storeStore = storeStore;
        }

        public async Task DoWork()
        {
            var productsTask = _bolagetManager.GetProducts();
            var storesTask = _bolagetManager.GetStores();
            var storeProductsLinksTask = _bolagetManager.GetStoreProductsLinks();
            
            var products = await productsTask;
            await _productStore.Save(products);
            
            var stores = await storesTask;
            await _storeStore.Save(stores);

            var storeProductsLinks = await storeProductsLinksTask;
            await _storeStore.SaveProductLinks(storeProductsLinks);
        }
    }
}