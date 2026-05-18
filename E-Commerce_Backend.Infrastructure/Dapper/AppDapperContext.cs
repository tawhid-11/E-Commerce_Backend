using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace E_Commerce_Backend.Infrastructure.Dapper
{
    public class AppDapperContext
    {
        private readonly string _connectionString;
        public AppDapperContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ECommerceDB")!;
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
