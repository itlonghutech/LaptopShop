﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaptopStore.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Laptop()
        {
            return View();
        }
        public ActionResult Chitiet()
        {
            return View();
        }
        public ActionResult Timkiem() 
        {
            return View();
        }
    }
}