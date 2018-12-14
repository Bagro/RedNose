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
        private readonly IBolagetRepository _bolagetRepository;

        public Worker(IBolagetRepository bolagetRepository)
        {
            _bolagetRepository = bolagetRepository;
        }

        public async Task DoWork()
        {
            var productsTask = _bolagetRepository.GetProducts();
            var storesTask = _bolagetRepository.GetStores();

            await productsTask;
            List<Product> products = productsTask.Result;

            await storesTask;
            List<Store> stores = storesTask.Result;
        }
    }
}