using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.Contract.Core.Dtos.Responses;
using TodoApp.Application.Contract.TodoItems.Dtos.Requests;
using TodoApp.Application.Contract.TodoItems.Dtos.Responses;

namespace TodoApp.Application.Contract.TodoItems
{
    public interface ITodoItemService
    {
        public Task CreateAsync(TodoItemCreateRequest input);
        public Task DeleteAsync(Guid id);
        public Task UpdateAsync(Guid id, TodoItemUpdateRequest input);
        public Task<TodoItemResponse> GetByIdAsync(Guid id);
        public Task ChangeCategoryAsync(Guid id, TodoItemChangeCategoryRequest input);
        public Task<PagedResultResponse<TodoItemResponse>> GetAllAsync(GetTodoItemsRequest input);

    }
}
