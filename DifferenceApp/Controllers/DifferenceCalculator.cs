using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferenceApp.Controllers
{
    public class DifferenceCalculator : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        //[Route("DifferenceCalculator/Difference/")]
        public IActionResult Difference(string num1, string num2)
        {
            int intNum1 = Int32.Parse(num1);
            int intNum2 = Int32.Parse(num2);
            int difference = GetDifference(intNum1, intNum2);
            ViewBag.difference = difference;
            return View();
        }
        public static int GetDifference(int num1, int num2)
        {
            int difference = num1 - num2;
            return difference;
        }
    }
}
