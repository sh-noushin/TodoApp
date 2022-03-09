using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.Contract.Core.Dtos.Requests;

namespace TodoApp.Application.Contract.TodoItems.Dtos.Requests
{
    public class GetTodoItemsRequest : PagedAndSorted
    {

        public string FilterText { get; set; }
    }
}
