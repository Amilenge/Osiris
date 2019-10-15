using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using OsirisAPI.Models;

namespace OsirisAPI
{
    public class Program
    {
        public static void getApiInstance(string attributeValue)
        {
            var dnAttribute = typeof(IApiProvider).GetCustomAttributes();
            //var dnAttribute = typeof(IApiProvider).GetCustomAttributes(
            //    typeof(DomainNameAttribute), true
            //).FirstOrDefault() as DomainNameAttribute;
            //if (dnAttribute != null)
            //{
            //    return dnAttribute.Name;
            //}
            //return null;
        }

    }
}