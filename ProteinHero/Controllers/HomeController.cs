using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProteinHero.Models;
using System.Collections.Generic;
using System.Diagnostics;
using ProteinHero.Database;
using System;

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
            var products = GetAllproducts();

            return View(products);
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

        public List<Product> GetAllproducts()
        {
            var rows = DatabaseConnector.GetRows("select * from product");

            List<Product> products = new List<Product>();

            foreach (var row in rows)
            {

                Product p = new Product();
                p.Naam = row["naam"].ToString();
                p.Prijs = row["prijs"].ToString();
                p.Beschikbaarheid = Convert.ToInt32(row["beschikbaarheid"]);
                p.Id = Convert.ToInt32(row["id"]);

                products.Add(p);
            }

            return products;

        }



    }

    
}
