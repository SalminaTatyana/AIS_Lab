using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIS_Lab.Controllers
{
    public class SectionsOfTheSIteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
