using edumedia.uz.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace edumedia.uz.Controllers
{
    public class SpeakersController : Controller
    { 
        private readonly ILogger<SpeakersController> _logger;
        public SpeakersController(ILogger<SpeakersController> logger)
        {
            _logger = logger;
        }
        public IActionResult Speakers()
        {
            return View();
        }
        public IActionResult SpeakersDetail() 
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