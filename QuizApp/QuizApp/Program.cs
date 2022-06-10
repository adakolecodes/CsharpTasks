// See https://aka.ms/new-console-template for more information

bool finished = false;

while (finished == false)
{
    int grade = 0;
    int totalgrade = 0;

    SetQuestions("How many days are in a week?", "7", "6", "8", "2");
    string optionQ1 = Console.ReadLine();
    if (optionQ1 == "A")
    {
        Console.WriteLine("PASS! You have gotten 1 point");
        totalgrade++;
    }
    else
    {
        Console.WriteLine("FAILED");
    }

    SetQuestions("How many seconds are in a minute?", "20", "60", "50", "12");
    string optionQ2 = Console.ReadLine();
    if (optionQ2 == "B")
    {
        Console.WriteLine("PASS! You have gotten 1 point");
        totalgrade++;
    }
    else
    {
        Console.WriteLine("FAILED");
    }

    SetQuestions("How many hours in a day?", "90", "12", "34", "24");
    string optionQ3 = Console.ReadLine();
    if (optionQ3 == "D")
    {
        Console.WriteLine("PASS! You have gotten 1 point");
        totalgrade++;
    }
    else
    {
        Console.WriteLine("FAILED");
    }

    Console.WriteLine("YOUR RESULT IS: " + totalgrade);

    finished = true;
}



static void SetQuestions(string question, string option1, string option2, string option3, string option4)
{
    Console.WriteLine(question);
    Console.WriteLine("A)" + option1);
    Console.WriteLine("B)" + option2);
    Console.WriteLine("C)" + option3);
    Console.WriteLine("D)" + option4);
    Console.Write("Enter option: ");
}