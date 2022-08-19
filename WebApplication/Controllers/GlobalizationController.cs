namespace WebApplication.Controllers
{
    using System;
    using System.Web;
    using System.Web.Mvc;

    public class GlobalizationController : BaseController
    {
        public ActionResult ChangeCulture(string culture)
        {
            Response.Cookies.Remove("Language");

            HttpCookie languageCookie = System.Web.HttpContext.Current.Request.Cookies["Language"];

            if (languageCookie == null) languageCookie = new HttpCookie("Language");

            languageCookie.Value = culture;

            languageCookie.Expires = DateTime.Now.AddDays(10);

            Response.SetCookie(languageCookie);

            Response.Redirect(Request.UrlReferrer.ToString());

            return new HttpStatusCodeResult(200);
        }
    }
}