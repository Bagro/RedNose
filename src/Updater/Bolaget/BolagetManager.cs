using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Updater.Entities;
using Updater.Interfaces;

namespace Updater.Bolaget
{
    public class BolagetManager : IBolagetManager
    {
        private readonly IBolagetRepository _bolagetRepository;
        private readonly IMapper _mapper;

        public BolagetManager(IBolagetRepository bolagetRepository, IMapper mapper)
        {
            _bolagetRepository = bolagetRepository;
            _mapper = mapper;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _bolagetRepository.GetProducts();
        }

        public async Task<List<ProductWithStores>> GetProductsWithStores()
        {
            var productsTask = _bolagetRepository.GetProducts();
            var storesTask = _bolagetRepository.GetStores();
            var storeProductLinks = _bolagetRepository.GetStoreProductsLinks();

            var products = await productsTask;
            var stores = await storesTask;
            var storeProductsLinks = await storeProductLinks;

            var productWithStoresList = new List<ProductWithStores>();

            foreach (var product in products)
            {
                Debug.WriteLine($"Product {product.Number} - {product.Name}");
                var storeNumbers = storeProductsLinks.Where(x => x.ProductNumbers.Any(p => p == product.Number))
                    .Select(x => x.StoreNumber).ToList();

                Debug.WriteLine(storeNumbers.Count);
                if (!storeNumbers.Any())
                {
                    continue;
                }

                var productStores = stores.Where(x => storeNumbers.Contains(x.Number)).ToList();

                if (!productStores.Any())
                {
                    continue;
                }

                ProductWithStores productWithStores = _mapper.Map<ProductWithStores>(product);
                productWithStores.Stores = productStores;

                productWithStoresList.Add(productWithStores);
            }

            return productWithStoresList;
        }

        public async Task<List<Store>> GetStores()
        {
            return await _bolagetRepository.GetStores();
        }

        public Task<List<StoreWithProducts>> GetStoresWithProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}