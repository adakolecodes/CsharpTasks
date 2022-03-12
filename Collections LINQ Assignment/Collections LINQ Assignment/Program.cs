using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_LINQ_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
			var people = new List<Person>()
			{
				new Person("Bill", "Smith", 41),
				new Person("Sarah", "Jones", 22),
				new Person("Stacy","Baker", 21),
				new Person("Vivianne","Dexter", 19 ),
				new Person("Bob","Smith", 49 ),
				new Person("Brett","Baker", 51 ),
				new Person("Mark","Parker", 19),
				new Person("Alice","Thompson", 18),
				new Person("Evelyn","Thompson", 58 ),
				new Person("Mort","Martin", 58),
				new Person("Eugene","deLauter", 84 ),
				new Person("Gail","Dawson", 19 ),
			};

			//QUESTION: write linq statement for all the people who are have the surname Thompson and Baker. Write all the first names to the console
			//SOLUTION 2
			var targets = people.Where(x => x.LastName == "Thompson" || x.LastName == "Baker");
			//We have target list where everyone has the surname of either Thomson or Baker
			List<Person> targetList = targets.ToList();
			//Looping through our target list
			foreach (Person mylist in targetList)
			{
				Console.WriteLine(mylist.FirstName);
			}

			//QUESTION: write linq statement for the people with last name that starts with the letter D
			//SOLUTION 1
			var targets2 = people.Where(y => y.LastName.Substring(0, 1) == "D");
			List<Person> targetList2 = targets2.ToList();

			//Get the count of the number of people who's last name starts with letter D
			Console.WriteLine(targetList2.Count);

			//Display the number of people who's last name starts with letter D
			foreach (Person mylist2 in targetList2)
			{
				Console.WriteLine(mylist2.LastName);
			}


			Console.ReadKey();
		}

		public class Person
		{
			public Person(string firstName, string lastName, int age)
			{
				FirstName = firstName;
				LastName = lastName;
				Age = age;
			}

			public string FirstName { get; set; }
			public string LastName { get; set; }
			public int Age { get; set; }

		}
	}
}
