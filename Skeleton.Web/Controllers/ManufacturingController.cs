using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Skeleton.Service;

namespace SimCompanies.Controllers
{
    public class ManufacturingController : Controller
    {
        private readonly SkeletonService _manufacturingService; //This is our service layer where we put all the business logic to make a skinny controller 
        public ManufacturingController(SkeletonService getManufacturingInfo)
        {
            _manufacturingService = getManufacturingInfo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetManufacturingProfit()
        {

            // Call to service layer below which has all our business logic. Notice we dont instantiate the repository or anything in our controller we do that all in the service layer
            var AdminPercentage = _manufacturingService.GetManufacturingProfit();
            return View();
        
        }
            









     
       
    }
}