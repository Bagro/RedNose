using System.Threading.Tasks;

namespace Updater.Interfaces
{
    public interface IDownloader<T>
    {
        Task<T> Download(string url);
    }
}