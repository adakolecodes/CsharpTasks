using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuantifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Our data source
            Student[] students = new Student[]
            {
                new Student("Kim", 90, new List<Subject>()
                {
                    new Subject("Maths", 75),
                    new Subject("English", 80),
                    new Subject("Arts", 86),
                    new Subject("History", 91)
                }),
                new Student("John", 80, new List<Subject>()
                {
                    new Subject("Maths", 89),
                    new Subject("English", 91),
                    new Subject("Arts", 90),
                    new Subject("History", 91)
                }),
                new Student("Lee", 75, new List<Subject>()
                {
                    new Subject("Maths", 75),
                    new Subject("English", 80),
                    new Subject("Arts", 60),
                    new Subject("History", 91)
                })
            };



            //QUANTIFIER OPERATORS (Used on a data source to check if an element, some elements or all elements of the data source satisfies a condition)
            //All the methods in the quantifier opperation returns a boolean value

            //All OPERATOR (Checks whether all the elements of a data source satisfy a condition, if all satisfies it returns true, if all does'nt it returns false)
            //Method syntax (Check wether all the students have more than 70 percent mark, output is expected to be either true or false)
            var methodSyntax = students.All(std => std.Marks > 70);

            //Select record where student has more than 70 percent in all his subject
            var methodSyntax2 = students.Where(std => std.StudentSubjects.All(x => x.SubjectMarks > 70)).Select(std => std).ToList();
            


            //Any OPERATOR (Checks whether at least one element of a data source satisfy a condition)



            //Contains OPERATOR (Checks whether the data source has some element with our given value)



            Console.ReadLine();
        }
    }
}
