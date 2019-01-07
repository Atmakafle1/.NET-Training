using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_MVC_App.Models;


namespace CRUD_MVC_App.Controllers
{
    public class EmployeeController : Controller
    {

        public static List<Employee> emp = new List<Employee>
        {
            new Employee
            {
                ID=1,
                Name="Sandy Sanders",
                ClassID= 2,
                Section = "A",
                Age = 8
            },
            new Employee
            {
                ID=2,
                Name="Peter Gommez",
                ClassID= 2,
                Section = "A",
                Age = 7
            },
            new Employee
            {
                ID=3,
                Name="Henry Siddle",
                ClassID= 3,
                Section = "B",
                Age = 8
            },
            new Employee
            {
                ID=4,
                Name="Mary Simmons",
                ClassID= 4,
                Section = "A",
                Age = 9
            },

        };

        [NonAction]
        public List<Employee> GetEmployees()
        {

            var employees = from e in emp
                            orderby e.ID
                            select e;

            return employees.ToList<Employee>();
        }

        // GET: Employee
        public ActionResult Index()
        {
            var employees = from e in emp
                            orderby e.ID
                            select e;
            return View(employees);
        }

        //details
        public ActionResult Details(int id)
        {
            List<Employee> emp = GetEmployees();
            var employee = emp.Single(m => m.ID == id);
            return View(employee);
        }

        //delete
        public ActionResult Delete(int id)
        {
            List<Employee> emp = GetEmployees();
            var employee = emp.Single(m => m.ID == id);
            return View(employee);
        }

        //edit
        public ActionResult Edit(int id)
        {
            List<Employee> emp = GetEmployees();
            var employee = emp.Single(m => m.ID == id);
            return View(employee);
        }

        //create

        public ActionResult Create(int id)
        {
            List<Employee> emp = GetEmployees();
            var employee = emp.Single(m => m.ID == id);
            return View(employee);
        }


        [HttpPost]
        public ActionResult Edit(int ID, FormCollection collection)
        {
            try
            {
                var employee = emp.Single(m => m.ID == ID);
                if (TryUpdateModel(employee))
                {
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
            catch
            {
               return View();
            }
        }
    }
}