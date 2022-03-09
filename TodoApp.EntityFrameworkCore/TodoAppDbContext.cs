using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Categories;
using TodoApp.Domain.TodoItems;

namespace TodoApp.EntityFrameworkCore
{
    public class TodoAppDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<TodoItem> TodoItems { get; set; }

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
            
        }
    }
}
