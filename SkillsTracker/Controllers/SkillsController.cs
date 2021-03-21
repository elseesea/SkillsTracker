using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker";
            return Content(html, "text/html");
            //return View();
        }

        public IActionResult Skills()
        {
            string html = "<h1>Skills Tracker";
            return Content(html, "text/html");
        }

    } // class
} // name
