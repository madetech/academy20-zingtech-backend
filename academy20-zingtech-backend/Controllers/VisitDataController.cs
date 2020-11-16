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
        // private readonly VisitDatumContext _context;
        //
        // public VisitDataController(VisitDatumContext context)
        // {
        //     _context = context;
        // }

        [HttpGet]
        public ActionResult<List<VisitDatum>> GetAll()
        {
            return new EmptyResult();
            //return _context.VisitData.ToList();
        }
    }
}