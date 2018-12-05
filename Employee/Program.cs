using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.empName = "Atma";
            emp.department = "Information Technology";
            emp.salary = 100;

            emp.PrintEmployee();
            //Console.WriteLine("{0} is working in {1} department with basic salary of ${2}. ", emp.empName, emp.department, emp.salary);
            Console.ReadKey();
        }
    }
    class Employee
    {
        public string empName;
        public string department;
        public int salary;

        public void PrintEmployee()
        {
            Console.WriteLine("{0} is working in {1} department with basic salary of ${2}. ", empName, department, salary);
        }
    }
}
