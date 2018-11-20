using System.Threading.Tasks;

namespace Updater.Interfaces
{
    public interface IBolagetSource<T>
    {
        Task<T> GetData();
    }
}