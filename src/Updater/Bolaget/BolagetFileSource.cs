using System.Threading.Tasks;
using Schemas;
using Updater.Interfaces;

namespace Updater.Bolaget
{
    public class BolagetFileSource : IBolagetSource
    {
        private readonly IDownloader<string> _downloader;
        private readonly IDeserializer _deserializer;
        
        public BolagetFileSource(IDownloader<string> downloader, IDeserializer deserializer)
        {
            _downloader = downloader;
            _deserializer = deserializer;
        }
        
        public async Task<T> GetData<T>(string url)
        {
            var fileContent = await _downloader.Download(url);
            return _deserializer.Deserialize<T>(fileContent);
        }
    }
}