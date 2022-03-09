using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Domain.TodoItems
{
    public interface ITodoItemManager
    {
        Task<TodoItem> CreateAsync(Guid categoryId, string title, string description, bool done);
        Task<TodoItem> UpdateAsync(TodoItem input, string title, string description, bool done);
        Task<TodoItem> ChangeCategoryAsync(Guid newCategoryId, TodoItem input);
    }
}
