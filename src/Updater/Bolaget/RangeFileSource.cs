using System.Threading.Tasks;
using Schemas;
using Updater.Interfaces;

namespace Updater.Bolaget
{
    public class RangeFileSource : IBolagetSource<artiklar>
    {
        // Todo: Make config setting
        private const string FileUrl = "https://www.systembolaget.se/api/assortment/products/xml";
        
        private readonly IDownloader<string> _downloader;
        private readonly IDeserializer _deserializer;
        
        public RangeFileSource(IDownloader<string> downloader, IDeserializer deserializer)
        {
            _downloader = downloader;
            _deserializer = deserializer;
        }
        
        public async Task<artiklar> GetData()
        {
            var fileContent = await _downloader.Download(FileUrl);
            return _deserializer.Deserialize<artiklar>(fileContent);
        }
    }
}