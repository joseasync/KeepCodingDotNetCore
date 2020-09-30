using System;
using System.Diagnostics;
using System.Linq;
using DotnetCoreLastUpdates.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DotnetCoreLastUpdates.Controllers
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
            var movie = new Movie()
            {
                Title = "Oi",
                Category = "234",
                ReleaseDate = DateTime.Now,
                Id = Guid.NewGuid(),
                Price = 39,
                Rating = 10
            };
            return View();
            
            //return RedirectToAction("Privacy", movie);
        }

        public IActionResult Privacy(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            foreach (var item in ModelState.Values.SelectMany(x => x.Errors))
            {
                Console.WriteLine(item.ErrorMessage);
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}