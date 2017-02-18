using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using w_test.Models;

namespace w_test.Filters
{
    public class PrivFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // 判断当前操作的权限
            string controllerName = filterContext.RouteData.Values["controller"].ToString().ToLower();
            string actionName = filterContext.RouteData.Values["action"].ToString().ToLower();

            // 写权限集合

            string url = controllerName + "/" + actionName;
            string yflb = filterContext.HttpContext.Session["yflb"].ToString();

            var priv = BaseData.privs.Find(p => p.yflb == yflb && p.url == url);
            // 找到就说明有权限
            if(priv == null)
            {
                filterContext.Result = new ViewResult { ViewName = "Priv" };
                return;
            }


        }
    }
}