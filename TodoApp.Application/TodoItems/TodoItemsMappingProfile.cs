using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.Contract.TodoItems.Dtos.Responses;
using TodoApp.Domain.TodoItems;

namespace TodoApp.Application.TodoItems
{
    public class TodoItemsMappingProfile:Profile
    {
        public TodoItemsMappingProfile()
        {
            CreateMap<TodoItem, TodoItemResponse>();
        }
    }
}
