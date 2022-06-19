using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedQuizApp
{
    internal class QuizQuestion
    {
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string Answer { get; set; }

        public QuizQuestion(string quest, string optA, string optB, string optC, string optD, string ans)
        {
            Question = quest;
            OptionA = optA;
            OptionB = optB;
            OptionC = optC;
            OptionD = optD;
            Answer = ans;
        }

        //Default constructor that is used when no parameter is set
        public QuizQuestion()
        {

        }
    }
}
