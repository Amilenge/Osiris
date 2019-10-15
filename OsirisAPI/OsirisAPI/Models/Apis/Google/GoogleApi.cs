using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OsirisAPI.Models.Apis.Google
{
    /// <summary>
    /// Google API ingetration, created to demonstrate the extensibity of the solution
    /// </summary>
    [ApiProvider( name = "GoogleApi" )]
    public class GoogleApi : OsirisHttpClient, IApiProvider
    {
        public override string apiKey => "";

        public override string apiSecret => "";

        public override string apiEndPoint => "";


        public override IResponse Post<T>(string contents = null)
        {
            throw new Exception("NotImplementedException was just used to show extensibility of the application");
        }

        public override IResponse Get<T>(string contents = null)
        {
            throw new Exception("NotImplementedException was just used to show extensibility of the application");
        }

        public override IResponse Put<T>(string contents = null)
        {
            throw new Exception("NotImplementedException was just used to show extensibility of the application");
        }

        public override IResponse Delete<T>(int recordId)
        {
            throw new Exception("NotImplementedException was just used to show extensibility of the application");
        }

        public override IEnumerable<SimpleResponse> SimplifyResponse(IResponse results)
        {
            throw new Exception("NotImplementedException was just used to show extensibility of the application");
        }
    }
}