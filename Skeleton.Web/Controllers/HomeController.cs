using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;



namespace SimCompanies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       


        public IActionResult Index()
        {
           
            //var getProducts = _context.PriceMonitors.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
