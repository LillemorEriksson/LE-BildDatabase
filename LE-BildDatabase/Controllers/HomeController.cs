﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LE_BildDatabase.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "www.le-bild.se";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "www.le-bild.se";

            return View();
        }

        public ActionResult Portfolio()
        {
            return View();
        }

    }
}