using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Categories.Exceptions;

namespace TodoApp.Domain.Categories
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryrepository)
        {
            _categoryRepository = categoryrepository;
        }
        public async Task<Category> CreateAsync(string name)
        {
           if(await _categoryRepository.GetByNameAsync(name) == null)
            {
                throw new CategoryAlreadyExistsException(name);
            }

           var category = new Category(name);
            return category;    
        }

        public async Task<Category> UpdateAsync(Category category, string name)
        {
            if(await _categoryRepository.FindAsync(x=> x.Name == name && x.Id != category.Id) != null)
            {
                throw new CategoryAlreadyExistsException(name);
            }

            category.SetName(name);
            return category;
        }
    }
}
