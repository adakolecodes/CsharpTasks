// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class MyClass
{
    // it will use the default constructor: below
    // public MyClass()
    // {
    // }
}

class QuizQuestion
{
    // parameterless constructor - default constructor
    public QuizQuestion()
    {
        
    }
    public QuizQuestion(string question, string optA, string optB, string optC, string optD, string answer)
    {
        Question = question;
        OptionA = optA;
        OptionB = optB;
        OptionC = optC;
        OptionD = optD;
        Answer = answer;
    }

    public string Question { get; set; }
    public string OptionA { get; set; }
    public string OptionB { get; set; }
    public string OptionC { get; set; }
    public string OptionD { get; set; }
    public string Answer { get; set; }
}



class Program
{
    private static List<QuizQuestion> _questions = new List<QuizQuestion>()
    {
        new QuizQuestion()
        {
            Question = "How many days are in a week?",
            OptionA = "7",
            OptionB = "6",
            OptionC = "8",
            OptionD = "2",
            Answer = "A",
        },
        new QuizQuestion("How many seconds are in a minute?", "20", "60", "50", "12", "B"),
        new QuizQuestion("How many hours in a day?", "90", "12", "34", "24", "D"),
        new QuizQuestion()
        {
            Question = "Who is the best person in the world",
            OptionA = "David",
            OptionB = "Daniel",
            OptionC = "Lore",
            OptionD = "Jacob",
            Answer = "B"
        }
    };

    static void Main()
    {
        int totalgrade = 0;


        // Equivalent: var it = new QuizQuestion { Answer = "A", OptionA = "Test" };
        var it = new QuizQuestion();
        it.Answer = "A";
        it.OptionA = "Test";

        foreach (var quizQuestion in _questions)
        {
            AskQuestion(quizQuestion);
            totalgrade += CheckAnswerIs(quizQuestion.Answer);
        }

        Console.WriteLine("YOUR RESULT IS: " + totalgrade);
    }

    private static int CheckAnswerIs(string correctAnswer)
    {
        string answer = Console.ReadLine();
        if (correctAnswer.Equals(answer, StringComparison.InvariantCultureIgnoreCase))
        {
            Console.WriteLine("PASS! You have gotten 1 point");
            return 1;
        }
        else
        {
            Console.WriteLine("FAILED");
            return 0;
        }
    }

    static void AskQuestion(QuizQuestion quizQuestion)
    {
        Console.WriteLine(quizQuestion.Question);
        Console.WriteLine("A)" + quizQuestion.OptionA);
        Console.WriteLine("B)" + quizQuestion.OptionB);
        Console.WriteLine("C)" + quizQuestion.OptionC);
        Console.WriteLine("D)" + quizQuestion.OptionD);
        Console.Write("Enter option: ");
    }
}

