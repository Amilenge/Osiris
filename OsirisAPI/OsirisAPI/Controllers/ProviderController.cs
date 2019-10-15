using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OsirisAPI.Models;
using OsirisAPI.Models.Apis.FinacialTime;
using System.Web.Http.Cors;

namespace OsirisAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [OutputCache( Duration = 1800)]
    public class ProviderController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return
            from a in AppDomain.CurrentDomain.GetAssemblies()
            from t in a.GetTypes()
            let attributes = t.GetCustomAttributes(typeof(ApiProviderAttribute), true)
            where attributes != null && attributes.Length > 0
            select t.Name;
        }

    }
}
