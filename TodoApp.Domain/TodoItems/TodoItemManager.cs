using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.TodoItems.Exceptions;

namespace TodoApp.Domain.TodoItems
{
    public class TodoItemManager : ITodoItemManager

     {
        private readonly ITodoItemRepository _repository;

        public TodoItemManager(ITodoItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<TodoItem> ChangeCategoryAsync(Guid newCategoryId, TodoItem input)
        {
            if(await _repository.FindAsync(x => x.CategoryId == newCategoryId && x.Title == input.Title) !=null)
            {
                throw new TodoItemCannotBeMovedToAnotherCategoryException(newCategoryId,input.Title);
            }

            input.SetCategory(newCategoryId);
            return input;
            
        }

        public async Task<TodoItem> CreateAsync(Guid categoryId, string title, string description, bool done)
        {
            if (await _repository.GetByTitleAsync(title) != null)
            {
                throw new TodoItemAlreadyExistsException(title);
            }
            var todoitem = new TodoItem(title, categoryId);
            todoitem.Description = description;
            todoitem.Done = done;   
            return todoitem;

        }

        public async Task<TodoItem> UpdateAsync(TodoItem input, string title, string description, bool done)
        {
            if( await _repository.FindAsync(x => x.Title == title
                && x.Id != input.Id && 
                x.CategoryId == input.CategoryId) 
                !=null)
            {
                throw new TodoItemAlreadyExistsException(title);
            }

            input.SetTitle(title);    
            input.Description = description; 
            input.Done = done;
            return input;
        }
    }
}
