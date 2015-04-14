using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcStudy.Web.Controllers.Fliters
{
    //action的拦截器
	public class LoggerFilter:FilterAttribute,IActionFilter
	{
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            Console.WriteLine("OnActionExecuting");
            //filterContext.Controller.ViewData["ExecutingLogger"] = "正要添加公告，已以写入日志！时间：" + DateTime.Now; 
       }

       void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
        {
            Console.WriteLine("OnActionExecuted");
            //filterContext.Controller.ViewData["ExecutedLogger"] = "公告添加完成，已以写入日志！时间：" + DateTime.Now;
        }
        
	}
}