using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person()
            {
                Name = "Amos",
                Age = 20
            };
            Person person2 = new Person()
            {
                Name = "Mike",
                Age = 35
            };
            Person person3 = new Person()
            {
                Name = "Mercy",
                Age = 27
            };
            Person person4 = new Person()
            {
                Name = "Amos",
                Age = 12
            };
            List<Person> list = new List<Person>()
            {
                person1,
                person2,
                person3,
                person4,
            };

            //Changing the age of every person in our list to 10 using for loop
            for(int x = 0; x < list.Count; x++)
            {
                list[x].Age = 10;
            }

            //Using foreach. Foreach loop does not care about the index
            foreach(Person currentPerson in list)
            {
                currentPerson.Age = 2;
            }

            //How to go through our list, find someone with the name Mercy and change the age to 50
            foreach(Person currentPerson in list)
            {
                if(currentPerson.Name == "Mercy")
                {
                    currentPerson.Age = 50;
                }
            }

            //LINQ select and where. We can use LINQ to achieve same last example above. We can use LINQ on anything that is IEnumerable - a list is one
            //This creates a new list based on a syntax. It creates a new list of everyone who has the name of Mercy. (x below can be anything)
            var targets = list.Where(x => x.Name == "Mercy");
            //We have target list where everyone is just Mercy
            List<Person> targetList = targets.ToList();
            //Looping through our target list
            foreach(Person mercys in targetList)
            {
                mercys.Age = 50;
            }
            //NOTE:
            //We use .Where to filter things from a list to make a new list

            //LINQ .Select
            //What we get here is not people but just the list of the values of the length of their names
            var selectTargets = list.Select(x => x.Name.Length);
            foreach(var value in selectTargets)
            {
                Console.WriteLine(value);
            }

            //HOME WORK

        }

        class Person
        {
            public int Age;
            public string Name;
        }
    }
}
