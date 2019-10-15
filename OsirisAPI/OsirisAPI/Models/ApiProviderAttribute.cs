using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OsirisAPI.Models
{
    public class ApiProviderAttribute : Attribute
    {
        public string name { get; set; }
    }
}