using System.Collections.Generic;

namespace Updater.Entities
{
    public class StoreProductsLink
    {
        public string StoreNumber { get; set; }

        public List<int> ProductNumbers { get; set; }
    }
}