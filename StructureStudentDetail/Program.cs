using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureStudentDetail
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1;
            Student stud2, stud3, stud4, stud5;

            stud1.student_details = "High School student";
            stud2.student_details = "Graduate Student";
            stud3.student_details = "PostDoc Student";
            stud4.student_details = "PhD Student";
            stud5.student_details = "High School Student";

            stud1.student_name = "John";
            stud2.student_name = "Martin";
            stud3.student_name = "Atma";
            stud4.student_name = "CG";
            stud5.student_name = "DG";

            stud1.roll_number = 34;
            stud2.roll_number = 4;
            stud3.roll_number = 3;
            stud4.roll_number = 01;
            stud5.roll_number = 54;

            stud1.course = "C#";
            stud2.course = "VB";
            stud3.course = "C++";
            stud4.course = "C";
            stud5.course = "Java";

            Console.WriteLine("{0} is a {1} studied {2} and was identified with his roll no {3}", stud1.student_name, stud1.student_details, stud1.course, stud1.roll_number);
            Console.WriteLine("{0} is a {1} studied {2} and was identified with his roll no {3}", stud2.student_name, stud2.student_details, stud2.course, stud2.roll_number);
            Console.WriteLine("{0} is a {1} studied {2} and was identified with his roll no {3}", stud3.student_name, stud3.student_details, stud3.course, stud3.roll_number);
            Console.WriteLine("{0} is a {1} studied {2} and was identified with his roll no {3}", stud4.student_name, stud4.student_details, stud4.course, stud4.roll_number);
            Console.WriteLine("{0} is a {1} studied {2} and was identified with his roll no {3}", stud5.student_name, stud5.student_details, stud5.course, stud5.roll_number);
            Console.ReadLine();
        }
    }

    struct Student
    {
        public string student_details;
        public int roll_number;
        public string student_name;
        public string course;
    }
}

