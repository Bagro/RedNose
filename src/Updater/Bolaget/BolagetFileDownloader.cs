using System.Net.Http;
using System.Threading.Tasks;
using Updater.Interfaces;

namespace Updater.Bolaget
{
    public class BolagetFileDownloader : IDownloader<string>
    {
        public async Task<string> Download(string url)
        {
            var httpClient = new HttpClient();
            var content = await httpClient.GetStringAsync(url);

            return content;
        }
    }
}