using System.Collections.Generic;

namespace OsirisAPI.Models.Apis.FinacialTime
{
    public class FinancialTimeResult
    {
        public int indexCount { get; set; }
        public string[] curations { get; set; }
        public List<FinancialTimeRecord> results { get; set; }
    }
}