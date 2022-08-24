// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//string myname = "Daniel";
//int age = 59;
//double height = 12.5;
//bool male = true;


//string userinput;
//userinput = Console.ReadLine();
//Console.Write($"The user entered {userinput}");

//Console.WriteLine("Enter first number");
//string num1 = Console.ReadLine();
//Console.WriteLine("Enter second number");
//string num2 = Console.ReadLine();
//int total = int.Parse(num1) + int.Parse(num2);
//Console.WriteLine("Total is: " + total);




//Console.WriteLine("Enter first number");
//string num1 = Console.ReadLine();
//Console.WriteLine("Enter second number");
//string num2 = Console.ReadLine();
//Console.WriteLine("Enter third number");
//string num3 = Console.ReadLine();
//Console.WriteLine($"Your total is {(int.Parse(num1) + int.Parse(num2)) * int.Parse(num3)}");






//string num1 = "46.23";
//double num2 = 22.67;
//Console.WriteLine(double.Parse(num1) + num2);



//Dictionary<int, string> customers = new Dictionary<int, string>();
//customers.Add(1, "Moses");
//customers.Add(2, "James");
//customers.Add(3, "Peace");
//customers.Add(4, "Faith");

//customers[1] = "Brandy";
//customers[5] = "Mabel";
//customers.Remove(1);

//Console.WriteLine(customers[3]);
//Console.WriteLine(customers.ContainsKey(3));

//foreach(var customer in customers)
//{
//    Console.WriteLine(customer);
//    Console.WriteLine(customer.Key);
//    Console.WriteLine(customer.Value);
//}



List<Student> students = new List<Student>()
{
    new Student("Fisher", "Boat", "Jss3", 63.2),
    new Student("John", "Doe", "Jss1", 34.2),
    new Student("Jerry", "Mike", "Jss1", 62.1),
    new Student("Jane", "Doe", "Jss1", 54.4),
    new Student("Mike", "Peters", "Sss1", 44.5),
    new Student("Hope", "Abel", "Sss1", 24.5),
    new Student("Moses", "Peters", "Sss3", 42.5),
};

//This gives us the record of John Doe in Jss1
var methodSyntax = students.Where(std => std.CurrentClass == "Jss1").First();

Console.WriteLine(@$"
First name: {methodSyntax.FirstName}, 
Second name: {methodSyntax.SecondName}, 
Current class: {methodSyntax.CurrentClass}, 
Result average: {methodSyntax.ResultAverage}");


//foreach (var student in methodSyntax)
//{
//    Console.WriteLine($"First name: {student.FirstName}, Second name: {student.SecondName}, Current class: {student.CurrentClass}, Result average: {student.ResultAverage}");
//}


var letter = "Cam (Rhee)";
//var output = ($"{letter.Split('(', ')')[0]}{letter.Split('(', ')')[1]}");
var output = letter.Replace("(", string.Empty).Replace(")", string.Empty);

Console.WriteLine(output);




public class Student
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string CurrentClass { get; set; }
    public double ResultAverage { get; set; }

    public Student(string firstName, string secondName, string currentClass, double resultAverage)
    {
        FirstName = firstName;
        SecondName = secondName;
        CurrentClass = currentClass;
        ResultAverage = resultAverage;
    }
}