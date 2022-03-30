
using TodoApp.Domain.Categories.Exceptions;
using TodoApp.Domain.Core;
using TodoApp.Domain.Shared.Categories;

namespace TodoApp.Domain.Categories
{
    public class Category:BaseEntity<Guid>
    {
        public string Name { get;private set; }

        private Category()
        {

        }

        public Category(string name)
        {
            SetName(name);
        }

        public void SetName(string name)
        {
            if(name.Length > CategoryConsts.NameMaxLength)
            {
                throw new CategoryNameLengthException();
            }
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new CategoryNameIsNullOrWhiteSpaceException();
            }

            Name = name;    
        }
    }
}
