using employee_admin_portal.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace employee_admin_portal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
