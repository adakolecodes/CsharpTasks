using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Creating a list to store our student objects
			List<Student> students = new List<Student>()
			{
				new Student("John", "Doe", "Jss1", 34.2),
				new Student("Jerry", "Mike", "Jss1", 62.1),
				new Student("Jane", "Doe", "Jss1", 54.4),
				new Student("Mike", "Peters", "Sss1", 44.5),
				new Student("Hope", "Abel", "Sss1", 24.5),
			};

			//FILTERING OPERATORS
			//The two types of filtering operators used for filtering through record are the Where and OfType
			
			//Where FILTERING OPERATOR
			//Query syntax (Select all students in Jss1)
			var querySyntax = from std in students
							  where std.CurrentClass == "Jss1"
							  select std;


			//Method syntax (Select all students in Jss1)
			var methodSyntax = students.Where(std => std.CurrentClass == "Jss1");


			//Mixed syntax (Gets the students with the maximum result average)
			var mixedSyntax = (from std in students
							   select std.ResultAverage).Max();
			//We console writeline mixedSyntax because we have only one filtered record, thus we can't loop only one record
			Console.WriteLine(mixedSyntax);


			//Looping through our students list to display all our students
			foreach (var student in methodSyntax)
            {
				Console.WriteLine($"First name: {student.FirstName}, Second name: {student.SecondName}, Current class: {student.CurrentClass}, Result average: {student.ResultAverage}");
            }


			//OfType FILTERING OPERATOR

			//Our dataSource
			List<object> dataSource = new List<object>() {"Job", "Peace", "Mark", 1, 2, 3, 4, 5, 6 };


			//Method syntax (This will get list items which are string. If string is changed to int, it will get only items in the list that are int)
			var ofTypeMethodSyntax = dataSource.OfType<string>().ToList();


			//Query syntax (This will return list items which are int)
			var ofTypeQuerySyntax = (from x in dataSource
									 where x is int
									 select x).ToList();


			//Using OfType and Where filtering operator together
			//Method syntax (Get items in the list that are string whose length is greater than or equals to 5)
			var ofTypeAndWhereMethodSyntax = dataSource.OfType<string>().Where(x => x.Length >= 5).ToList();

			
			Console.ReadKey();
		}
	}
}
