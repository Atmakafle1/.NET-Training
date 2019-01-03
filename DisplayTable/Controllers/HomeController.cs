using DisplayTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DisplayTable.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home    
        
        public ActionResult Index()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee { StudentName = "Atma", Subject = "Math", Marks = 10 },
                new Employee { StudentName = "Atma", Subject = "Math", Marks = 10 },
                new Employee { StudentName = "Atma", Subject = "Math", Marks = 10 },
                new Employee { StudentName = "Atma", Subject = "Math", Marks = 10 }
            };
            return View(emp);
        }
    }

    
}