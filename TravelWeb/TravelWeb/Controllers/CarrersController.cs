using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.Controllers
{
    public class CarrersController : Controller
    {
        public IActionResult Carrers()
        {
            return View();
        }
    }
}