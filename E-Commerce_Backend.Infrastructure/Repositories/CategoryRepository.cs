using Dapper;
using E_Commerce_Backend.Application.Repository_Interfaces;
using E_Commerce_Backend.Core.Entities;
using E_Commerce_Backend.Infrastructure.Dapper;

namespace E_Commerce_Backend.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDapperContext _context;
        public CategoryRepository(AppDapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            const string query = "select * from Categories";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<Category>(query);
        }
        public async Task<Category?> GetByIdAsync(int id)
        {
            const string query = "select * from Categories where Id=@Id";
            using var connection = _context.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<Category>(query, new { Id = id });
        }
        public async Task<int> CreateAsync(Category category)
        {
            const string query = "insert into Categories(Name) values(@Name); select cast(scope_identity() as int)";
            using var connection = _context.CreateConnection();
            return await connection.QuerySingleAsync<int>(query, category);
        }
        public async Task<bool> UpdateAsync(Category category)
        {
            const string query = "update Categories set Name=@name where Id=@Id";
            using var connection = _context.CreateConnection();
            var rowsAffected = await connection.ExecuteAsync(query, category);
            return rowsAffected > 0;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            const string query = "delete from Categories where Id=@Id";
            using var connection = _context.CreateConnection();
            var rowsAffected = await connection.ExecuteAsync(query, new { Id = id });
            return rowsAffected > 0;
        }
    
    }
}
