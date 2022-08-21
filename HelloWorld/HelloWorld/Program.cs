// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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



Dictionary<int, string> customers = new Dictionary<int, string>();
customers.Add(1, "Moses");
customers.Add(2, "James");
customers.Add(3, "Peace");
customers.Add(4, "Faith");

customers[1] = "Brandy";
customers[5] = "Mabel";
customers.Remove(1);

Console.WriteLine(customers[3]);
Console.WriteLine(customers.ContainsKey(3));

foreach(var customer in customers)
{
    Console.WriteLine(customer);
    Console.WriteLine(customer.Key);
    Console.WriteLine(customer.Value);
}