using CodeFirstDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace CodeFirstDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op) 
        {
        
        }
        public DbSet<Employee> Employees { get; set; }
    }

}

    

