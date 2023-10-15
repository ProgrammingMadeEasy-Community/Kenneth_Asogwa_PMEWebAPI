using PMEWebAPI.Models;

namespace PMEWebAPI.Data.Core
{
    public class EmployeeRepository : Repository<Employee, ApplicationDbContext>
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
