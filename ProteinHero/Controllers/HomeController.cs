using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProteinHero.Models;
using System.Collections.Generic;
using System.Diagnostics;
using ProteinHero.Database;

namespace ProteinHero.Controllers
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
            var rows = DatabaseConnector.GetRows("select * from product");

            List<string> names = new List<string>();

            foreach (var row in rows)

            {
                names.Add(row["naam"].ToString());               
            }

            return View(names);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [Route("contact")]
        public IActionResult Contact(Person person)
        {
            return View(person);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
