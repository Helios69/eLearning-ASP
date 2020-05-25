using System.Web.Mvc;
using eUseControl.Web.Models;
using eUseControl.Domain.Entites.User;
using eUseControl.BusinessLogic.Interfaces;
using System.Web;
using eUseControl.BusinessLogic;
using eUseControl.Domain.Entities.User;
using System;

namespace eUseControl.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IRegister _register;
        private readonly ISession _session;
        // GET: Login
        public RegisterController()
        {
            var bl = new BussinessLogic();
            _register = bl.GetRegisterBL();
            var ss = new BussinessLogic();
            _session = ss.GetSessionBL();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserRegister user)
        {
            URegisterData data = new URegisterData
            {
                Username = user.Username,
                Password = user.Password,
                Email = user.Email,
                Level = user.Level
            };

            _register.UserRegister(data);

            ULoginData u = new ULoginData
            {
                Credential = user.Username,
                Password = user.Password
            };

            _session.UserLogin(u);

            HttpCookie cookie = _session.GenCookie(u.Credential);
            ControllerContext.HttpContext.Response.Cookies.Add(cookie);

            return RedirectToAction("Index", "Login");
        }
    }
}