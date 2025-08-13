using DietConTrungWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DietConTrungWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Booking() => View();
        public IActionResult Team() => View();
        public IActionResult Testimonial() => View();
        public IActionResult Lienhe() => View();
        public IActionResult NotFound() => View("404");
        public IActionResult QuyTrinh() => View();
        public IActionResult DietMoi() => View();
        public IActionResult DietGian() => View();
        public IActionResult DietMuoi() => View();
        public IActionResult DietRuoi() => View();
        public IActionResult KiemSoatChuot() => View();
        public IActionResult KiemSoatTongHop() => View();

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
