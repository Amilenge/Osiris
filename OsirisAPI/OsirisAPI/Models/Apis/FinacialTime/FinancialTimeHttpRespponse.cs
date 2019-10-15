using System.Collections.Generic;

namespace OsirisAPI.Models.Apis.FinacialTime
{
    public class FinancialTimeHttpResponse : IResponse
    {
        public FinancialTimeQuery query { get; set; }

        public List<FinancialTimeResult> results { get; set; }
    }
}