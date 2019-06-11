using System.Threading.Tasks;

namespace Updater.Bolaget
{
    public interface IBolagetSource
    {
        Task<T> GetData<T>(string url);
    }
}