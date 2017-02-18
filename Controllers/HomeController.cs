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
            ViewBag.Message = "欢迎登陆复明验光系统！";
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToRouteResult Login()
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
                return RedirectToRoute(new { controller = "Yg", action = "Index" });
            }
            else
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
        }

        // 生成顶部菜单
        [ChildActionOnly]
        public ActionResult Menu()
        {
            string yflb = Session["yflb"] == null ? "" : Session["yflb"].ToString();
            var menus = BaseData.privs.Where(y => y.yflb == yflb && y.display == true).ToList();
            return PartialView(menus);
        }
    }
}