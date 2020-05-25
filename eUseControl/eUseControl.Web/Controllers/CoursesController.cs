using eUseControl.Web.Extensions;
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
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Index", "Login");
            }
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
            };
            ViewBag.username = u.Username;
            ViewBag.Themes = themes;
            ViewBag.Courses = courses;
            return View();
        }
        [HttpGet]
        [AdminMod]
        public ActionResult NewTheme()
        {
            IEnumerable<Course> courses = db.Courses;
            ViewBag.Courses = courses;

            return View();
        }
        [HttpPost]
        [AdminMod]

        public ActionResult NewTheme(Theme theme)
        {
            IEnumerable<Course> courses = db.Courses;
            ViewBag.Courses = courses;
            theme.Date = DateTime.Now;
            db.Themes.Add(theme);
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