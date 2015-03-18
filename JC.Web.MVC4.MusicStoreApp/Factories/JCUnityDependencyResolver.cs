using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;

namespace JC.Web.MVC4.MusicStoreApp.Factories
{
    public class JCUnityDependencyResolver:IDependencyResolver
    {
        private IUnityContainer container;
        private IDependencyResolver resolver;

        public JCUnityDependencyResolver(IUnityContainer container, IDependencyResolver resolver)
        {
            this.container = container;
            this.resolver = resolver;
        }
        public object GetService(Type serviceType)
        {
            try
            {
                return this.container.Resolve(serviceType);
            }
            catch
            {
                return this.resolver.GetService(serviceType);
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return this.container.ResolveAll(serviceType);
            }
            catch
            {
                return this.resolver.GetServices(serviceType);
            }
        }
    }
}