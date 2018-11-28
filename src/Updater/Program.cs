using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
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
                .AddScoped<IBolagetSource, BolagetFileSource>()
                .AddScoped<IDownloader<string>, BolagetFileDownloader>()
                .AddScoped<IDeserializer, BolagetFilesDeserializer>()
                .AddAutoMapper()
                .BuildServiceProvider();

            var worker = serviceCollection.GetService<IWorker>();

            worker.DoWork().Wait();
        }
    }
}