using Microsoft.AspNetCore.Mvc;
using P138FirstDBMigration.DataAccestLayer;

namespace P138FirstDBMigration.Controllers
{
    public class CarController : Controller
    {
        private readonly AppDbContext _context;
        public CarController(AppDbContext context) 
        {
            _context= context;
        }
        public IActionResult Index()
        {
            return View(_context);
        }
    }
}
