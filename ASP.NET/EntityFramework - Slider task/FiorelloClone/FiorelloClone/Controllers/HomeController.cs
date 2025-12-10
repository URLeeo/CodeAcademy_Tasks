using FiorelloClone.Data;
using FiorelloClone.Models;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloClone.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
    }
}
