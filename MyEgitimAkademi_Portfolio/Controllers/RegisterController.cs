﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string x)
        {
            return View();
        }
    }
}