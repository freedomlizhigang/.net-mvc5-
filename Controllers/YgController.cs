using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using w_test.Filters;
using w_test.Models;

namespace w_test.Controllers
{
    [AdminUser]
    [PrivFilter]
    public class YgController : Controller
    {
        // GET: Yg/Index
        public ActionResult Index()
        {
            ViewBag.Message = "欢迎登陆复明验光系统！";
            return View();
        }
    }
}