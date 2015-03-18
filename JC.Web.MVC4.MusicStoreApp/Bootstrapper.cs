using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;

using JC.Web.MVC4.MusicStoreApp.DataServices;
using JC.Web.MVC4.MusicStoreApp.Factories;
namespace JC.Web.MVC4.MusicStoreApp
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            IDependencyResolver resolver = DependencyResolver.Current;
            IDependencyResolver newResolver = new JCUnityDependencyResolver(container, resolver);

            DependencyResolver.SetResolver(newResolver);
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();        
            container.RegisterType<IStoreService, StoreService>();
            container.RegisterType<IController, Controller>("Store");

            container.RegisterInstance<IMessageService>(new MessageService { Message = "You are welcome", ImageUrl = "/Content/Images/webcamps.png" });
            container.RegisterType<IViewPageActivator, JCCustomVWPageActr>(new InjectionConstructor(container));

            return container;
        }
    }
}