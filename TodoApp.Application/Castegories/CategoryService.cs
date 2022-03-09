using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.Contract.Categories;
using TodoApp.Application.Contract.Categories.Dtos.Requests;
using TodoApp.Application.Contract.Categories.Dtos.Responses;
using TodoApp.Application.Contract.Core.Dtos.Responses;

namespace TodoApp.Application.Castegories
{
    public class CategoryService : ICategoryService
    {
        public Task CreateAsync(CategoryCreateRequest input)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultResponse<CategoryResponse>> GetAllAsync(GetCategoriesRequest filter)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryResponse> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, CategoryUpdateRequest input)
        {
            throw new NotImplementedException();
        }
    }
}
