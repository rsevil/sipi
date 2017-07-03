﻿using System.Web.Mvc;

namespace SIPI.Presentation.Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Other()
        {
            return Content("OK");
        }
    }
}