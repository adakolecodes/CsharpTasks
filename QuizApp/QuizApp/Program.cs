// See https://aka.ms/new-console-template for more information

Dictionary<string, string> questions = new Dictionary<string, string>();

questions.Add("4", "How many days are in a week?");
questions.Add("60", "How many seconds are in a minute?");
questions.Add("24", "How many hours in a day?");


while (true)
{
    int grade = 0;

    Console.WriteLine(questions["4"]);
    Console.WriteLine("2");
    Console.WriteLine("4");
    Console.WriteLine("5");
    Console.WriteLine("20");
    string answer = Console.ReadLine();
    if(answer == "4")
    {
        Console.WriteLine("Pass");
        grade++;
        Console.WriteLine("You have gotten " + grade + " point");
    }
    else
    {
        Console.WriteLine("Fail");
    }
    Console.WriteLine(questions["60"]);
    Console.WriteLine("2");
    Console.WriteLine("4");
    Console.WriteLine("5");
    Console.WriteLine("20");
    string answer2 = Console.ReadLine();
    if (answer == "4")
    {
        Console.WriteLine("Pass");
        grade++;
        Console.WriteLine("You have gotten " + grade + " point");
    }
    else
    {
        Console.WriteLine("Fail");
    }
}