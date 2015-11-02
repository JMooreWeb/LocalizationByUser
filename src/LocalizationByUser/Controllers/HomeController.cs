using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalizationByUser.Resources;
using Microsoft.AspNet.Mvc;
using Microsoft.Framework.Localization;

namespace LocalizationByUser.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
