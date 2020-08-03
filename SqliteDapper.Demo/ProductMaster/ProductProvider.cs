using Dapper;
using Microsoft.Data.Sqlite;
using SqliteDapper.Demo.Database;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SqliteDapper.Demo.ProductMaster
{
    public class ProductProvider : IProductProvider
    {
        private readonly DatabaseConfig databaseConfig;

        public ProductProvider(DatabaseConfig databaseConfig)
        {
            this.databaseConfig = databaseConfig;
        }

        public async Task<IEnumerable<Product>> Get()
        {
            using var connection = new SqliteConnection(databaseConfig.Name);

            return await connection.QueryAsync<Product>("SELECT rowid AS Id, Name, Description FROM Product;");
        }
    }
}
