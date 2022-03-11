using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.Contract.Users.Dtos.Responses;
using TodoApp.Domain.Users;

namespace TodoApp.Application.Users
{
    public class UsersMappingProfile : Profile
    {

        public UsersMappingProfile()
        {
            CreateMap<User, UserResponse>();

        }
    }
}