using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Continets = new List<string>()
            {
                "Noth America",
                "South America",
                "Antarctica",
                "Africa",
                "Asia",
                "Australia",
                "Europe"

            };
            return View();
        }
       
    }
}