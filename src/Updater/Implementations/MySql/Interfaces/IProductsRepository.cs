using System.Threading.Tasks;
using Updater.Entities;

namespace Updater.Implementations.MySql.Interfaces
{
    public interface IProductsRepository
    {
        Task Save(Product product);
    }
}