using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;


namespace OsirisAPI.Models
{
    public abstract class OsirisHttpClient
    {
        protected HttpClient client { get; set; }

        public abstract string apiKey { get; }

        public abstract string apiSecret { get; }

        public abstract string apiEndPoint { get; }

        public OsirisHttpClient()
        {
            this.client = new HttpClient();

            if (apiEndPoint == null)
                throw new Exception("the provider should have a valid uri");

            this.client.BaseAddress = new Uri(apiEndPoint);
        }

        public abstract IResponse Post<T>(string contents = null);

        public abstract IResponse Get<T>(string urlParams = "");

        public abstract IResponse Put<T>(string contents = null);

        public abstract IResponse Delete<T>(int recordId);

        public abstract IEnumerable<SimpleResponse> SimplifyResponse(IResponse results);
    }

    public class SimpleResponse
    {
        public string title { get; set; }
        public string content { get; set; }
        public string date { get; set; }
        public string publisher { get; set; }
        public string url { get; set; }
    }
}