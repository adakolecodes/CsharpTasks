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

			//Linq Query sintax
			var querySyntax = from std in students
							  where std._currentClass == "Jss1"
							  select std;

			//Looping through our students list to display all our students
			foreach (var student in querySyntax)
            {
				Console.WriteLine($"First name: {student._firstName}, Second name: {student._secondName}, Current class: {student._currentClass}, Result average: {student._resultAverage}");
            }

			Console.ReadKey();
		}
	}
}
