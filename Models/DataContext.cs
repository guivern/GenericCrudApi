using Microsoft.EntityFrameworkCore;

namespace GenericCrudApi.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {}
        
         public DbSet<TodoItem> TodoItems { get; set; }
    }
}