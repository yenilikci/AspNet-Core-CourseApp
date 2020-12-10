using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Controllers
{
    //localhost:5000/course
    public class CourseController:Controller
    {
        //action methods

        //localhost:5000/course/index => course/index.cshtml
        public IActionResult Index()
        {
            return View();
        }

        //localhost:5000/course/list => course/list.cshtml
        public IActionResult List()
        {
            return View();
        }

    }
}
