using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace w_test.Filters
{
    public class AdminUser : AuthorizeAttribute
    {
        /// <summary>
        /// 授权失败时呈现的视图
        /// </summary>
        public string AuthorizationFailView
        {
            get;
            set;
        } = "Error";

        /// <summary>
        /// 请求授权时执行
        /// </summary>
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //获得url请求里的controller和action：
            //string controllerName = filterContext.RouteData.Values["controller"].ToString().ToLower();
            //string actionName = filterContext.RouteData.Values["action"].ToString().ToLower();

            //根据请求过来的controller和action去查询可以被哪些角色操作:
            base.OnAuthorization(filterContext);   //进入AuthorizeCore
        }

        /// <summary>
        /// 自定义授权检查（返回False则授权失败）
        /// </summary>
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {

            // 判断是否usercode是空，如果是空说明没有登陆
            if (httpContext.Session["usercode"] == null)
            {
                return false;//进入HandleUnauthorizedRequest 
            }
            else
            {
                if(string.IsNullOrEmpty(httpContext.Session["usercode"].ToString()))
                {
                    return false;//进入HandleUnauthorizedRequest 
                }
                // 认证成功
                return true;
            }

        }

        /// <summary>
        /// 处理授权失败的HTTP请求
        /// </summary>
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new ViewResult { ViewName = AuthorizationFailView };
        }
    }
}