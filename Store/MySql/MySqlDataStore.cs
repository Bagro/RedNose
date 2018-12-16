using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Options;
using Updater.Entities;
using Updater.Interfaces;

namespace Store.MySql
{
    public class MySqlDataStore : IProductStore, IStoreStore
    {
        private readonly MySqlDataStoreSettings _mySqlDataStoreSettings; 
        
        public MySqlDataStore(IOptions<MySqlDataStoreSettings> options)
        {
            _mySqlDataStoreSettings = options.Value;
        }
        
        public void Save(List<Product> products)
        {
            throw new System.NotImplementedException();
        }

        public void Save(List<Updater.Entities.Store> stores)
        {
            throw new System.NotImplementedException();
        }

        public void SaveProductLinks(List<StoreProductsLink> storeProductsLinks)
        {
            throw new System.NotImplementedException();
        }
    }
}