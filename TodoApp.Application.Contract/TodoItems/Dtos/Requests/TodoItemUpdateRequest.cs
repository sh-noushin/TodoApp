using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Application.Contract.TodoItems.Dtos.Requests
{
    public class TodoItemUpdateRequest
    {
        public string Title { get; set; }
        public bool Done { get; set; }
        public string Description { get; set; }
    }
}
