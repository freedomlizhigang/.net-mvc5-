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
            List<Privs> privs = new List<Privs>()
            {
                // yg
                new Privs() { id=1, name="验光首页", yflb = "yg", url="yg/index", label="yg-index" },
                new Privs() { id=2, name="当日验光", yflb = "yg", url="yg/today", label="yg-today" },
                new Privs() { id=3, name="添加验光", yflb = "yg", url="yg/add", label="yg-add" },
                new Privs() { id=4, name="综合查询", yflb = "yg", url="yg/all", label="yg-all" },
                new Privs() { id=28, name="菜单列表", yflb = "yg", url="menus/index", label="menus-index" },

                // dz
                new Privs() { id=5, name="验光首页", yflb = "dz", url="yg/index", label="yg-index" },
                new Privs() { id=6, name="当日验光", yflb = "dz", url="yg/today", label="yg-today" },
                new Privs() { id=7, name="添加验光", yflb = "dz", url="yg/add", label="yg-add" },
                new Privs() { id=8, name="综合查询", yflb = "dz", url="yg/all", label="yg-all" },

                // zj
                new Privs() { id=9, name="验光首页", yflb = "zj", url="yg/index", label="yg-index" },
                new Privs() { id=10, name="当日验光", yflb = "zj", url="yg/today", label="yg-today" },
                new Privs() { id=11, name="修改验光", yflb = "zj", url="yg/edit", label="yg-edit" },
                new Privs() { id=12, name="综合查询", yflb = "zj", url="yg/all", label="yg-all" },

                // hf
                new Privs() { id=13, name="验光首页", yflb = "hf", url="yg/index", label="yg-index" },
                new Privs() { id=14, name="当日验光", yflb = "hf", url="yg/today", label="yg-today" },
                new Privs() { id=15, name="综合查询", yflb = "hf", url="yg/all", label="yg-all" },

                // null 管理员
                new Privs() { id=16, name="菜单列表", yflb = "null", url="menus/index", label="menus-index" },
                new Privs() { id=17, name="添加菜单", yflb = "null", url="menus/add", label="menus-add" },
                new Privs() { id=18, name="修改菜单", yflb = "null", url="menus/edit", label="menus-edit" },
                new Privs() { id=19, name="删除菜单", yflb = "null", url="menus/delete", label="menus-delete" },
                new Privs() { id=20, name="验光首页", yflb = "null", url="yg/index", label="yg-index" },
                new Privs() { id=21, name="当日验光", yflb = "null", url="yg/today", label="yg-today" },
                new Privs() { id=22, name="添加验光", yflb = "null", url="yg/add", label="yg-add" },
                new Privs() { id=23, name="综合查询", yflb = "null", url="yg/all", label="yg-all" },
                new Privs() { id=24, name="用户列表", yflb = "null", url="user/index", label="user-index" },
                new Privs() { id=25, name="添加用户", yflb = "null", url="user/add", label="user-add" },
                new Privs() { id=26, name="修改用户", yflb = "null", url="user/edit", label="user-edit" },
                new Privs() { id=27, name="删除用户", yflb = "null", url="user/delete", label="user-delete" },
            };

            string url = controllerName + "/" + actionName;
            string yflb = filterContext.HttpContext.Session["yflb"].ToString();

            var priv = privs.Find(p => p.yflb == yflb && p.url == url);
            // 找到就说明有权限
            if(priv == null)
            {
                filterContext.Result = new ViewResult { ViewName = "Priv" };
                return;
            }


        }
    }
}