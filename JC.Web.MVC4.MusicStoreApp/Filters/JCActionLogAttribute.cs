using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using JC.Web.MVC4.MusicStoreApp.Models;

namespace JC.Web.MVC4.MusicStoreApp.Filters
{
    public class JCActionLogAttribute : ActionFilterAttribute, IActionFilter 
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // TODO: Add your acction filter's tasks here

            // Log Action Filter Call
            MusicStoreDBEntities storeDB = new MusicStoreDBEntities();

            ActionLog log = new ActionLog()
            {
                Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Action = filterContext.ActionDescriptor.ActionName + " (Logged By: JCActionLog Filter)",
                IPAddress = filterContext.HttpContext.Request.UserHostAddress,
                CreatedDate = filterContext.HttpContext.Timestamp
            };

            storeDB.ActionLogs.Add(log);
            storeDB.SaveChanges();

            base.OnActionExecuting(filterContext);

        }
    }
}