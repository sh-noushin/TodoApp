using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.Contract.Core.Dtos.Responses;
using TodoApp.Application.Contract.Users.Dtos.Requests;
using TodoApp.Application.Contract.Users.Dtos.Responses;

namespace TodoApp.Application.Contract.Users
{
    public interface ITodoUserService
    {
        Task CreateAsync(UserCreateRequest input);
        Task UpdateAsync(Guid id, UserUpdateRequest input);
        Task DeleteAsync(Guid id);
        Task<PagedResultResponse<UserResponse>> GettAllAsync(GetUsersRequest filter);
        Task<UserResponse> GetByIdAsync(Guid id);
    }
}
