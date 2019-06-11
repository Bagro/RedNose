using System.Threading.Tasks;

namespace Updater.Bolaget
{
    public interface IDownloader<T>
    {
        Task<T> Download(string url);
    }
}