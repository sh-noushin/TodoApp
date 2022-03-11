using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Categories;
using TodoApp.Domain.TodoItems;
using TodoApp.Domain.Users;
using TodoApp.Domain.Users.Entities;

namespace TodoApp.EntityFrameworkCore
{
    public class TodoAppDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Token> Tokens { get; set; }

        public TodoAppDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>()
                        .HasOne(x => x.Category)
                        .WithMany()
                        .HasForeignKey(x => x.Category.Id).IsRequired();

            modelBuilder.Entity<User>()
               .HasOne(x => x.Token).WithOne().HasForeignKey<Token>(x => x.UserId);

        }
    }
}
