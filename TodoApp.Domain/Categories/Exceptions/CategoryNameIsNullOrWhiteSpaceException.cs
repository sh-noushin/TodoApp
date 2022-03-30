using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Domain.Categories.Exceptions
{
    internal class CategoryNameIsNullOrWhiteSpaceException:Exception
    {
        public CategoryNameIsNullOrWhiteSpaceException()
            :base("Category name could not be empty or whitespace.")
        {

        }       
    }
}
