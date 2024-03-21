using IceTaskOne.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IceTaskOne.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Instruments()
        {
            return View();
        }

        public IActionResult DisplayImage(string imageName)
        {
            // Replace "Images" with the folder name containing your images
            var imagePath = Path.Combine("/Images", imageName);
            return File(imagePath, "image/jpeg");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
