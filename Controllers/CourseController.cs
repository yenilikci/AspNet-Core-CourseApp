using CourseApp.Models;
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

        //başvuru formu için - localhost:5000/course/apply
        public IActionResult Apply()
        {
            return View();
        }

        public IActionResult Details()
        {
            //name: Core Mvc Kursu
            //description: Faydalı bir kurstur.
            //isPublished: true

            //model nesnesi
            var course = new Course();
            course.Name = "Core Mvc Kursu";
            course.Description = "Faydalı bir kurstur.";
            course.isPublished = true;

            return View(course);
        }


        //localhost:5000/course/list => course/list.cshtml
        public IActionResult List()
        {
            return View();
        }

    }
}
