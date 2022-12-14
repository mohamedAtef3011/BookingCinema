using BookingCinema.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookingCinema.Controllers
{
    public class ActorsController : Controller
    {

        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {   
            var data = _context.Actors;
            return View(data);
        }
    }
}
