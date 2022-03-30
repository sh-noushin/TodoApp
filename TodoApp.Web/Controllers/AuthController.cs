using Microsoft.AspNetCore.Mvc;
using TodoApp.Application.Contract.Authentication;
using TodoApp.Application.Contract.Authentication.Dtos.Requests;
using TodoApp.Application.Contract.Authentication.Dtos.Responses;

namespace TodoApp.Web.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AuthController
    {
        private readonly IAuthService _service;

        public AuthController(IAuthService service)
        {
            _service = service;
        }

        [HttpPost]
        public Task<TokenResponse> LoginAsync(LoginRequest input)
        {
            return _service.LoginAsync(input);
        }

    }
}
