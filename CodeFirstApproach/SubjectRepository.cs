using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApproach
{
    public class SubjectRepository
    {
        public List<Teacher> GetTeachers()
        {
            SubjectDBContext subContext = new SubjectDBContext();
            return subContext.Teachers.ToList();
        }

        public void UpdateTeachers(int id)
        {
            SubjectDBContext subContext = new SubjectDBContext();
            var c = (from teach in subContext.Teachers
                     where teach.TeacherID == id
                     select teach).Single();
            c.TeacherID = 2;
            c.TeacherName = "CSG csg";
            subContext.SaveChanges();

        }
    }
}