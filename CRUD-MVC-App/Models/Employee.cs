using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_MVC_App.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ClassID { get; set; }
        public string Section { get; set; }
        public int Age { get; set; }       
       
    }
}