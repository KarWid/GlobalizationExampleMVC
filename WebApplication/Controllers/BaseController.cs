namespace WebApplication.Controllers
{
    using System.Globalization;
    using System.Threading;
    using System.Web;
    using System.Web.Mvc;

    public class BaseController : Controller
    {
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            HttpCookie languageCookie = System.Web.HttpContext.Current.Request.Cookies["Language"];
            if (languageCookie != null)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(languageCookie.Value);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(languageCookie.Value);
            }
            else
            {
                //other code here
            }

            base.Initialize(requestContext);
        }
    }
}