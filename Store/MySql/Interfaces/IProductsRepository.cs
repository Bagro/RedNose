using System.Threading.Tasks;
using Updater.Entities;

namespace Store.MySql.Interfaces
{
    public interface IProductsRepository
    {
        Task<bool> Save(Product product);
    }
}