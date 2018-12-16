using System.Collections.Generic;
using Updater.Entities;

namespace Updater.Interfaces
{
    public interface IProductStore
    {
        void Save(List<Product> products);
    }
}