using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a list to store our QuizQuestion objects
            List<QuizQuestion> listQuestions = new List<QuizQuestion>()
            {
                new QuizQuestion("How many days are in a week?", "7", "6", "8", "2", "A"),
                new QuizQuestion("How many seconds are in a minute?", "20", "60", "50", "12", "B"),
                new QuizQuestion("How many hours are in a day?", "90", "12", "34", "24", "D"),
                new QuizQuestion("How many minutes are in an hour?", "10", "60", "50", "70", "B")
            };

            //Looping through our list of questions and displaying the question, option A and option B, you can add others
            foreach(var question in listQuestions)
            {
                Console.WriteLine($"Question: {question._question}, Opt A: {question._optionA}, Opt B: {question._optionB}");
            }

            Console.ReadLine();
        }
    }
}
