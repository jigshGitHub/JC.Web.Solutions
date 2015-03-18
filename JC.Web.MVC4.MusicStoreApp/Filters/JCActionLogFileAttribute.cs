using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

using JC.Web.MVC4.MusicStoreApp.Models;

namespace JC.Web.MVC4.MusicStoreApp.Filters
{
    public class JCActionLogFileAttribute : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            using (StreamWriter writer = File.AppendText(@"C:\test\log.txt"))
            {
                writer.WriteLine(string.Format("{0}|{1} (Logged By: JCActionLogFile Filter)|{2}|{3}", filterContext.ActionDescriptor.ControllerDescriptor.ControllerName, filterContext.ActionDescriptor.ActionName, filterContext.HttpContext.Request.UserHostAddress, filterContext.HttpContext.Timestamp.ToShortTimeString()));
            }
        }
    }
}