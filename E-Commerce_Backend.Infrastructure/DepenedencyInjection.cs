using E_Commerce_Backend.Application.Repository_Interfaces;
using E_Commerce_Backend.Application.UOW_Interface;
using E_Commerce_Backend.Infrastructure.Dapper;
using E_Commerce_Backend.Infrastructure.Repositories;
using E_Commerce_Backend.Infrastructure.UnitofWork;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce_Backend.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<AppDapperContext>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
