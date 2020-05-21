using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eUseControl.Web.Models
{
    public class ThemeContext : DbContext
    {
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}