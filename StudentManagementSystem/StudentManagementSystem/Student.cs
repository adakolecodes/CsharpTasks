using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Student
    {
        public Student()
        {
            Subjects = new List<Subject>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string StudentClass { get; set; }

        public List<Subject> Subjects { get; set; }

        public List<Result> Results { get; set; }
    }
}
