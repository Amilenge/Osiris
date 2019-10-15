using System;
using System.Net.Http.Headers;
using System.Web.Http.Filters;

namespace OsirisAPI.Models
{
    public class OutputCacheAttribute : ActionFilterAttribute
    {
        public int Duration { get; set; }

        public override void OnActionExecuted(HttpActionExecutedContext filterContext)
        {
            filterContext.Response.Headers.CacheControl = new CacheControlHeaderValue
            {
                MaxAge = TimeSpan.FromSeconds(this.Duration),
                MustRevalidate = true,
                Public = true
            };
        }
    }
}