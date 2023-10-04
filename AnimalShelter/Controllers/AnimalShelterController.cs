using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Linq;

namespace AnimalShelter.Controllers
{
    public class AnimalShelterController : Controller
    {
        public readonly AppDbContext _context;

        public AnimalShelterController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("/")]
        public ActionResult Index()
        {
            // var animals = _context.Animals.ToList();
            // return View(animals);
            return View();
        }
    }
}