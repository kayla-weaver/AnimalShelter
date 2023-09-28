using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Solution;
using System.Linq;

namespace AnimalShelter.Solution.Controllers
{
    public class AnimalController : Controller
    {
        public readonly AppContext_context:

        public AnimalController(appDbContext context)
        {
            _context = context;
        }

        Public IActionResult Index()
        {
            var animals = _context.Animals.Orderby(a => a.DateOfAdmittance)
            return View(animals);
        }
    }
}