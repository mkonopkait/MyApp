﻿using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DataBaseEntities db = new DataBaseEntities();
            var users = db.Users;
            return View(users);
        }
    }
}