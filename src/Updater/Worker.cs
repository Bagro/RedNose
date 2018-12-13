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
        private readonly IBolagetSource _bolagetSource;
        private readonly IMapper _mapper;

        public Worker(IBolagetSource bolagetSource, IMapper mapper)
        {
            _bolagetSource = bolagetSource;
            _mapper = mapper;
        }

        public async Task DoWork()
        {
            var artiklarTask = _bolagetSource.GetData<artiklar>("https://www.systembolaget.se/api/assortment/products/xml");
            var butikerOmbudTask = _bolagetSource.GetData<ButikerOmbud>("https://www.systembolaget.se/api/assortment/stores/xml");
            var butikArtikelTask = _bolagetSource.GetData<ButikArtikel>("https://www.systembolaget.se/api/assortment/stock/xml");

            await artiklarTask;
            artiklar artiklar = artiklarTask.Result;
            await butikerOmbudTask;
            ButikerOmbud butikerOmbud = butikerOmbudTask.Result;

            var products = _mapper.Map<List<Product>>(artiklar.artikel);
            var stores = ParseStores(butikerOmbud);
        }

        private List<Store> ParseStores(ButikerOmbud butikerOmbud)
        {
            var stores = new List<Store>();

            foreach (var item in butikerOmbud.Items)
            {
                if(!(item is StoreAssortmentViewModel || item is AgentAssortmentViewModel))
                {
                    continue;
                }

                stores.Add(_mapper.Map<Store>(item));
            }

            return stores;
        }
    }
}