using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Text;
using OsirisAPI.Models.Apis.FinacialTime;
using Newtonsoft.Json;
using OsirisAPI.Models;

namespace OsirisAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}
