using Microsoft.AspNetCore.Mvc;
using TodoApp.Application.Contract.Categories;
using TodoApp.Application.Contract.Categories.Dtos.Requests;
using TodoApp.Application.Contract.Categories.Dtos.Responses;
using TodoApp.Application.Contract.Core.Dtos.Responses;

namespace TodoApp.Web.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CategoriesController: ControllerBase

    {

        private readonly ICategoryService _categoryService;


        public CategoriesController(ICategoryService categoryservice)
        {
            _categoryService = categoryservice;

        }


        [HttpPost]
        public async Task<string> CreateAsync(CategoryCreateRequest input)
        {
            await _categoryService.CreateAsync(input);
            return Task.FromResult("Created").ToString();
        }
        [HttpGet]
        public async Task<PagedResultResponse<CategoryResponse>> GetAllAsync([FromQuery] GetCategoriesRequest input)
        {
            return await _categoryService.GetAllAsync(input);

        }
        [HttpGet]
        [Route("{id}")]
        public async Task<CategoryResponse> GetByIdAsync(Guid id)
        {
            return await _categoryService.GetByIdAsync(id);
        }


        [HttpPut]
        [Route("{id}")]
        public async Task<string> UpdateAsync(Guid id, CategoryUpdateRequest input)
        {
            await _categoryService.UpdateAsync(id, input);
            return Task.FromResult("Updated").ToString();

        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<string> DeleteAsync(Guid id)
        {
            await _categoryService.DeleteAsync(id);
            return Task.FromResult("Deleted").ToString();
        }

    }
}
