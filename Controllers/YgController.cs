using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using w_test.Filters;
using w_test.Models;
using PagedList;

namespace w_test.Controllers
{
    //[AdminUser]
    //[PrivFilter]
    public class YgController : Controller
    {
        private Sg2016 DB = new Sg2016();
        // GET: Yg/Index
        public ActionResult Index()
        {
            ViewBag.Message = "欢迎登陆复明验光系统！";
            return View();
        }

        // GET:Yg/Today
        public ActionResult Today(int? page = 1)
        {
            int pagesize = 10;
            int pageNumber = (page ?? 1);
            DateTime dt1 = DateTime.Now.Date;
            DateTime dt2 = DateTime.Now;
            var sgn = (from u in DB.Sgnlists
                        where u.zwdate > dt1 && u.zwdate < dt2
                        orderby u.aid descending
                        select u).ToPagedList(pageNumber, pagesize);
            return View(sgn);
        }


        // GET:Yg/All
        public ActionResult All(string starttime = "", string endtime = "",string blid = "", string tel = "", string xm = "",int? page = 1)
        {
            ViewBag.blid = blid = blid.Trim();
            ViewBag.tel = tel = tel.Trim();
            ViewBag.xm = xm = xm.Trim();
            ViewBag.starttime = starttime = starttime.Trim();
            ViewBag.endtime= endtime = endtime.Trim();
            int pagesize = 10;
            int pageNumber = (page ?? 1);
            if (starttime != "" && endtime != "")
            {
                DateTime dt1 = Convert.ToDateTime(starttime);
                DateTime dt2 = Convert.ToDateTime(endtime);
                var sgn = (from u in DB.Sgnlists
                           where u.zwdate > dt1 && u.zwdate < dt2
                           orderby u.aid descending
                           select u).ToPagedList(pageNumber, pagesize);
                return View(sgn);
            }
            else
            {
                var sgn = (from u in DB.Sgnlists
                           where (u.blid == blid && u.blid != "") || (u.xm == xm && u.xm != "") || (u.tel == tel && u.tel != "")
                           orderby u.aid descending
                           select u).ToPagedList(pageNumber, pagesize);
                return View(sgn);
            }
        }
    }
}