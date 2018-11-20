using System.Threading.Tasks;
using Schemas;
using Updater.Interfaces;

namespace Updater.Bolaget
{
    public class InventoryFileSource : IBolagetSource<artiklar>
    {
        // Todo: Make config setting
        private const string FileUrl = "https://www.systembolaget.se/api/assortment/products/xml";
        
        private readonly IDownloader<string> _downloader;
        
        public InventoryFileSource(IDownloader<string> downloader)
        {
            _downloader = downloader;
        }
        
        public async Task<artiklar> GetData()
        {
            var fileContent = await _downloader.Download(FileUrl);
        }
    }
}