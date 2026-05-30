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

        public async Task<IEnumerable<ProblemDBEntity>> GetProblemsAsync()
        {
            using var connection = await _dataSource.OpenConnectionAsync();
            const string sql = "SELECT id AS Id, name as Name, description AS Description, type_json AS TypeJson, time_json AS TimeJson, is_location_bound AS IsLocationBound, location, payment_json AS PaymentJson, providers_id AS ProvidersId, searchers_id AS SearchersId FROM products";
            return await connection.QueryAsync<ProblemDBEntity>(sql);
        }

        public async Task<ProblemDBEntity?> GetProbelemByIdAsync(int id)
        {
            using var connection = await _dataSource.OpenConnectionAsync();
            const string sql = "SELECT id AS Id, name as Name, description AS Description, type_json AS TypeJson, time_json AS TimeJson, is_location_bound AS IsLocationBound, location, payment_json AS PaymentJson, providers_id AS ProvidersId, searchers_id AS SearchersId FROM products WHERE id = @Id";
            return await connection.QueryFirstOrDefaultAsync<ProblemDBEntity>(sql, new { Id = id });
        }

        public async Task<int> CreateProblemAsync(ProblemDBEntity problem)
        {
            using var connection = await _dataSource.OpenConnectionAsync();
            const string sql = """
            INSERT INTO problems (name, description, type_json, time_json, is_location_bound, location, payment_json, providers_id, searchers_id) 
            VALUES (@Name, @Description, @TypeJson, @TimeJson, @IsLocationBound, @Location, @PaymentJson, @ProvidersId, @SearchersId) 
            RETURNING id;
            """;
            return await connection.ExecuteScalarAsync<int>(sql, problem);
        }
    }
}
