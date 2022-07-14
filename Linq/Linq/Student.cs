using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Student
    {
        public string _firstName { get; set; }
        public string _secondName { get; set; }
        public string _currentClass { get; set; }
        public double _resultAverage { get; set; }

        public Student(string firstName, string secondName, string currentClass, double resultAverage)
        {
            _firstName = firstName;
            _secondName = secondName;
            _currentClass = currentClass;
            _resultAverage = resultAverage;
        }
    }
}
