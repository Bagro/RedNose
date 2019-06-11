using System.Collections.Generic;
using System.Threading.Tasks;
using Updater.Entities;

namespace Updater.DataStore
{
    public interface IProductStore
    {
        Task Save(List<Product> products);
    }
}