using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using academy20_zingtech_backend.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace academy20_zingtech_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDataController : ControllerBase
    {
        private readonly EmployeeDatumContext _context;

        public EmployeeDataController(EmployeeDatumContext context)
        {
            _context = context;
            // if (_context.EmployeeData.Count() == 0)
            // {
            //     _context.EmployeeData.Add(new EmployeeDatum {Id = 1});
            //     _context.SaveChanges();
            // }
        }
        
        [HttpGet]
        [Authorize]
        public ActionResult<List<EmployeeDatum>> GetAll()
        {
            return _context.EmployeeData.ToList();
        }
        [HttpGet("{id}", Name = "GetTodo")]
        public ActionResult<EmployeeDatum> GetById(int id)
        {
            var item = _context.EmployeeData.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
        [HttpPost]
        public async Task<ActionResult<EmployeeDatum>> PostEmployeeDatum(EmployeeDatum employeeDatum)
        {
            _context.EmployeeData.Add(employeeDatum);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetById), new { id = employeeDatum.Id }, employeeDatum);
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmployeeDatum>> DeleteEmployeeDatum(long id)
        {
            var employeeDatum = await _context.EmployeeData.FindAsync(id);
            if (employeeDatum == null)
            {
                return NotFound();
            }

            _context.EmployeeData.Remove(employeeDatum);
            await _context.SaveChangesAsync();

            return employeeDatum;
        }
    }


}