﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Soulmyst()
        {
            return View();
        }

        public ActionResult TapBand()
        {
            return View();
        }

        public ActionResult SpaceCombat()
        {
            return View();
        }

        public ActionResult Business()
        {
            return View();
        }
    }
}