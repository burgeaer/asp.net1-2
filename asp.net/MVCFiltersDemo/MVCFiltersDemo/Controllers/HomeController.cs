using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFiltersDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "This is ASP.Net MVC Filters Tutorial";
        }
        [ActionName("CurrentTime")]
        public string GetCurrentTime()
        {
            return TimeString();
        }

        [NonAction]
        public string TimeString()
        {
            return "Time is " + DateTime.Now.ToString("T");
        }
    }
    }