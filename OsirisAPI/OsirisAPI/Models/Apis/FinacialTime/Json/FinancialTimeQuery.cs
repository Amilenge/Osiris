namespace OsirisAPI.Models.Apis.FinacialTime
{
    public class FinancialTimeQuery
    {
        public string queryString { get; set; }
        public FinancialTimeQueryContext queryContext { get; set; }
        public object resultContext { get; set; }
    }
}