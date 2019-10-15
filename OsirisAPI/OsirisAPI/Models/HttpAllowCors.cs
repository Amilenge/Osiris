using System.Web.Http.Filters;

namespace OsirisAPI.Models
{
    public class HttpAllowCors : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception == null)
                actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            else
                throw actionExecutedContext.Exception;
        }
    }
}