// See https://aka.ms/new-console-template for more information

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method 1: Creating an object of QuizQuestion class
            QuizQuestion question1 = new QuizQuestion();
            question1._question = "How many days are in a week?";
            question1._optionA = "7";
            question1._optionB = "6";
            question1._optionC = "8";
            question1._optionD = "2";
            question1._answer = "A";

            //Method 2: Creating an object of QuizQuestion class
            QuizQuestion question2 = new QuizQuestion("How many seconds are in a minute?", "20", "60", "50", "12", "B");
        }
    }
}