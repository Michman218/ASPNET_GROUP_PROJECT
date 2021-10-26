using Microsoft.AspNetCore.Mvc;
using ASPNET_GROUP_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_GROUP_PROJECT.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Presentation")]
        public IActionResult SchedulePresentation()
        {
            return View();
        }
    }
}

//https://codewithmukesh.com/blog/permission-based-authorization-in-aspnet-core/#:~:text=Role-Based%20Authorization%20in%20ASP.NET%20Core%20is%20a%20way,methods%2C%20restricts%20users%20bases%20on%20his%2Fher%20role%20settings.
//to authorize specifc users - eg create for lecturer, view for student
