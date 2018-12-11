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

            artiklarTask.Wait();
            artiklar artiklar = artiklarTask.Result;

            var product = _mapper.Map<List<Product>>(artiklar.artikel);
        }
    }
}