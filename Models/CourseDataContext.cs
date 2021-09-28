using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_GROUP_PROJECT.Models
{
    public class CourseDataContext : DbContext
    {
        public CourseDataContext(DbContextOptions<CourseDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
