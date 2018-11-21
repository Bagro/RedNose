using System.Threading.Tasks;

namespace Updater.Interfaces
{
    public interface IBolagetSource
    {
        Task<T> GetData<T>(string url);
    }
}