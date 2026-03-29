using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MVCSportsApp.Models;
using System.Diagnostics;
using MVCSportsApp.Services;

namespace MVCSportsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;
        private readonly SportsDataService _sportsData;

        public HomeController(ILogger<HomeController> logger, SportsDataService sportsData)
        {
            _logger = logger;
            _sportsData = sportsData;
            
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult NBA()
        {
            // Just returns the empty HTML shell. JavaScript does the rest!
            return View();
        }

        //addNFL method to return the NFL view
        public IActionResult NFL()
        {
            // Just returns the empty HTML shell. JavaScript does the rest!
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
