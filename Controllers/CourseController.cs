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

        //localhost:5000/course/index
        public string Index()
        {
            return "course/index";
        }

        //localhost:5000/course/list
        public string List()
        {
            return "course/list";
        }

    }
}
