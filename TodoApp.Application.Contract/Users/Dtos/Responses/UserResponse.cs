using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Users.Entities;

namespace TodoApp.Application.Contract.Users.Dtos.Responses
{
    public class UserResponse
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
       
    }
}
