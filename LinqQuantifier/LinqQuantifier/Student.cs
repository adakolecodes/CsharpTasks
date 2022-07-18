using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuantifier
{
    internal class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public List<Subject> StudentSubjects { get; set; }

        public Student(string name, int marks, List<Subject> studentSubjects)
        {
            Name = name;
            Marks = marks;
            StudentSubjects = studentSubjects;
        }
    }
}
