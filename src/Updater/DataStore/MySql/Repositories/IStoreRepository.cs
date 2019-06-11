using System.Threading.Tasks;
using Updater.Entities;

namespace Updater.DataStore.MySql.Repositories
{
    public interface IStoreRepository
    {
        Task Save(Store store);
    }
}