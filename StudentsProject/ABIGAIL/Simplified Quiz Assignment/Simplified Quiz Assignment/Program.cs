// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int score = 0;
int totalscore = 0;
int attemptLeft = 5;

List<string> dict = new List<string>();


while (true)
{
    Console.WriteLine("Enter your registration number");
    dict.Add("2022ABCDEF");
    dict.Add("2022BCDEFG");
    dict.Add("2022CDEFGH");
    dict.Add("2022DEFGHI");
    dict.Add("2022EFGHIJ");
    
    for (int i = 1; i <= 5; i = i + 1) 
    {
        string reg = Console.ReadLine();
        Console.WriteLine($"You have {attemptLeft = attemptLeft - 1} attempt left");
        
        if (dict.Contains(reg))
        {
            Console.WriteLine("YOU HAVE SUCCESSFULLY LOGGED IN");

            bool finish = false;
            MyQuestions("1. Which of the following resoures cannot be conserved?.", "Forest", "Water", "Soil", "Garbage");
            string quest1 = Console.ReadLine();
            if (quest1 == "D")
            {
                Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
                totalscore++;
            }
            else if (quest1 != "A" && quest1 != "B" && quest1 != "C" && quest1 != "D")
            {
                Console.WriteLine("INVALID COMMAND. YOU HAVE FAILED THIS ROUND.");
            }
            else
            {
                Console.WriteLine("YOU FAILED THIS ROUND.");
            }
            Console.WriteLine(" ");

            MyQuestions("2. Which of the following is common in both plant and animal cell?.", "Cellulose", "Chlorophyll.", "Cell membrane.", "Large vacuole.");
            string quest2 = Console.ReadLine();
            if (quest2 == "C")
            {

                Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
                totalscore++;
            }
            else if (quest2 != "A" && quest2 != "B" && quest2 != "C" && quest2 != "D")
            {
                Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
            }
            else
            {
                Console.WriteLine("YOU FAILED THIS ROUND.");
            }
            Console.WriteLine(" ");

            MyQuestions("3. A plant which grows on another plant without an apparent harm to the host is called..?.", "Parasite.", "Epiphyte.", "Saprophyte.", "Predator.");
            string quest3 = Console.ReadLine();
            if (quest3 == "C")
            {
                Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
                totalscore++;
            }
            else if (quest3 != "A" && quest3 != "B" && quest3 != "C" && quest3 != "D")
            {
                Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
            }
            else
            {
                Console.WriteLine("YOU FAILED THIS ROUND.");
            }
            Console.WriteLine(" ");

            MyQuestions("4. The following are types of fingerprints except..?.", "Simple.", " Whorl.", "Loop.", "Compound.");
            string quest4 = Console.ReadLine();
            if (quest4 == "A")
            {
                Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
                totalscore++;
            }
            else if (quest4 != "A" && quest4 != "B" && quest4 != "C" && quest4 != "D")
            {
                Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
            }
            else
            {
                Console.WriteLine("YOU FAILED THIS ROUND.");
            }
            Console.WriteLine(" ");

            MyQuestions("5. Modern humans belong to the species of ....?.", "Homo sapiens.", "Homo erectus.", "Homo habilis.", "Homo Neanderthal man.");
            string quest5 = Console.ReadLine();
            if (quest5 == "A")
            {
                Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
                totalscore++;
            }
            else if (quest5 != "A" && quest5 != "B" && quest5 != "C" && quest5 != "D")
            {
                Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
            }
            else
            {
                Console.WriteLine("YOU FAILED THIS ROUND.");
            }
            Console.WriteLine(" ");

            MyQuestions("6. Detoxification of urea takes place in the...?.", " Pancreas.", " Heart.", "Lungs.", "Liver.");
            string quest6 = Console.ReadLine();
            if (quest6 == "D")
            {
                Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
                totalscore++;
            }
            else if (quest6 != "A" && quest6 != "B" && quest6 != "C" && quest6 != "D")
            {
                Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
            }
            else
            {
                Console.WriteLine("YOU FAILED THIS ROUND.");
            }
            Console.WriteLine(" ");

            MyQuestions("7.  Rabbits cannot survive in an aquatic habit because they have..?.", "No scales.", " No gills.", "Forelimbs.", "Lateral line.");
            string quest7 = Console.ReadLine();
            if (quest7 == "B")
            {
                Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
                totalscore++;
            }
            else if (quest7 != "A" && quest7 != "B" && quest7 != "C" && quest7 != "D")
            {
                Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
            }
            else
            {
                Console.WriteLine("YOU FAILED THIS ROUND.");
            }
            Console.WriteLine(" ");

            MyQuestions("8.  Which of the following organisms exhibits division of labour?.", "Butterfly.", "Cockroach.", "Termite.", "Housefly.");
            string quest8 = Console.ReadLine();
            if (quest8 == "C")
            {
                Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
                totalscore++;
            }
            else if (quest8 != "A" && quest8 != "B" && quest8 != "C" && quest8 != "D")
            {
                Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
            }
            else
            {
                Console.WriteLine("YOU FAILED THIS ROUND.");
            }
            Console.WriteLine(" ");

            MyQuestions("9. Which of the following hormones is suddenly secreted into the bloodstream of a frightened person?.", "Insulin.", "Adrenaline.", "Thyroxin.", "Para hormone.");
            string quest9 = Console.ReadLine();
            if (quest9 == "B")
            {
                Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
                totalscore++;
            }
            else if (quest9 != "A" && quest9 != "B" && quest9 != "C" && quest9 != "D")
            {
                Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
            }
            else
            {
                Console.WriteLine("YOU FAILED THIS ROUND.");
            }
            Console.WriteLine(" ");

            MyQuestions("10.  Natural selection arises as a result of..?.", "Gene mutation.", "Change of habitat.", "Reduction in population", "Climate change.");
            string quest10 = Console.ReadLine();
            if (quest10 == "D")
            {
                Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
                totalscore++;
            }
            else if (quest10 != "A" && quest10 != "B" && quest10 != "C" && quest10 != "D")
            {
                Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
            }
            else
            {
                Console.WriteLine("YOU FAILED THIS ROUND.");
            }
            Console.WriteLine(" ");
            finish = true;

            Console.WriteLine($"TOTAL SCORE = {totalscore}");
            Console.WriteLine(" ");
            break;
        }
        else 
        {
            Console.WriteLine("REGISTERATION NUMBER NOT FOUND");
        }

        if (!dict.Contains(reg) && i >= 5)
        {
            Console.WriteLine("YOUR ACCOUNT HAS BEEN BLOCKED");
        }
    }
    

    break;

    /*
    if (dict.Contains(reg))
    {
        Console.WriteLine("YOU HAVE SUCCESSFULLY LOGGED IN");

        bool finish = false;
        MyQuestions("1. Which of the following resoures cannot be conserved?.", "Forest", "Water", "Soil", "Garbage");
        string quest1 = Console.ReadLine();
        if (quest1 == "D")
        {
            Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
            totalscore++;
        }
        else if (quest1 != "A" && quest1 != "B" && quest1 != "C" && quest1 != "D")
        {
            Console.WriteLine("INVALID COMMAND. YOU HAVE FAILED THIS ROUND.");
        }
        else
        {
            Console.WriteLine("YOU FAILED THIS ROUND.");
        }
        Console.WriteLine(" ");

        MyQuestions("2. Which of the following is common in both plant and animal cell?.", "Cellulose", "Chlorophyll.", "Cell membrane.", "Large vacuole.");
        string quest2 = Console.ReadLine();
        if (quest2 == "C")
        {

            Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
            totalscore++;
        }
        else if (quest2 != "A" && quest2 != "B" && quest2 != "C" && quest2 != "D")
        {
            Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
        }
        else
        {
            Console.WriteLine("YOU FAILED THIS ROUND.");
        }
        Console.WriteLine(" ");

        MyQuestions("3. A plant which grows on another plant without an apparent harm to the host is called..?.", "Parasite.", "Epiphyte.", "Saprophyte.", "Predator.");
        string quest3 = Console.ReadLine();
        if (quest3 == "C")
        {
            Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
            totalscore++;
        }
        else if (quest3 != "A" && quest3 != "B" && quest3 != "C" && quest3 != "D")
        {
            Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
        }
        else
        {
            Console.WriteLine("YOU FAILED THIS ROUND.");
        }
        Console.WriteLine(" ");

        MyQuestions("4. The following are types of fingerprints except..?.", "Simple.", " Whorl.", "Loop.", "Compound.");
        string quest4 = Console.ReadLine();
        if (quest4 == "A")
        {
            Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
            totalscore++;
        }
        else if (quest4 != "A" && quest4 != "B" && quest4 != "C" && quest4 != "D")
        {
            Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
        }
        else
        {
            Console.WriteLine("YOU FAILED THIS ROUND.");
        }
        Console.WriteLine(" ");

        MyQuestions("5. Modern humans belong to the species of ....?.", "Homo sapiens.", "Homo erectus.", "Homo habilis.", "Homo Neanderthal man.");
        string quest5 = Console.ReadLine();
        if (quest5 == "A")
        {
            Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
            totalscore++;
        }
        else if (quest5 != "A" && quest5 != "B" && quest5 != "C" && quest5 != "D")
        {
            Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
        }
        else
        {
            Console.WriteLine("YOU FAILED THIS ROUND.");
        }
        Console.WriteLine(" ");

        MyQuestions("6. Detoxification of urea takes place in the...?.", " Pancreas.", " Heart.", "Lungs.", "Liver.");
        string quest6 = Console.ReadLine();
        if (quest6 == "D")
        {
            Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
            totalscore++;
        }
        else if (quest6 != "A" && quest6 != "B" && quest6 != "C" && quest6 != "D")
        {
            Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
        }
        else
        {
            Console.WriteLine("YOU FAILED THIS ROUND.");
        }
        Console.WriteLine(" ");

        MyQuestions("7.  Rabbits cannot survive in an aquatic habit because they have..?.", "No scales.", " No gills.", "Forelimbs.", "Lateral line.");
        string quest7 = Console.ReadLine();
        if (quest7 == "B")
        {
            Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
            totalscore++;
        }
        else if (quest7 != "A" && quest7 != "B" && quest7 != "C" && quest7 != "D")
        {
            Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
        }
        else
        {
            Console.WriteLine("YOU FAILED THIS ROUND.");
        }
        Console.WriteLine(" ");

        MyQuestions("8.  Which of the following organisms exhibits division of labour?.", "Butterfly.", "Cockroach.", "Termite.", "Housefly.");
        string quest8 = Console.ReadLine();
        if (quest8 == "C")
        {
            Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
            totalscore++;
        }
        else if (quest8 != "A" && quest8 != "B" && quest8 != "C" && quest8 != "D")
        {
            Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
        }
        else
        {
            Console.WriteLine("YOU FAILED THIS ROUND.");
        }
        Console.WriteLine(" ");

        MyQuestions("9. Which of the following hormones is suddenly secreted into the bloodstream of a frightened person?.", "Insulin.", "Adrenaline.", "Thyroxin.", "Para hormone.");
        string quest9 = Console.ReadLine();
        if (quest9 == "B")
        {
            Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
            totalscore++;
        }
        else if (quest9 != "A" && quest9 != "B" && quest9 != "C" && quest9 != "D")
        {
            Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
        }
        else
        {
            Console.WriteLine("YOU FAILED THIS ROUND.");
        }
        Console.WriteLine(" ");

        MyQuestions("10.  Natural selection arises as a result of..?.", "Gene mutation.", "Change of habitat.", "Reduction in population", "Climate change.");
        string quest10 = Console.ReadLine();
        if (quest10 == "D")
        {
            Console.WriteLine("YOU PASSED THIS ROUND AND HAVE BEEN GIVEN 1 POINT.");
            totalscore++;
        }
        else if (quest10 != "A" && quest10 != "B" && quest10 != "C" && quest10 != "D")
        {
            Console.WriteLine("INVALID COMMAND. YOU FAILED THIS ROUND.");
        }
        else
        {
            Console.WriteLine("YOU FAILED THIS ROUND.");
        }
        Console.WriteLine(" ");
        finish = true;

        Console.WriteLine($"TOTAL SCORE = {totalscore}");
        Console.WriteLine(" ");
        break;
    }
    else
    {
        Console.WriteLine("REGISTRATION NUMBER NOT FOUND");
    }

    */

}
static void MyQuestions(string quest, string option1, string option2, string option3, string option4 )
{
    Console.WriteLine(quest);
    Console.WriteLine("A " + option1);
    Console.WriteLine("B " + option2);
    Console.WriteLine("C " + option3);
    Console.WriteLine("D " + option4);
}