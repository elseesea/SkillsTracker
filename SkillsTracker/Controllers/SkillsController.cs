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
            string html = "<h1>Skills Tracker</h1>" +
                "<h2><ol>" +
                "<li>Java</li>" +
                "<li>C#</li>" +
                "<li>Python</li>" +
                "</ol></h2>" +
                "<label for="start">Start date:</label>

< input type = "date" id = "start" name = "trip-start"
       value = "2018-07-22"
       min = "2018-01-01" max = "2018-12-31" >;
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
