
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