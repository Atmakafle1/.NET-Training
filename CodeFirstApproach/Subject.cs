using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApproach
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCategory { get; set; }

        public Teacher Teacher { get; set; }
        
    }
}