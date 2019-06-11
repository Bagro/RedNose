using System.Threading.Tasks;
using Updater.Entities;

namespace Updater.DataStore.MySql.Repositories
{
    public interface IStoreProductsLinkRepository
    {
        Task Save(StoreProductsLink storeProductsLink);
    }
}