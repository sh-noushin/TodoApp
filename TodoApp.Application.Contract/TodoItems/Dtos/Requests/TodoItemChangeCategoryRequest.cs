using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Application.Contract.TodoItems.Dtos.Requests
{
    public class TodoItemChangeCategoryRequest
    {
        public Guid CategoryId { get; set; }
    }
}
