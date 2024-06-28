using System.Web;
using System.Web.Mvc;

namespace WLVSTemplateDotNet.Web.WebInfrastructure.Atrributes
{
    public class UnauthorizedAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            byPassAuthentication(httpContext);

            //if (httpContext.User.Identity.IsAuthenticated)
            //{
            //    var userInfo = ApplicationContextService.Current.GetUserInfo();
            //    if (userInfo == null)
            //        return false;
            //}
            return base.AuthorizeCore(httpContext);
        }

        private static void byPassAuthentication(HttpContextBase httpContext)
        {
            var userName = "winston_sevilla@outlook.com";

            var user = new System.Security.Claims.ClaimsPrincipal(
                new System.Security.Principal.GenericIdentity(userName));

            var identity = user.Identity as System.Security.Claims.ClaimsIdentity;

            identity.AddClaim(new System.Security.Claims.Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn", userName));

            httpContext.User = user;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectResult("~/Error/Unauthorized");
        }
    }
}