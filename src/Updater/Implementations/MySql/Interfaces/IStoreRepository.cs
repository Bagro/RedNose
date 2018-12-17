using System.Threading.Tasks;
using Updater.Entities;

namespace Updater.Implementations.MySql.Interfaces
{
    public interface IStoreRepository
    {
        Task Save(Store store);
    }
}