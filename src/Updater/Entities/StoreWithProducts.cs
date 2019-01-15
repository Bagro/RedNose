using System.Collections.Generic;

namespace Updater.Entities
{
    public class StoreWithProducts : Store
    {
        public List<Product> Products { get; set; }
    }
}