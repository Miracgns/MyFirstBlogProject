using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccesLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-RV4J3FE;database=CoreBlogApiDb; integrated security=true;");
        }
        public DbSet<Employee>  Employees { get; set; }
    }
}
