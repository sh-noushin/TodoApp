using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Shared;

namespace TodoApp.Domain.Users.Exceptions
{
    public class PasswordLengthException : Exception
    {

        public PasswordLengthException()
            : base($"Password length must be at least {UserConsts.PasswordMinLength} charachters.")
        {

        }
    }
}
