using E_Commerce_Backend.Application.Product_Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Backend.Application.Service_Interfaces
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        public Task<ProductDto?> GetProductByIdAsync(int id);
        public Task<int> CreateProductAsync(CreateProductDto productDto);
        public Task<bool> UpdateProductAsync(UpdateProductDto productDto);
        public Task<bool> DeleteProductAsync(int id);
    }
}
