using Microsoft.EntityFrameworkCore;
using PMEWebAPI.Models;

namespace PMEWebAPI.Data.Core
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}
