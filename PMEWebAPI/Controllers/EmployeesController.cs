using Microsoft.AspNetCore.Mvc;
using PMEWebAPI.Data;
using PMEWebAPI.Data.Core;
using PMEWebAPI.Models;

namespace PMEWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : BaseController<Employee, EmployeeRepository>
    {
        public EmployeesController(EmployeeRepository repository) : base(repository)
        {

        }
    }
}
