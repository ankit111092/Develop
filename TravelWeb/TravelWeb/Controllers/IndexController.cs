using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.Controllers
{
    public class IndexController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult _Menu()
        {
            return PartialView();
        }

        [HttpGet]
        public IActionResult Careers()
        {
            return View();

        }
        [HttpGet]
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}