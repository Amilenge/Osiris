using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using OsirisAPI.Models.Apis.FinacialTime;
using System.Web.Http;
using System.Web.Http.Cors;
using OsirisAPI.Models;
using System.Reflection;

namespace OsirisAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [OutputCache( Duration = 1800)]
    public class FetchController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            //FinancialTime ft = new FinancialTime();

            //Program.getApiInstance("financial time");

            //var doc = ft.getBanks();

            return new string[] { "value1", "value2" };
        }

        [Route("api/fetch/{provider}")]
        [HttpGet, HttpPost]
        public IEnumerable<SimpleResponse> Fetch(string provider)
        {
            /*
             * All IP provider' class are decorated by ApiProvider attribute
             * with the help of reflexion, let find what API provider the user selected and 
             * create a new instance then invoke a post method
             */

            var assembly = Assembly.GetExecutingAssembly();

            var type = assembly.GetTypes()
                .First(t => t.Name == provider);

            OsirisHttpClient httpClient  = Activator.CreateInstance(type) as OsirisHttpClient;

            IResponse httpResponse;

            if ( Request.Method == HttpMethod.Get)
                httpResponse = httpClient.Get<IResponse>();
            else
                httpResponse = httpClient.Post<IResponse>();

            return httpClient.SimplifyResponse(httpResponse);
        }

    }


    public class FromBodyRequest
    {
        string provider { get; set; }
    }
}
