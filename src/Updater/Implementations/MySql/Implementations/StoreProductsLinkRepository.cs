using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using Updater.Entities;
using Updater.Implementations.MySql.Interfaces;

namespace Updater.Implementations.MySql.Implementations
{
    public class StoreProductsLinkRepository : IStoreProductsLinkRepository
    {
        private readonly MySqlConnectionStringBuilder _mySqlConnectionStringBuilder;

        public StoreProductsLinkRepository(IOptions<DataStoreSettings> options)
        {
            DataStoreSettings dataStoreSettings = options.Value;

            _mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder
            {
                Server = dataStoreSettings.Server,
                Database = dataStoreSettings.Database,
                UserID = dataStoreSettings.UserId,
                Password = dataStoreSettings.Password
            };
        }
        
        public async Task Save(StoreProductsLink storeProductsLink)
        {
            var currentProductNumbers = await GetCurrentProductNumbers(storeProductsLink.StoreNumber);

            var productNumbersToRemove = currentProductNumbers.Where(x => !storeProductsLink.ProductNumbers.Contains(x)).ToList();
            var productNumbersToAdd = storeProductsLink.ProductNumbers.Where(x => !currentProductNumbers.Contains(x)).ToList();

            await RemoveProductNumbers(storeProductsLink.StoreNumber, productNumbersToRemove);
            await AddStoreAndProductNumbers(storeProductsLink.StoreNumber, productNumbersToAdd);
        }

        private async Task<List<int>> GetCurrentProductNumbers(string storeNumber)
        {
            var productNumbers = new List<int>();
            
            using (var connection = new MySqlConnection(_mySqlConnectionStringBuilder.ConnectionString))
            {
                await connection.OpenAsync();
                var command = connection.CreateCommand();

                command.CommandText = "SELECT productNumber FROM storeproducts WHERE storeNumber=@storeNumber";
                command.Parameters.AddWithValue("@storeNumber", storeNumber);

                var reader = await command.ExecuteReaderAsync();

                while (reader.Read())
                {
                    productNumbers.Add(Convert.ToInt32(reader[0]));
                }

                await connection.CloseAsync();
            }

            return productNumbers;
        }
        
        private async Task AddStoreAndProductNumbers(string storeNumber, List<int> productNumbers)
        {
            using (var connection = new MySqlConnection(_mySqlConnectionStringBuilder.ConnectionString))
            {
                await connection.OpenAsync();
                var command = connection.CreateCommand();

                command.CommandText = "INSERT INTO storeproducts (storeNumber, productNumber) VALUES (@storeNumber, @productNumber)";

                foreach (var productNumber in productNumbers)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@storeNumber", storeNumber);
                    command.Parameters.AddWithValue("@productNumber", productNumber);

                    await command.ExecuteNonQueryAsync();
                }

                await connection.CloseAsync();
            }
        }
        
        private async Task RemoveProductNumbers(string storeNumber, List<int> productNumbers)
        {
            using (var connection = new MySqlConnection(_mySqlConnectionStringBuilder.ConnectionString))
            {
                await connection.OpenAsync();
                var command = connection.CreateCommand();

                command.CommandText = "DELETE FROM storeproducts WHERE storeNumber=@storeNumber and productNumber=@productNumber";

                foreach (var productNumber in productNumbers)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@storeNumber", storeNumber);
                    command.Parameters.AddWithValue("@productNumber", productNumber);

                    await command.ExecuteNonQueryAsync();
                }

                await connection.CloseAsync();
            }
        }
    }
}