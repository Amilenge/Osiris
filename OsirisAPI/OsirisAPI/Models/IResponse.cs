using System;
using System.Linq;
using System.Web;
using OsirisAPI.Models.Apis.FinacialTime;
using System.Collections.Generic;


namespace OsirisAPI.Models
{
    public abstract class IResponse
    {
        public List<IRecord> results { get; set; }
    }
}