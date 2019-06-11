using System.Collections.Generic;
using System.Threading.Tasks;
using Updater.Entities;

namespace Updater.DataStore
{
    public interface IStoreStore
    {
        Task Save(List<Store> stores);

        Task SaveProductLinks(List<StoreProductsLink> storeProductsLinks);
    }
}