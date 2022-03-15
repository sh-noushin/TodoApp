using Microsoft.AspNetCore.Mvc;
using TodoApp.Application.Contract.Core.Dtos.Responses;
using TodoApp.Application.Contract.TodoItems;
using TodoApp.Application.Contract.TodoItems.Dtos.Requests;
using TodoApp.Application.Contract.TodoItems.Dtos.Responses;

namespace TodoApp.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoItemsController
    {
        private readonly ITodoItemService _todoitemService;

        public TodoItemsController(ITodoItemService todoItemService)

        {
            _todoitemService = todoItemService;
        }
        [HttpPost]
        public async Task<string> CreateAsync(TodoItemCreateRequest input)
        {
            await _todoitemService.CreateAsync(input);
            return Task.FromResult("Created").ToString();

        }

        [HttpGet]
        [Route("{id}")]
        public async Task<TodoItemResponse> GetByIdAsync(Guid id)
        {
            return await _todoitemService.GetByIdAsync(id);
        }
        [HttpGet]
        public async Task<PagedResultResponse<TodoItemResponse>> GetAllAsync([FromQuery] GetTodoItemsRequest input)
        {
            return await _todoitemService.GetAllAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<string> UpdateASync(Guid id, TodoItemUpdateRequest input)
        {
            await _todoitemService.UpdateAsync(id, input);
            return Task.FromResult("Updated").ToString();


        }
    }
}
