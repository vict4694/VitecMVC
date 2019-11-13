using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VitecMVC.Models;
using System.Net.Http;
using System.Net;

namespace VitecMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private static readonly HttpClient client = new HttpClient();
        [HttpGet]
        public IActionResult Index()
        {

            _logger.LogDebug("Bruger har tilgået Index");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogDebug("Bruger har tilgået Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.LogDebug("Der er sket en pisse fejl");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            _logger.LogDebug("Bruger har tilgået Login");
            return View();
        }

        public IActionResult Produkter()
        {
            _logger.LogDebug("Bruger har tilgået Produkter");
            IEnumerable<Products> products = new List<Products>();
            using (WebClient client = new WebClient())
            {
                var json = client.DownloadString("https://localhost:44364/api/products");
                products = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Products>>(json);
            }
            return View(products);
        }
    }
}
