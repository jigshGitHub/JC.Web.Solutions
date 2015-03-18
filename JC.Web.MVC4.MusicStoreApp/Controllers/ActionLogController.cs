using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using JC.Web.MVC4.MusicStoreApp.Models;
namespace JC.Web.MVC4.MusicStoreApp.Controllers
{ 
    public class ActionLogController : Controller
    {
        //
        // GET: /ActionLog/
        MusicStoreDBEntities storeDB = new MusicStoreDBEntities();

        public ActionResult Index()
        {
            var model = this.storeDB.ActionLogs.OrderByDescending(al => al.CreatedDate).ToList();

            return this.View(model);
        }

    }
}
