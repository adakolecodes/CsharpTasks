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



            //Instantiating our variable for getting totalgrade
            int totalgrade = 0;



            //Looping through our listQuestions to display the questions and also call the CheckAnswer method
            foreach (var question in listQuestions)
            {
                AskQuestion(question);
                totalgrade += CheckAnswer(question.Answer);
            }

            //Display the totalgrade after answering all questions
            Console.WriteLine("YOUR RESULT IS: " + totalgrade);



            //Creating a method to check if the answer is correct
            static int CheckAnswer(string correctAnswer)
            {
                string answer = Console.ReadLine();
                if(answer == correctAnswer)
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