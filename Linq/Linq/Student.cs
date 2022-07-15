using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string CurrentClass { get; set; }
        public double ResultAverage { get; set; }

        public Student(string firstName, string secondName, string currentClass, double resultAverage)
        {
            FirstName = firstName;
            SecondName = secondName;
            CurrentClass = currentClass;
            ResultAverage = resultAverage;
        }
    }
}
