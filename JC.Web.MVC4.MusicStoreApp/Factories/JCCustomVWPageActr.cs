using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Microsoft.Practices.Unity;

namespace JC.Web.MVC4.MusicStoreApp.Factories
{
    public class JCCustomVWPageActr : IViewPageActivator
    {
        private IUnityContainer container;
        public JCCustomVWPageActr(IUnityContainer container)
        {
            this.container = container;
        }
        public object Create(ControllerContext controllerContext, Type type)
        {
            return container.Resolve(type);
        }
    }
}