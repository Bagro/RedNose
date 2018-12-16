using System.Threading.Tasks;
using Store.MySql.Interfaces;
using Updater.Entities;

namespace Store.MySql.Implementations
{
    public class ProductRepository : IProductsRepository
    {
        public Task<bool> Save(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}