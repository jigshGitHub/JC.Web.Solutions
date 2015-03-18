using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JC.Web.MVC4.MusicStoreApp.Filters
{
    public sealed class JCAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
            HttpUnauthorizedResult result = filterContext.Result as HttpUnauthorizedResult;
            if (result == null)
            {
                filterContext.Controller.ViewBag.AutherizationMessage = "You are successfully authorized.";

                //_isAuthorized = true;
            }
            else
            {
                if (result.StatusCode == 401)
                {
                    filterContext.Controller.ViewBag.AutherizationMessage = "Please login with your credentials first.";
                }
            }
        }
    }
}