using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.Contract.Categories.Dtos.Requests;
using TodoApp.Application.Contract.Categories.Dtos.Responses;
using TodoApp.Application.Contract.Core.Dtos.Responses;

namespace TodoApp.Application.Contract.Categories
{
    public interface ICategoryService
    {
        Task CreateAsync(CategoryCreateRequest input);
        Task UpdateAsync(Guid id, CategoryUpdateRequest input);
        Task DeleteAsync(Guid id);
        Task<PagedResultResponse<CategoryResponse>> GetAllAsync(GetCategoriesRequest filter);   
        Task<CategoryResponse> GetByIdAsync(Guid id);
    }
}
