using System.Web;
using System.Web.Mvc;

namespace CarwoodsApplication
{
    public class RequiresSsl : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpRequestBase req = filterContext.HttpContext.Request;
            HttpResponseBase res = filterContext.HttpContext.Response;

            //Check if we're secure or not and if we're on the local box
            if (req.Url != null && !req.IsSecureConnection && !req.IsLocal)
            {
                string url = req.Url.ToString().ToLower().Replace("http:", "https:");
                res.Redirect(url);
            }

            base.OnActionExecuting(filterContext);
        }
    }
}