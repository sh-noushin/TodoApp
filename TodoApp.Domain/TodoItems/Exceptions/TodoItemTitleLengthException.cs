using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Shared.TodoItems;

namespace TodoApp.Domain.TodoItems.Exceptions
{
    public class TodoItemTitleLengthException : Exception
    {
        public TodoItemTitleLengthException()
            : base($"TodoItem title length exceeds {TodoItemConsts.MaxTitleMaxLength} charachters.")
        {

        }


    }
}
