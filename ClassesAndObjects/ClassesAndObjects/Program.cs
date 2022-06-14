// See https://aka.ms/new-console-template for more information

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method 1: Creating objects of a class
            QuizQuestion question1 = new QuizQuestion();
            question1.Question = "How many days are in a week?";
            question1.OptionA = "7";
            question1.OptionB = "6";
            question1.OptionC = "8";
            question1.OptionD = "2";
            question1.Answer = "A";

            //Method 2: Creating objects of a class
            QuizQuestion question2 = new QuizQuestion("How many seconds are in a minute?", "20", "60", "50", "12", "B");

            //Storing quiz questions in a list
            List<QuizQuestion> listQuestions = new List<QuizQuestion>()
            {
                new QuizQuestion("How many days are in a week?", "7", "6", "8", "2", "A"),
                new QuizQuestion("How many seconds are in a minute?", "20", "60", "50", "12", "B"),
                new QuizQuestion("How many hours are in a day?", "90", "12", "34", "24", "D"),
                new QuizQuestion("How many minutes are in an hour?", "10", "60", "50", "70", "B")
            };

            //Looping through our listQuestions to display the questions
            foreach (var question in listQuestions)
            {
                Console.WriteLine(question.Question);
            }
        }
    }
}