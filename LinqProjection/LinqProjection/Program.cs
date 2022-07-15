using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProjection
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Creating a list to store our employee objects
			List<Employee> employees = new List<Employee>()
			{
				new Employee(1, "John Doe", "johndoe@gmail.com", new List<Technology>(){
					new Technology("Csharp"),
					new Technology("PHP"),
					new Technology("Python"),
				}),
				new Employee(2, "Sarah Smith", "sarahsmith@gmail.com", new List<Technology>(){
					new Technology("Ruby"),
					new Technology("PHP"),
					new Technology("Vue Js"),
				}),
				new Employee(3, "Mark Peterson", "markpeterson@gmail.com", new List<Technology>(){
					new Technology("React"),
					new Technology("C++"),
					new Technology("Csharp"),
				}),
				new Employee(4, "Robin Hood", "robinhood@gmail.com", new List<Technology>(){
					new Technology("Node Js"),
					new Technology("JavaScript"),
					new Technology("Vue Js"),
				}),
			};

			//PROJECTION
			//Two types of projection methods are Select and SelectMany

			//SELECT PROJECTION
			//Query syntax
			//(ToList method is only required if you wan't to store the selected records in the querySyntax variable, else ignore it).
			var querySyntax = (from emp in employees
							  select emp).ToList();


			//Method syntax
			var methodSyntax = employees.ToList();


			//Applying operations on select (Selecting only email)
			//Query syntax
			//When looping through this, we don't reference the property anymore
			var querySyntaxOp = (from emp in employees
								 select emp.Email).ToList();


			//Method syntax
			var methodSyntaxOp = employees.Select(emp => emp.Email).ToList();


			//SELECT MANY PROJECTION (Selecting only language by selecting programming - programming is a list of language)
			//Query syntax
			var querySyntax2 = (from emp in employees
							   from lang in emp.Programming
							   select lang).ToList();
			
			
			//Method syntax
			var methodSyntax2 = employees.SelectMany(emp => emp.Programming).ToList();



			//Looping through our employees list to display all our employees
			foreach (var employee in methodSyntax)
			{
				Console.WriteLine($"Employee Id: {employee.EmployeeId}, Full name: {employee.FullName}, Email: {employee.Email}");
			}

			Console.ReadKey();
		}
	}
}
