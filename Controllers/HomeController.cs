using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Controllers
{
    public class HomeController : Controller
    {
        //localhost:5000/home/index => home/index.cshtml
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            //ViewBag içerisinde değişken tanımlama
            ViewBag.Greeting = saat < 12 ? "Günaydın" : "İyi Günler";

            ViewBag.UserName = "Melih";

            return View();
        }

        //localhost:5000/home/about => home/about.cshtml
        public IActionResult About()
        {
            return View();
        }
    }
}
