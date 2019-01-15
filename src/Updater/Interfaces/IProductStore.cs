using System.Collections.Generic;
using System.Threading.Tasks;
using Updater.Entities;

namespace Updater.Interfaces
{
    public interface IProductStore
    {
        Task Save(List<Product> products);
    }
}