using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Schemas;
using Updater.Entities;
using Updater.Interfaces;

namespace Updater
{
    public class Worker : IWorker
    {
        private readonly IBolagetManager _bolagetManager;
        private readonly IProductStore _productStore;

        public Worker(IBolagetManager bolagetManager, IProductStore productStore)
        {
            _bolagetManager = bolagetManager;
            _productStore = productStore;
        }

        public async Task DoWork()
        {
            var products = await _bolagetManager.GetProducts();
            _productStore.Save(products);
        }
    }
}