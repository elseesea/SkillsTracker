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
                "<h2>Coding skills to learn:<ol>" +
                "<li>Java</li>" +
                "<li>C#</li>" +
                "<li>Python</li>" +
                "</ol></h2>";
            return Content(html, "text/html");
            //return View();
        }

        public IActionResult Form()
        {
            string html =
                "<label for='date'>Date:</label><br />" +
                "<input type = 'date' id = 'date' name = 'date'>" +
                "<label for='csharp'>C#:</label><br />";
            return Content(html, "text/html");
        }

    } // class
} // name
