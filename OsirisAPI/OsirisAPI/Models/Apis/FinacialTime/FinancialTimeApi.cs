using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OsirisAPI.Models.Apis.FinacialTime
{
    /// <summary>
    /// Financial time API ingetration
    /// </summary>
    [ApiProvider( name = "FinancialTimeApi" )]
    public class FinancialTimeApi : OsirisHttpClient , IApiProvider
    {
        public override string apiEndPoint => @"http://api.ft.com/content/search/v1";

        public override string apiKey => @"59cbaf20e3e06d3565778e7b883f61c5774e4250af73bc98a9a19e73";

        public override string apiSecret => "";

        string defaultContent = "{ \"queryString\": \"banks\", \"resultContext\" : { \"aspects\" :[  \"title\",\"lifecycle\",\"location\",\"summary\",\"editorial\" ]}}";

        public FinancialTimeApi()
            : base()
        {
            this.client.DefaultRequestHeaders.Add("X-Api-Key", apiKey);
            this.client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public override IResponse Post<T>(string contents = null)
        {
            HttpResponseMessage message = client.PostAsync(
                apiEndPoint,
                new StringContent(
                        ( contents == null) ? this.defaultContent : contents , Encoding.UTF8, "application/json"
                    )
                ).Result;

            IResponse response = message.Content.ReadAsAsync<FinancialTimeHttpResponse>().Result;

            return response;
        }

        public override IResponse Get<T>(string contents = null)
        {
            return this.Post<FinancialTimeHttpResponse>();
        }

        public override IResponse Put<T>(string contents = null)
        {
            throw new Exception("NotImplementedException. Only have read only access");
        }

        public override IResponse Delete<T>(int recordId)
        {
            throw new Exception("NotImplementedException. Only have read only access");
        }
        public override IEnumerable<SimpleResponse> SimplifyResponse(IResponse response)
        {
            
            List<SimpleResponse> data = new List<SimpleResponse>();
            // response.results
            Parallel.ForEach( (response as FinancialTimeHttpResponse).results[0].results, (record) => {
                lock (data)
                {
                    data.Add(
                        new SimpleResponse { title = record.title.title , content = record.summary.excerpt , date = record.lifecycle.lastPublishDateTime, url=record.location.uri }    
                    );
                }
            });

            return data;
            
        }
    }
}