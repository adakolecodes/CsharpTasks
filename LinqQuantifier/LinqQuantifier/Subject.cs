using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuantifier
{
    internal class Subject
    {
        public string SubjectName { get; set; }
        public int SubjectMarks { get; set; }

        public Subject(string subjectName, int subjectMarks)
        {
            SubjectName = subjectName;
            SubjectMarks = subjectMarks;
        }
    }
}
