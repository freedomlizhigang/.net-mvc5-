using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using w_test.Filters;
using w_test.Models;

namespace w_test.Controllers
{
    public class HomeController : Controller
    {
        private Sg2016 db = new Sg2016();
        public ActionResult Index()
        {
            return View();
        }

        [AdminUser]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Login()
        {
            ViewBag.Message = "欢迎登陆！";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToRouteResult DoLogin()
        {
            string username = Request.Form["username"];
            string password = Request.Form["password"];
            var yguser = from y in db.Ygusers
                          where y.usercode == username && y.userpass == password
                          select y;
            if (yguser.Any())
            {
                Session["usercode"] = yguser.First().usercode;
                Session["username"] = yguser.First().username;
                Session["yflb"] = yguser.First().yflb != "" ? yguser.First().yflb : null;
                return RedirectToRoute(new { controller = "Menus", action = "Index" });
            }
            else
            {
                return RedirectToRoute(new { controller = "Home", action = "Login" });
            }
        }
    }
}