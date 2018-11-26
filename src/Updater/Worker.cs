using System.Threading.Tasks;
using Schemas;
using Updater.Interfaces;

namespace Updater
{
    public class Worker : IWorker
    {
        private readonly IBolagetSource _bolagetSource;

        public Worker(IBolagetSource bolagetSource)
        {
            _bolagetSource = bolagetSource;
        }
        
        public async Task DoWork()
        {
            var artiklar = await _bolagetSource.GetData<artiklar>("https://www.systembolaget.se/api/assortment/products/xml");
            var butikerOmbud = await _bolagetSource.GetData<ButikerOmbud>("https://www.systembolaget.se/api/assortment/stores/xml");
            var butikArtikel = await _bolagetSource.GetData<ButikArtikel>("https://www.systembolaget.se/api/assortment/stock/xml");
        }
    }
}