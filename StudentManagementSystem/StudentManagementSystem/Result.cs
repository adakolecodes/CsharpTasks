using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Result
    {
        public List<Subject> Subjects { get; set; }

        public string ResultClass { get; set; }

        public string ResultTerm { get; set; }

        public string ResultAverage { get; set; }
    }
}
