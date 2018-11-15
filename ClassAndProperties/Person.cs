using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndProperties
{
    class Person
    {
        public String firstName, lastName;
        String SSN;
        int age;
    }

    class Student :Person
    {
        public String Level;
        public bool isStudentInDistinctionList = false;
        public String studentAcademicStanding;
    }
    class Employee : Person
    {
        String employeeID;
        public String empType;
        private int salary;
        public int noOfYearsInService;
    }
}
