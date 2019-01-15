using System.Collections.Generic;

namespace Updater.Entities
{
    public class ProductWithStores : Product
    {
        public List<Store> Stores { get; set; }
    }
}