using eUseControl.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.Web.Controllers
{
    public class CoursesController : Controller
    {
        ThemeContext db = new ThemeContext();
        // GET: Courses
        public ActionResult Index()
        {
            IEnumerable<Theme> themes = db.Themes;
            IEnumerable<Course> courses = db.Courses;

            /*var themesJoin = db.Themes.Join(db.Courses,
            theme => theme.CourseId,
            course => course.Id,
            (theme, course) => new
            {
                theme.Name,
                theme.Date,
                CourseName = course.Name,
                theme.Text
            });*/
            
            ViewBag.Themes = themes;
            ViewBag.Courses = courses;
            return View();
        }
        [HttpGet]
        public ActionResult NewTheme()
        {
            IEnumerable<Course> courses = db.Courses;
            ViewBag.Courses = courses;

            return View();
        }
        [HttpPost]
        public ActionResult NewTheme(Theme theme)
        {
            IEnumerable<Course> courses = db.Courses;
            ViewBag.Courses = courses;
            theme.Date = DateTime.Now;
            db.Themes.Add(theme);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}