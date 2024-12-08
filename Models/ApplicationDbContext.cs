using Microsoft.EntityFrameworkCore;

namespace EFDemo.Models
{
    public class ApplicationDbContext:DbContext
    {

        //override confoguration that we need at app level
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        
        }

        // LINQ  --> conversion DBset --> SQL  -> exec
        // Entity <Employee> 

        public DbSet<Employee> Employees { get; set; }
    }
}
