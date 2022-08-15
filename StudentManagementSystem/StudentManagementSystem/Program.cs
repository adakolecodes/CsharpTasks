using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new List<Student>()
            {
                new Student(){
                    Id = 1,
                    FirstName = "John",
                    Surname = "Doe",
                    StudentClass = "Sss1",
                    Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Agricultural Science", SubjectClass = "Sss1", Score = 54},
                        new Subject(){SubjectName = "Biology", SubjectClass = "Jss2", Score = 54},
                        new Subject(){SubjectName = "Biology", SubjectClass = "Sss1", Score = 30},
                        new Subject(){SubjectName = "Biology", SubjectClass = "Sss1", Score = 30}

                    }
                }
            };
        }
    }
}
