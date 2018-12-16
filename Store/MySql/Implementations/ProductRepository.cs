using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using Store.MySql.Interfaces;
using Updater.Entities;

namespace Store.MySql.Implementations
{
    public class ProductRepository : IProductsRepository
    {
        private readonly MySqlDataStoreSettings _mySqlDataStoreSettings;

        public ProductRepository(IOptions<MySqlDataStoreSettings> options)
        {
            _mySqlDataStoreSettings = options.Value;
        }

        public async Task Save(Product product)
        {
            var query = await DoesProductExist(product.Number) ? GetUpdateQuery() : GetAddQuery();

            await ExecuteSave(product, query);
        }

        private async Task ExecuteSave(Product product, string query)
        {
            
        }
        
        private async Task<bool> DoesProductExist(int number)
        {
            using (var connection = new MySqlConnection(_mySqlDataStoreSettings.ConnectionString))
            {
                await connection.OpenAsync();

                var command = connection.CreateCommand();
                command.CommandText ="SELECT COUNT(*) FROM products WHERE number=@number";
                command.Parameters.AddWithValue("@number", number);

                var productCount = (int) await command.ExecuteScalarAsync();

                return productCount == 1;
            }
        }

        private static string GetAddQuery()
        {
            var query = new StringBuilder();
            query.Append("INSERT INTO products ");
            query.Append(
                "(number,alcohol, assortment, discontinued, ecological, koscher, name, name2, origin, packaging, price, producer, seal, size=@size, style, supplier, type, year, assortmentText, productGroup, productId, productNumber, yearTested, countryOfOrigin, pricePerLitre, rawMaterialDescription, startOfSale, updated, added)");
            query.Append("values ");
            query.Append("(@number, @alcohol, @assortment, @discontinued, @ecological, @koscher, @name, @name2, @origin, @packaging, @price, @producer, @seal, @style, @supplier, @type, @year, @assortmentText, @productGroup, @productId, @productNumber, @yearTested, @countryOfOrigin, @pricePerLitre, @rawMaterialDescription, @startOfSale, @updated, @added)");

            return query.ToString();
        }
        
        private static string GetUpdateQuery()
        {
            var query = new StringBuilder();
            query.Append(
                "UPDATE products SET alcohol=@alcohol, assortment=@assortment, discontinued=@discontinued, ecological=@ecological, koscher=@koscher, name=@name, name2=@name2, origin=@origin, ");
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