using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;

using JC.Web.MVC4.MusicStoreApp.Models;
using JC.Web.MVC4.MusicStoreApp.DataServices;

namespace JC.Web.MVC4.MusicStoreApp.Pages
{
    public class JCBasePage:WebViewPage<Genre>
    {
        [Dependency]
        public IMessageService MessageService { get; set; }

        public override void Execute()
        {
        }
    }
}