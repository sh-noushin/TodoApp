using TodoApp.Application.Authentication;
using TodoApp.Application.Castegories;
using TodoApp.Application.Contract.Authentication;
using TodoApp.Application.Contract.Categories;
using TodoApp.Application.Contract.TodoItems;
using TodoApp.Application.Contract.Users;
using TodoApp.Application.TodoItems;
using TodoApp.Application.Users;
using TodoApp.Domain.Categories;
using TodoApp.Domain.TodoItems;
using TodoApp.Domain.Users;
using TodoApp.EntityFrameworkCore.Categories;
using TodoApp.EntityFrameworkCore.TodoItems;
using TodoApp.EntityFrameworkCore.Users;

namespace TodoApp.Web.Extentions
{
    public static class IServiceCollectionExtentions
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ITodoItemService, TodoItemService>();
            services.AddScoped<ITodoUserService, TodoUserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserManager, UserManager>();


            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ITodoItemRepository, TodoItemRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }

    }
}
