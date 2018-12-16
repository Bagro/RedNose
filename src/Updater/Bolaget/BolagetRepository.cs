using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Schemas;
using Updater.Entities;
using Updater.Interfaces;

namespace Updater.Bolaget
{
    public class BolagetRepository : IBolagetRepository
    {
        private readonly IBolagetSource _bolagetSource;
        private readonly IMapper _mapper;

        public BolagetRepository(IBolagetSource bolagetSource, IMapper mapper)
        {
            _bolagetSource = bolagetSource;
            _mapper = mapper;
        }

        public async Task<List<Product>> GetProducts()
        {
            var artiklar =
                await _bolagetSource.GetData<artiklar>("https://www.systembolaget.se/api/assortment/products/xml");

            return _mapper.Map<List<Product>>(artiklar.artikel);
        }

        public async Task<List<Store>> GetStores()
        {
            var butikerOmbud =
                await _bolagetSource.GetData<ButikerOmbud>("https://www.systembolaget.se/api/assortment/stores/xml");

            var stores = new List<Store>();

            foreach (var item in butikerOmbud.Items)
            {
                if (!(item is StoreAssortmentViewModel || item is AgentAssortmentViewModel))
                {
                    continue;
                }

                stores.Add(_mapper.Map<Store>(item));
            }

            return stores;
        }

        public async Task<List<StoreProductsLink>> GetStoreProductsLinks()
        {
            var butikArtikel =
                await _bolagetSource.GetData<ButikArtikel>("https://www.systembolaget.se/api/assortment/stock/xml");

            var storeProductsLinks = new List<StoreProductsLink>();

            foreach (var item in butikArtikel.Items)
            {
                if (!(item is ButikArtikelButik))
                {
                    continue;
                }

                var butikArtikelButik = item as ButikArtikelButik;

                var storeProductsLink = new StoreProductsLink
                {
                    StoreNumber = butikArtikelButik.ButikNr,
                    ProductNumbers = new List<int>()
                };

                foreach (var artikelNr in butikArtikelButik.ArtikelNr)
                {
                    storeProductsLink.ProductNumbers.Add(Convert.ToInt32(artikelNr.Value));
                }

                storeProductsLinks.Add(storeProductsLink);
            }

            return storeProductsLinks;
        }
    }
}