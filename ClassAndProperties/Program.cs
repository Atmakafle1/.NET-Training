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
            Console.ReadKey();

        }
    }
}
