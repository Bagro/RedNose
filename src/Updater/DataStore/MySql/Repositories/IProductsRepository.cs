using System.Threading.Tasks;
using Updater.Entities;

namespace Updater.DataStore.MySql.Repositories
{
    public interface IProductsRepository
    {
        Task Save(Product product);
    }
}