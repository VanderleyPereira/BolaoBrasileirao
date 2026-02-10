using Microsoft.AspNetCore.Mvc;
using BolaoBrasileirao.Data;
using System.Linq;

namespace BolaoBrasileirao.Controllers
{
    public class RodadasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RodadasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Rodadas.ToList());
        }
    }
}
