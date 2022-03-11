using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.Contract.Authentication.Dtos.Requests;
using TodoApp.Application.Contract.Authentication.Dtos.Responses;

namespace TodoApp.Application.Contract.Authentication
{
    public interface IAuthService
    {
        Task<TokenResponse> LoginAsync(LoginRequest input);
    }
}
