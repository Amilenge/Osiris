using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OsirisAPI.Models.Apis.Google
{
    public class GoogleHttpResponse : IResponse
    {
        public List<IResponse> Results { get; set; }
    }
}