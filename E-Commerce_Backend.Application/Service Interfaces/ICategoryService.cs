using E_Commerce_Backend.Application.Category_Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Backend.Application.Service_Interfaces
{
    public interface ICategoryService
    {
        public Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync();
        public Task<CategoryDto?> GetCategoryByIdAsync(int id);
        public Task<int> CreateCategoryAsync(CreateCategoryDto categoryDto);
        public Task<bool> UpdateCategoryAsync(UpdateCategoryDto categoryDto);
        public Task<bool> DeleteCategoryAsync(int id);
    }
}
