using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Schemas;
using Updater.Bolaget;
using Updater.Interfaces;

namespace Updater
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection()
                .AddScoped<IWorker, Worker>()
                .AddScoped<IBolagetSource<artiklar>, RangeFileSource>()
                .AddScoped<IDownloader<string>, BolagetFileDownloader>()
                .AddScoped<IDeserializer, BolagetFilesDeserializer>()
                .BuildServiceProvider();

            var worker = serviceCollection.GetService<IWorker>();

            worker.DoWork();
        }
    }
}