using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApproach
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public int SubjectID { get; set; }

        public List<Subject> Subjects { get; set; }
    }
}