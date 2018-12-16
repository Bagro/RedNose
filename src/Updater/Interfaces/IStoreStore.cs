using System.Collections.Generic;
using Updater.Entities;

namespace Updater.Interfaces
{
    public interface IStoreStore
    {
        void Save(List<Store> stores);

        void SaveProductLinks(List<StoreProductsLink> storeProductsLinks);
    }
}