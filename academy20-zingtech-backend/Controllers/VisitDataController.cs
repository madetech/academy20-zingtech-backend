using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using academy20_zingtech_backend.Models;
using System.Threading.Tasks;

namespace academy20_zingtech_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitDataController : ControllerBase
    {
        private readonly EmployeeDatumContext _context;

        public VisitDataController(EmployeeDatumContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public ActionResult<List<VisitDatum>> GetAll()
        {
            return new EmptyResult();
            //return _context.VisitData.ToList();
        }
        
        [HttpGet("{id}", Name = "GetVisit")]
        public ActionResult<VisitDatum> GetById(int id)
        {
            var item = _context.VisitData.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
        
        [HttpPost]
        public async Task<ActionResult<VisitDatum>> PostVisitDatum(VisitDatum visitDatum)
        {
            _context.VisitData.Add(visitDatum);
            await _context.SaveChangesAsync();
            
            return CreatedAtAction(nameof(GetById), new { id = visitDatum.Id }, visitDatum);
        }
    }
}