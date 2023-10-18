using LearningGrpc.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningGrpc.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ToDoItem> ToDoItems => Set<ToDoItem>();
    }
}
