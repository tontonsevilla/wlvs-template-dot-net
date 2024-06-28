using System.Web.Mvc;
using WLVSTemplateDotNet.Web.WebInfrastructure.Atrributes;

namespace WLVSTemplateDotNet.Web.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new AuthorizeAttribute());
            filters.Add(new UnauthorizedAttribute());
        }
    }
}