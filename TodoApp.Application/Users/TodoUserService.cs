using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.Contract.Core.Dtos.Responses;
using TodoApp.Application.Contract.Users;
using TodoApp.Application.Contract.Users.Dtos.Requests;
using TodoApp.Application.Contract.Users.Dtos.Responses;
using TodoApp.Domain.Users;
using TodoApp.Domain.Users.Exceptions;

namespace TodoApp.Application.Users
{
    public class TodoUserService : ITodoUserService
    {

        private readonly IUserRepository _userRepository;
        private readonly IUserManager _manager;
        private readonly IMapper _mapper;

        public TodoUserService(IUserRepository categoryrepository, IUserManager manager, IMapper mapper )
        {
            _userRepository = categoryrepository;
            _manager = manager;
            _mapper = mapper;

        }
        public async Task CreateAsync(UserCreateRequest input)
        {
            var user =await _manager.CreateAsync(input.UserName, input.Password);
            if (await _userRepository.AnyAsync(x => x.UserName == user.UserName))
            {
                throw new UserAlreadyExistsException(user.UserName);
            }
            await _userRepository.CreateAsync(user);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<UserResponse> GetByIdAsync(Guid id)
        {
            return _mapper.Map<User, UserResponse>(await _userRepository.GetAsync(id));
        }

        public async Task<PagedResultResponse<UserResponse>> GettAllAsync(GetUsersRequest filter)
        {
            long totalCount = await _userRepository.GetCountAsync(filter.FilterText);

            var items = await _userRepository.GetAllAsync(
                filter.FilterText,
                filter.Sorting,
                filter.SkipCount,
                filter.MaxResultCount);
            return new PagedResultResponse<UserResponse>()
            {
                TotalCount = totalCount,
                Items = _mapper.Map<List<User>, List<UserResponse>>(items)
            };
        }

        public async Task UpdateAsync(Guid id, UserUpdateRequest input)
        {
            var user = await _userRepository.GetAsync(id);
            if (user == null)
            {
                throw new UserNotFoundException(id);

            }
            if (await _userRepository.AnyAsync(x => x.Id != id & x.UserName == input.Password))
            {
                throw new UserAlreadyExistsException(id);
            }

           
            user.SetPassword(input.Password);
            await _userRepository.UpdateAsync(user);
        }
    }
}
