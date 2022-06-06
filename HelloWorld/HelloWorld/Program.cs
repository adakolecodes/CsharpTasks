// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string myname = "Daniel";
int age = 59;
double height = 12.5;
bool male = true;


//string userinput;
//userinput = Console.ReadLine();
//Console.Write($"The user entered {userinput}");

//Console.WriteLine("Enter first number");
//string num1 = Console.ReadLine();
//Console.WriteLine("Enter second number");
//string num2 = Console.ReadLine();
//int total = int.Parse(num1) + int.Parse(num2);
//Console.WriteLine("Total is: " + total);




Console.WriteLine("Enter first number");
string num1 = Console.ReadLine();
Console.WriteLine("Enter second number");
string num2 = Console.ReadLine();
Console.WriteLine("Enter third number");
string num3 = Console.ReadLine();
Console.WriteLine($"Your total is {(int.Parse(num1) + int.Parse(num2)) * int.Parse(num3)}");