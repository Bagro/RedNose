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

        public Worker(IBolagetManager bolagetManager)
        {
            _bolagetManager = bolagetManager;
        }

        public async Task DoWork()
        {
            var productWithStoreses = await _bolagetManager.GetProductsWithStores();
        }
    }
}