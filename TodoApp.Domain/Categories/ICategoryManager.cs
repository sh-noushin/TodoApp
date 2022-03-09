using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Domain.Categories
{
    public interface ICategoryManager
    {
        Task<Category> CreateAsync(string name);
        Task<Category> UpdateAsync(Category category, string name);

    }
}
