using E_Commerce_Backend.Application.Repository_Interfaces;


namespace E_Commerce_Backend.Application.UOW_Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Productrepository { get; }
        ICategoryRepository categoryRepository { get; }
        Task SaveAsync();
    }
}
