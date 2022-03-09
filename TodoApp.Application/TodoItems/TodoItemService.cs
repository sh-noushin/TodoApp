using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.Contract.Core.Dtos.Responses;
using TodoApp.Application.Contract.TodoItems;
using TodoApp.Application.Contract.TodoItems.Dtos.Requests;
using TodoApp.Application.Contract.TodoItems.Dtos.Responses;

namespace TodoApp.Application.TodoItems
{
    public class TodoItemService : ITodoItemService
    {
        public Task ChangeCategoryAsync(Guid id, TodoItemChangeCategoryRequest input)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(TodoItemCreateRequest input)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultResponse<TodoItemResponse>> GetAllAsync(GetTodoItemsRequest input)
        {
            throw new NotImplementedException();
        }

        public Task<TodoItemResponse> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, TodoItemUpdateRequest input)
        {
            throw new NotImplementedException();
        }
    }
}
