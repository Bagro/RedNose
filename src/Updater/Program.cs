using System;
using System.IO;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Updater.Bolaget;
using Updater.Entities;
using Updater.Implementations.MySql;
using Updater.Implementations.MySql.Implementations;
using Updater.Implementations.MySql.Interfaces;
using Updater.Interfaces;

namespace Updater
{
    public class Program
    {
        static void Main(string[] args)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory());

            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            if (!string.IsNullOrWhiteSpace(environment) && environment.Equals("Development", StringComparison.OrdinalIgnoreCase))
            {
                builder.AddJsonFile("appsettings.development.json", optional: true);
            }
            else
            {
                builder.AddJsonFile("appsettings.json", optional: false);
            }

            IConfiguration configuration = builder.Build();
            
            var serviceCollection = new ServiceCollection()
                .Configure<DataStoreSettings>(options => configuration.GetSection(nameof(DataStoreSettings)).Bind(options))
                .AddScoped<IWorker, Worker>()
                .AddScoped<IBolagetSource, BolagetFileSource>()
                .AddScoped<IDownloader<string>, BolagetFileDownloader>()
                .AddScoped<IDeserializer, BolagetFilesDeserializer>()
                .AddScoped<IBolagetRepository, BolagetRepository>()
                .AddScoped<IBolagetManager, BolagetManager>()
                .AddScoped<IProductStore, MySqlDataStore>()
                .AddScoped<IStoreStore, MySqlDataStore>()
                .AddScoped<IProductsRepository, ProductRepository>()
                .AddScoped<IStoreRepository, StoreRepository>()
                .AddScoped<IStoreProductsLinkRepository, StoreProductsLinkRepository>()
                .AddAutoMapper()
                .BuildServiceProvider();

            var worker = serviceCollection.GetService<IWorker>();

            worker.DoWork().Wait();
        }
    }
}