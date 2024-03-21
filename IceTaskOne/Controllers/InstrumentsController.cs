using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace IceTaskOne.Controllers
{
    public class InstrumentsController : Controller
    {
        // 
        // GET: /Songs/
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /instruments/Type/ 
        public IActionResult Type(string name, int numIns = 1)
        {
            ViewData["Message"] = "Instrument name: " + name;
            ViewData["NumIns"] = numIns;
            return View();
        }

        
    }
}
