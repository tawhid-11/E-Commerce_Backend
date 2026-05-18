using E_Commerce_Backend.Application.Repository_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Backend.Application.UOW_Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Productrepository { get; }
        ICategoryRepository categoryRepository { get; }
        Task SaveAsync();
    }
}
