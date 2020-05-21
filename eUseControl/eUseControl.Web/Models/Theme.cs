using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eUseControl.Web.Models
{
    public class Theme
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        // public int CourseId  { get; set; }
        public string CourseName { get; set; }
        public string Text { get; set; }
        
    }
}