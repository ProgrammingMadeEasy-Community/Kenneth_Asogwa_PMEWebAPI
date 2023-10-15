using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using PMEWebAPI.Data;
using PMEWebAPI.Data.Interfaces;
using PMEWebAPI.Models;


namespace PMEWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController<TEntity, TRepository> : ControllerBase
         where TEntity : class, IEntity
         where TRepository : IRepository<TEntity>
    {
        private readonly TRepository _context;

        public BaseController(TRepository repository)
        {
            _context = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await _context.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{employeeId}")]
        public async Task<ActionResult<TEntity>> Get(int employeeId)
        {
            var data = await _context.Get(employeeId);
            if (data == null)
            {
                return NotFound();
            }
            return(data);
        }

        // PUT: api/[controller]/5
        [HttpPut("{employeeId}")]
        public async Task<IActionResult> Put(int employeeId, TEntity employee)
        {
            if (employeeId != employee.EmployeeId)
            {
                return BadRequest();
            }
            await _context.Update(employee);
            return Ok("Updated Successfully");
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Create(TEntity employee)
        {
            await _context.Add(employee);
            return Ok("Added Successfully");
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{employeeId}")]
        public async Task<ActionResult<TEntity>> Delete(int employeeId)
        {
            var data = await _context.Delete(employeeId);
            if (data == null)
            {
                return NotFound();
            }
            return Ok("Deleted Successfully");
        }

    }
}
