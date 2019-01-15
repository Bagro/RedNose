using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Updater.Entities;
using Updater.Implementations.MySql.Interfaces;

namespace Updater.Implementations.MySql.Implementations
{
    public class StoreRepository : IStoreRepository
    {
        private readonly MySqlConnectionStringBuilder _mySqlConnectionStringBuilder;

        public StoreRepository(IOptions<DataStoreSettings> options)
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

        public async Task Save(Store store)
        {
            var exist = await DoesStoreExist(store.Number);

            var query = exist ? GetUpdateQuery() : GetAddQuery();

            await ExecuteSave(store, query);
        }

        private async Task ExecuteSave(Store store, string query)
        {
            using (var connection = new MySqlConnection(_mySqlConnectionStringBuilder.ConnectionString))
            {
                await connection.OpenAsync();

                var command = connection.CreateCommand();
                command.CommandText = query;

                command.Parameters.AddWithValue("@number", store.Number);
                command.Parameters.AddWithValue("@storeType", store.StoreType);
                command.Parameters.AddWithValue("@name", store.Name ?? string.Empty);
                command.Parameters.AddWithValue("@street", store.Street ?? string.Empty);
                command.Parameters.AddWithValue("@postalCode", store.PostalCode ?? string.Empty);
                command.Parameters.AddWithValue("@city", store.City ?? string.Empty);
                command.Parameters.AddWithValue("@county", store.County ?? string.Empty);
                command.Parameters.AddWithValue("@phone", store.Phone ?? string.Empty);
                command.Parameters.AddWithValue("@services", store.Services ?? string.Empty);
                command.Parameters.AddWithValue("@searchWords", JsonConvert.SerializeObject(store.SearchWords));
                command.Parameters.AddWithValue("@openingHours", JsonConvert.SerializeObject(store.OpeningHours));
                command.Parameters.AddWithValue("@rt90x", store.Rt90x ?? string.Empty);
                command.Parameters.AddWithValue("@rt90y", store.Rt90y ?? string.Empty);
                command.Parameters.AddWithValue("@added", DateTime.UtcNow);
                command.Parameters.AddWithValue("@updated", DateTime.UtcNow);
                
                await command.ExecuteNonQueryAsync();

                await connection.CloseAsync();
            }
        }
        
        private async Task<bool> DoesStoreExist(string number)
        {
            using (var connection = new MySqlConnection(_mySqlConnectionStringBuilder.ConnectionString))
            {
                await connection.OpenAsync();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM stores WHERE number=@number";
                command.Parameters.AddWithValue("@number", number);

                var productCount = await command.ExecuteScalarAsync();

                await connection.CloseAsync();

                return Convert.ToInt32(productCount) == 1;
            }
        }

        private string GetAddQuery()
        {
            var query = new StringBuilder();

            query.Append("INSERT INTO stores ");
            query.Append(
                "(number, storeType, name, street, postalCode, city, county, phone, services, searchWords, openingHours, rt90x, rt90y, added, updated) ");
            query.Append("VALUES ");
            query.Append(
                "(@number, @storeType, @name, @street, @postalCode, @city, @county, @phone, @services, @searchWords, @openingHours, @rt90x, @rt90y, @added, @updated)");

            return query.ToString();
        }

        private string GetUpdateQuery()
        {
            var query = new StringBuilder();

            query.Append("UPDATE stores SET ");
            query.Append(
                "storeType=@storeType, name=@name, street=@street, postalCode=@postalCode, city=@city, county=@county, ");
            query.Append("phone=@phone, services=@services, searchWords=@searchWords, openingHours=@openingHours, ");
            query.Append("rt90x=@rt90x, rt90y=@rt90y, updated=@updated WHERE number=@number");

            return query.ToString();
        }
    }
}