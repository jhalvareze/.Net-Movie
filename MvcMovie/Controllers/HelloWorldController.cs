﻿using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int numTimes=1)
        {
            //var person = new Person();
            //person.Name = name;
            //person.NumTimes = numTimes;

            //ViewBag.Message = "Hello " + name;
            //ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}