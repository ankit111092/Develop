using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.Controllers
{
    public class AboutUSController : Controller
    {
        public IActionResult AboutUS()
        {
            return View();
        }


        public IActionResult Test()
        {
            return View();
        }
    }
}