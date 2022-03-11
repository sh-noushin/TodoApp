using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.Contract.Authentication;
using TodoApp.Application.Contract.Authentication.Dtos.Requests;
using TodoApp.Application.Contract.Authentication.Dtos.Responses;
using TodoApp.Domain.Users;

namespace TodoApp.Application.Authentication
{
    public class AuthService : IAuthService
    {

        private readonly IUserRepository _repository;
        private readonly UserManager _userManager;

        public AuthService(IUserRepository repository, UserManager userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        public async Task<TokenResponse> LoginAsync(LoginRequest input)
        {
            await _userManager.LoginAsync(input.Username, input.Password);
            var user = await _repository.GetByUsername(input.Username);
            var token = await _userManager.GenerateTokenAsync(user);
            return new TokenResponse
            {
                Value = token.Value
            };
        }
    }
}
