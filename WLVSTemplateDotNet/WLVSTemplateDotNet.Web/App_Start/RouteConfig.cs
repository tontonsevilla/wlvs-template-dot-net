using System.Web.Mvc;
using System.Web.Routing;

namespace WLVSTemplateDotNet.Web.App_Start
{
    public class RouteConfig
    {
        public static void Register(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathinfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}