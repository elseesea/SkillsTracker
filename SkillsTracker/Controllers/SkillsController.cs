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

        [HttpGet]
        public IActionResult Form()
        {
            string html =
                "<form action='/skills/form' method='post'" +
                "<label for='date'>Date:</label><br />" +
                "<input type = 'date' id = 'date' name = 'date'><br />" +
                "<label for='java'>Java:</label><br />" +
                "<select name = 'java' id = 'java'>" +
                "<option value = 'basics'>learning basics</option>" +
                "<option value = 'master'>master coder</option>" +
                "<option value = 'apps'>making apps</option>" +
                "</select><br />" +
                "<label for='csharp'>C#:</label><br />" +
                "<select name = 'csharp' id = 'csharp'>" +
                "<option value = 'basics'>learning basics</option>" +
                "<option value = 'master'>master coder</option>" +
                "<option value = 'apps'>making apps</option>" +
                "</select><br />" +
                "<label for='python'>Python:</label><br />" +
                "<select name = 'python' id = 'python'>" +
                "<option value = 'basics'>learning basics</option>" +
                "<option value = 'master'>master coder</option>" +
                "<option value = 'apps'>making apps</option>" +
                "</select><br />" +
                "<input type='submit' value='Submit' />" +
                "</form>";

            return Content(html, "text/html");
        }

        [HttpPost]
        public IActionResult Form(DateTime date, string java, string csharp, string python)
        {
            string html =
                "<h1>" + date.ToShortDateString() + "</h1>" +
                "<ol>" +
                "<li>Java: " + GetLevel(java) + "</li><br />" +
                "<li>C#: " + GetLevel(csharp) + "</li><br />" +
                "<li>Python: " + GetLevel(python) + "</li>" +
                "</ol>";
            return Content(html, "text/html");
        }

        public static string GetLevel(string level)
        {
            if (level.Equals("basics"))
            {
                return "learning basics";
            }
            else if (level.Equals("master"))
            {
                return "master coder";
            }
            else if (level.Equals("apps"))
            {
                return "making apps";
            }
            else
                return "unknown";

        }

    } // class
} // name
