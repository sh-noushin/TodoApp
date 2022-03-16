using Microsoft.AspNetCore.Mvc;
using TodoApp.Application.Contract.Core.Dtos.Responses;
using TodoApp.Application.Contract.Users;
using TodoApp.Application.Contract.Users.Dtos.Requests;
using TodoApp.Application.Contract.Users.Dtos.Responses;

namespace TodoApp.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
         private readonly ITodoUserService _userService;


        public UsersController(ITodoUserService userservice)
        {
            _userService = userservice;

        }

        [HttpPost]
        public async Task<string> CreateAsync(UserCreateRequest input)
        {
                await _userService.CreateAsync(input);
            return Task.FromResult("Created").ToString();
        }

       [HttpGet]
       public async Task<PagedResultResponse<UserResponse>> GetAllAsync([FromQuery] GetUsersRequest input)
        {
            return await _userService.GettAllAsync(input);

        }



        [HttpGet]
        [Route("{id}")]
        public async Task<UserResponse> GetByIdAsync(Guid id)
        {
            return await _userService.GetByIdAsync(id);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<string> UpdateAsync(Guid id, UserUpdateRequest input)
        {
            await _userService.UpdateAsync(id, input);
            return Task.FromResult("Updated").ToString();

        }


        [HttpDelete]
        [Route("{id}")]
        public async Task<string> DeleteAsync(Guid id)
        {
            await _userService.DeleteAsync(id);
            return Task.FromResult("Deleted").ToString();
        }


    }
}
