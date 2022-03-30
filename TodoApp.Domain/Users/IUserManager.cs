using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Users.Entities;

namespace TodoApp.Domain.Users
{
    public interface IUserManager
    {
        Task<User> CreateAsync(string username, string password);
        Task<User> UpdateAsync(User user, string password);
        Task<bool> LoginAsync(string username, string pasword);
        Task<Token> GenerateTokenAsync(User user);
    }
}
