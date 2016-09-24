using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Countries"] =  new List<string>()
            {
                "Bangladesh",
                "US",
                "Canada",
                "Australia"
            };

            return View();
        }
    }
}