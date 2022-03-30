using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.Contract.Categories;
using TodoApp.Application.Contract.Categories.Dtos.Requests;
using TodoApp.Application.Contract.Categories.Dtos.Responses;
using TodoApp.Application.Contract.Core.Dtos.Responses;
using TodoApp.Domain.Categories;
using TodoApp.Domain.Categories.Exceptions;
using TodoApp.Domain.TodoItems;

namespace TodoApp.Application.Castegories
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryRepository _categoryRepository;
        private readonly ITodoItemRepository _todoItemRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryrepository, IMapper mapper, ITodoItemRepository todoItemRepository)
        {
            _categoryRepository = categoryrepository;
            _mapper = mapper;
            _todoItemRepository = todoItemRepository;
        }

        public CategoryService()
        {

        }

        public async Task CreateAsync(CategoryCreateRequest input)
        {
            var category = new Category(input.Name);
            if (await _categoryRepository.AnyAsync(x => x.Name == category.Name))
            {
                throw new CategoryAlreadyExistsException(category.Name);
            }
            await _categoryRepository.CreateAsync(category);
        }
            
        public  async Task DeleteAsync(Guid id)
        {
            await _categoryRepository.DeleteAsync(id);
        }

        public async Task<PagedResultResponse<CategoryResponse>> GetAllAsync(GetCategoriesRequest filter)
        {
            long totalCount = await _categoryRepository.GetCountAsync(filter.FilterText);

            var items = await _categoryRepository.GetAllAsync(
                filter.FilterText,
                filter.Sorting,
                filter.SkipCount,
                filter.MaxResultCount);
            return new PagedResultResponse<CategoryResponse>()
            {
                TotalCount = totalCount,
                Items = _mapper.Map<List<Category>, List<CategoryResponse>>(items)
            };
        }

        public async Task<CategoryResponse> GetByIdAsync(Guid id)
        {
            return _mapper.Map<Category, CategoryResponse>(await _categoryRepository.GetAsync(id));
        }

        public async Task UpdateAsync(Guid id, CategoryUpdateRequest input)
        {
            var category = await _categoryRepository.GetAsync(id);
            if (category == null)
            {
                throw new CategoryNotFoundException(id);

            }
            if (await _categoryRepository.AnyAsync(x => x.Id != id & x.Name == input.Name))
            {
                throw new CategoryAlreadyExistsException(input.Name);
            }

            category.SetName(input.Name);
            await _categoryRepository.UpdateAsync(category);
        }
    }
}
