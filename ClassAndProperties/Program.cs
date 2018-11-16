using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Student Class***");
            Student student1 = new Student();
            student1.firstName = "Atma";
            student1.lastName = "Kafle";
            student1.Level = "Graduate";
            student1.isStudentInDistinctionList = true;
            student1.studentAcademicStanding = "Good";
            Console.WriteLine(student1.firstName +" "+ student1.lastName + " " + "is a " + student1.Level + " " + "student with" + " " + student1.studentAcademicStanding +" "+ "academic standing.");
            
            Console.WriteLine("***Employee Class***");


            Employee emp = new Employee();
            emp.firstName = "Kiran";
            emp.lastName = "Paturi";
            emp.empType = "Full Time";
            emp.noOfYearsInService = 15;
            Console.WriteLine(emp.firstName + " " + emp.lastName + " " +" "+ "is a" +" " + emp.empType +" "+ "employee with" +" "+ emp.noOfYearsInService + " " + "years of experiences.");
            

            var list = new List<string>();
            list.Add("Apple");
            list.Add("Orange");
            list.Add("Grapes");
            list.Add("Papaya");
            int c = list.Count();

            Console.WriteLine("*** Use case for Liststring class***" );

            Console.WriteLine("This list contains {0} no of items.", c);


            Console.WriteLine("*** DateTime class ***");
            Console.WriteLine("Today's date is" +" "+ DateTime.Today.ToLocalTime().ToShortDateString());
            Console.WriteLine("Today's exact date is" + " " + DateTime.Now);
            Console.WriteLine("Tomorrow's date is" + " " + DateTime.Today.AddDays(1).ToLocalTime());
            
            Console.ReadKey();

        }
    }
}
