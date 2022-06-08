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

        [Route("contact")]
        [HttpPost]
        public IActionResult Contact(Person person)
        {
            if (ModelState.IsValid)
                return Redirect("/Succes");

            return View(person);
        }

        [Route("Succes")]
        public IActionResult Succes()
        {

            return View();
        }


        [Route("succes")]

        public IActionResult Succes()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public List<Product> GetAllproducts()
        {
            var rows = DatabaseConnector.GetRows("select * from producten");

            List<Product> products = new List<Product>();

            foreach (var row in rows)
            {

                Product p = new Product();
                p.Naam = row["naam"].ToString();
                p.Beschrijving = row["beschrijving"].ToString();
                p.Info= row["product informatie"].ToString();
                p.Img = row["img"].ToString();
                p.Id = Convert.ToInt32(row["id"]);

                products.Add(p);
            }

            return products;

        }



    }

    
}
