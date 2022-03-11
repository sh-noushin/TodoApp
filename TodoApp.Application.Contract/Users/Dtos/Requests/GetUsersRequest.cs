using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.Contract.Core.Dtos.Requests;

namespace TodoApp.Application.Contract.Users.Dtos.Requests
{
    public class GetUsersRequest : PagedAndSorted
    {

        public string FilterText { get; set; }
    }
}
