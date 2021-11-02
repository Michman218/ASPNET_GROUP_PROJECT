using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_GROUP_PROJECT.Pages
{
    public class CourseModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Welcome to the Course page. Here you can view all the courses you enrolled in.";
        }
    }
}
