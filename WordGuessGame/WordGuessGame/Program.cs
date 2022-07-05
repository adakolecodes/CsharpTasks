using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a list to store our words by instantiating word objects in the list
            List<Word> listWords = new List<Word>()
            {
                new Word("1. ereoignatn", "generation"),
                new Word("2. aenirincthe", "inheritance"),
                new Word("3. nirictodya", "dictionary"),
                new Word("4. idgggneub", "debugging"),
                new Word("5. nrgrmamgpio", "programming"),
                new Word("6. trmpoceu", "computer"),
                new Word("7. nwidwos", "windows")
            };

            //Creating a variable for total points earned by the user
            int totalPoints = 0;

            //Loop through our list of words
            foreach (var word in listWords)
            {
                //Display our scrambled words through our DisplayWord method
                DisplayWord(word); //Same thing with doing: Console.WriteLine(word.scrambledWord);

                //for loop used to enable the user attempt a guess up to 3 times
                for (int i = 1; i <= 3; i++)
                {
                    bool guessStatus = CheckInputtedWord(word.unscrambledWord);
                    if (guessStatus == false)
                    {
                        if(i < 3)
                        {
                            Console.WriteLine($"Failed ({i} failure)");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"Failed ({i} failure)");
                            Console.WriteLine($"Answer is: {word.unscrambledWord}");
                            Console.WriteLine();
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Correct!");
                        Console.WriteLine();
                        totalPoints++;
                        break;
                    }
                }
            }

            //Displaying total points earned by user
            Console.WriteLine($"Your total points earned is: {totalPoints}");
            Console.WriteLine();

            //Displaying all scrambled words with their unscrambled words
            foreach(var word2 in listWords)
            {
                Console.WriteLine($"{word2.scrambledWord} = {word2.unscrambledWord}");
            }

            //Method to check if the guessed word is correct
            bool CheckInputtedWord(string correctWord)
            {
                string userInput = Console.ReadLine();
                if(userInput == correctWord)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //Method to display the scrambled word
            void DisplayWord(Word wordParam)
            {
                Console.WriteLine("Unscramble the word below (You have 3 attemps only)");
                Console.WriteLine(wordParam.scrambledWord);
            }


            Console.ReadLine();
        }
    }
}
