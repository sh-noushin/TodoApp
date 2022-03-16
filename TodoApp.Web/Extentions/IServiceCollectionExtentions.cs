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
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<ITodoItemService, TodoItemService>();
            services.AddScoped<ITodoItemManager, TodoItemManager>();
            services.AddScoped<ITodoItemRepository, TodoItemRepository>();

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ITodoUserService, TodoUserService>();
            services.AddScoped<IUserManager, UserManager>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddAutoMapper(typeof(TodoApp.Application.Users.UsersMappingProfile).Assembly);
            services.AddAutoMapper(typeof(TodoApp.Application.Castegories.CategoriesMappingProfile).Assembly);
            services.AddAutoMapper(typeof(TodoApp.Application.TodoItems.TodoItemsMappingProfile).Assembly);









            return services;
        }

    }
}
