// See https://aka.ms/new-console-template for more information

namespace SimplifiedQuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
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
                AskQuestion(question);
            }

            //Collecting each question from our list and parsing it into our AskQuestion method
            static void AskQuestion(QuizQuestion question)
            {
                Console.WriteLine(question.Question);
                Console.WriteLine("A)" + question.OptionA);
                Console.WriteLine("B)" + question.OptionB);
                Console.WriteLine("C)" + question.OptionC);
                Console.WriteLine("D)" + question.OptionD);
                Console.WriteLine("Enter option: ");
            }
        }
    }
}