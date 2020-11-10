using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContentInsuranceMVC.Models;

namespace ContentInsuranceMVC.Controllers
{
    /// <summary>
    /// This is the home controller. 
    /// </summary>
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "InsuredItems");
        }

        public IActionResult About()
        {
           return View();
        }

        public IActionResult Contact()
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
