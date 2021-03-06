﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcThrottle.Demo.Controllers
{
    [EnableThrottling]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [EnableThrottling(PerSecond = 2, PerMinute = 5)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [DisableThrotting]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}