using Microsoft.AspNetCore.Mvc;
using P138FirstDBMigration.DataAccestLayer;

namespace P138FirstDBMigration.Controllers
{
    public class ModelController : Controller
    {
        private readonly AppDbContext _context;
        public ModelController(AppDbContext context) 
        {
            _context= context;
        }
        public IActionResult Index(int? id)
        {
            if (id == null) return BadRequest();

            if(!_context.Models.Any(m=>m.MarkaId==id)) return NotFound();


            return View(_context.Models.Where(m => m.MarkaId == id).ToList());
        }

        
    }

    
}
