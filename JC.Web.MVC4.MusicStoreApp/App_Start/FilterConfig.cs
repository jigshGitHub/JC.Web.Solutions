using System.Web;
using System.Web.Mvc;

namespace JC.Web.MVC4.MusicStoreApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Filters.JCActionLogFileAttribute());
        }
    }
}