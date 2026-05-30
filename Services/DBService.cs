using Dapper;
using Npgsql;
using sharecare_backend.Models.Problem;

namespace sharecare_backend.Services
{
    public class DbService
    {
        private readonly NpgsqlDataSource _dataSource;

        public DbService(NpgsqlDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public async Task<IEnumerable<ProblemEntity>> GetProductsAsync()
        {
            using var connection = await _dataSource.OpenConnectionAsync();
            const string sql = "SELECT id, name, price, created_at AS CreatedAt FROM products";
            return await connection.QueryAsync<Product>(sql);
        }

        public async Task<ProblemDBEntity?> GetProbelemByIdAsync(int id)
        {
            using var connection = await _dataSource.OpenConnectionAsync();
            const string sql = "SELECT id AS Id, name as Name, description AS Description, type_json AS TypeJson, time_json AS TimeJson, is_location_bound AS IsLocationBound, location, payment_json AS PaymentJson, providers_id AS ProvidersId, searchers_id AS SearchersId FROM products WHERE id = @Id";
            return await connection.QueryFirstOrDefaultAsync<ProblemDBEntity>(sql, new { Id = id });
        }

        // Example 3: Executing a command (Insert/Update/Delete)
        public async Task<int> CreateProductAsync(Product product)
        {
            using var connection = await _dataSource.OpenConnectionAsync();
            const string sql = """
            INSERT INTO products (name, price) 
            VALUES (@Name, @Price) 
            RETURNING id;
            """;
            return await connection.ExecuteScalarAsync<int>(sql, product);
        }
    }
}
