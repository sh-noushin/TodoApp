using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Users.Entities;
using TodoApp.Domain.Users.Exceptions;

namespace TodoApp.Domain.Users
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
                _userRepository=userRepository; 
        }
        public Task<User> CreateAsync(string username, string password)
        {
            var user = new User(username, password);
            return Task.FromResult(user);
        }

        public Task<Token> GenerateTokenAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> LoginAsync(string username, string pasword)
        {
            if (!await _userRepository.AnyAsync(x => x.UserName == username && x.Password == pasword))
            {
                throw new Exception("Invalid username or password");
            }
            return true;
        }

        public async Task<User> UpdateAsync(User user, string password)
        {
            if (await _userRepository.FindAsync(x => x.UserName == user.UserName && x.Password != password) != null)
            {
                throw new UserAlreadyExistsException(user.UserName);
            }

            user.SetPassword(password);
            return user;
        }
    }
}
