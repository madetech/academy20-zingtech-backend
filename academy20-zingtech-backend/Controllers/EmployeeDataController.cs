using Microsoft.AspNetCore.Mvc; 
using System.Collections.Generic; 
using System.Linq; 
using academy20_zingtech_backend.Models;

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
            if (_context.EmployeeData.Count() == 0)
            {
                _context.EmployeeData.Add(new EmployeeDatum {Id = 1});
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public ActionResult<List<EmployeeDatum>> GetAll() 
        { 
            return _context.EmployeeData.ToList(); 
        } 
        [HttpGet("{id}", Name = "GetTodo")] 
        public ActionResult<EmployeeDatum> GetById(long id) 
        {    
            var item = _context.EmployeeData.Find(id);     
            if (item == null)    
            {         
                return NotFound();     
            }     
            return item; 
        }
    }
    
    
}