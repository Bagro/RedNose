using System.Threading.Tasks;
using Updater.Entities;

namespace Updater.Implementations.MySql.Interfaces
{
    public interface IStoreProductsLinkRepository
    {
        Task Save(StoreProductsLink storeProductsLink);
    }
}