using E_Commerce_Backend.Application.Repository_Interfaces;
using E_Commerce_Backend.Application.UOW_Interface;
using E_Commerce_Backend.Infrastructure.Dapper;

namespace E_Commerce_Backend.Infrastructure.UnitofWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDapperContext _context;


        public IProductRepository Productrepository { get; }
        public ICategoryRepository categoryRepository { get; }
        public UnitOfWork(AppDapperContext context, IProductRepository productrepository, ICategoryRepository categoryRepository)
        {
            this._context = context;
            this.Productrepository = productrepository;
            this.categoryRepository = categoryRepository;
        }
        public Task SaveAsync()
        {
            // Dapper usually auto-save kore
            return Task.CompletedTask;
        }

        public void Dispose()
        {
        }

    }
}
