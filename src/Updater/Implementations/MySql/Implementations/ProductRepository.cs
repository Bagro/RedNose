using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using Updater.Entities;
using Updater.Implementations.MySql.Interfaces;

namespace Updater.Implementations.MySql.Implementations
{
    public class ProductRepository : IProductsRepository
    {
        private readonly MySqlConnectionStringBuilder _mySqlConnectionStringBuilder;

        public ProductRepository(IOptions<DataStoreSettings> options)
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

        public async Task Save(Product product)
        {
            var existing = await DoesProductExist(product.Number);
            var query = existing ? GetUpdateQuery() : GetAddQuery();

            await ExecuteSave(product, query);
        }

        private async Task ExecuteSave(Product product, string query)
        {
            using (var connection = new MySqlConnection(_mySqlConnectionStringBuilder.ConnectionString))
            {
                await connection.OpenAsync();

                var command = connection.CreateCommand();
                command.CommandText = query;

                command.Parameters.AddWithValue("@number", product.Number);
                command.Parameters.AddWithValue("@alcohol", product.Alcohol);
                command.Parameters.AddWithValue("@assortment", product.Assortment);
                command.Parameters.AddWithValue("@discontinued", product.Discontinued);
                command.Parameters.AddWithValue("@ecological", product.Ecological);
                command.Parameters.AddWithValue("@ethically", product.Ethically);
                command.Parameters.AddWithValue("@koscher", product.Koscher);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@name2", product.Name2);
                command.Parameters.AddWithValue("@origin", product.Origin);
                command.Parameters.AddWithValue("@packaging", product.Packaging);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@producer", product.Producer ?? string.Empty);
                command.Parameters.AddWithValue("@seal", product.Seal);
                command.Parameters.AddWithValue("@size", product.Size);
                command.Parameters.AddWithValue("@style", product.Style);
                command.Parameters.AddWithValue("@supplier", product.Supplier ?? string.Empty);
                command.Parameters.AddWithValue("@type", product.Type);
                command.Parameters.AddWithValue("@year", product.Year);
                command.Parameters.AddWithValue("@assortmentText", product.AssortmentText);
                command.Parameters.AddWithValue("@productGroup", product.ProductGroup ?? string.Empty);
                command.Parameters.AddWithValue("@productId", product.ProductId);
                command.Parameters.AddWithValue("@productNumber", product.ProductNumber);
                command.Parameters.AddWithValue("@yearTested", product.YearTested);
                command.Parameters.AddWithValue("@countryOfOrigin", product.CountryOfOrigin);
                command.Parameters.AddWithValue("@pricePerLitre", product.PricePerLitre);
                command.Parameters.AddWithValue("@rawMaterialDescription", product.RawMaterialDescription ?? string.Empty);
                command.Parameters.AddWithValue("@startOfSale", product.StartOfSale);
                command.Parameters.AddWithValue("@updated", DateTime.UtcNow);
                command.Parameters.AddWithValue("@added", DateTime.UtcNow);

                await command.ExecuteNonQueryAsync();

                await connection.CloseAsync();
            }
        }

        private async Task<bool> DoesProductExist(int number)
        {
            using (var connection = new MySqlConnection(_mySqlConnectionStringBuilder.ConnectionString))
            {
                await connection.OpenAsync();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM products WHERE number=@number";
                command.Parameters.AddWithValue("@number", number);

                var productCount = await command.ExecuteScalarAsync();

                await connection.CloseAsync();

                return Convert.ToInt32(productCount) == 1;
            }
        }

        private static string GetAddQuery()
        {
            var query = new StringBuilder();
            query.Append("INSERT INTO products ");
            query.Append(
                "(number,alcohol, assortment, discontinued, ecological, ethically, koscher, name, name2, origin, packaging, price, producer, seal, size, style, supplier, type, year, assortmentText, productGroup, productId, productNumber, yearTested, countryOfOrigin, pricePerLitre, rawMaterialDescription, startOfSale, updated, added)");
            query.Append("values ");
            query.Append(
                "(@number, @alcohol, @assortment, @discontinued, @ecological, @ethically, @koscher, @name, @name2, @origin, @packaging, @price, @producer, @seal, @size, @style, @supplier, @type, @year, @assortmentText, @productGroup, @productId, @productNumber, @yearTested, @countryOfOrigin, @pricePerLitre, @rawMaterialDescription, @startOfSale, @updated, @added)");

            return query.ToString();
        }

        private static string GetUpdateQuery()
        {
            var query = new StringBuilder();
            query.Append(
                "UPDATE products SET alcohol=@alcohol, assortment=@assortment, discontinued=@discontinued, ecological=@ecological, ethically=@ethically, koscher=@koscher, name=@name, name2=@name2, origin=@origin, ");
            query.Append(
                "packaging=@packaging, price=@price, producer=@producer, seal=@seal, size=@size, style=@style, supplier=@supplier, type=@type, year=@year, assortmentText=@assortmentText, ");
            query.Append(
                "productGroup=@productGroup, productId=@productId, productNumber=@productNumber, yearTested=@yearTested, countryOfOrigin=@countryOfOrigin, pricePerLitre=@pricePerLitre, ");
            query.Append(
                "rawMaterialDescription=@rawMaterialDescription, startOfSale=@startOfSale, updated=@updated WHERE number=@number");

            return query.ToString();
        }
    }
}