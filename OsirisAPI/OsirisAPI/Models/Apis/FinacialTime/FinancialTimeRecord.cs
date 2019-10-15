using System.Collections.Generic;
using Newtonsoft.Json;

namespace OsirisAPI.Models.Apis.FinacialTime
{
    /// <summary>
    /// FT API Record - Must be equivalent to the FT JSON object
    /// </summary>
    public class FinancialTimeRecord : IRecord
    {
        public string aspectSet { get; set; }
        public string modelVersion { get; set; }
        public string id { get; set; }
        public string apiUrl { get; set; }
        public FinancialTimeTitle title { get; set; }
        public FinancialTimePublicationDate lifecycle { get; set; }
        public FinancialTimeLocation location { get; set; }
        public FinancialTimeSummary summary { get; set; }
        public FinancialTimeEditorial editorial { get; set; }
    }
}