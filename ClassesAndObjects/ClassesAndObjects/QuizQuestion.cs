using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class QuizQuestion
    {
        public string _question;
        public string _optionA;
        public string _optionB;
        public string _optionC;
        public string _optionD;
        public string _answer;

        public QuizQuestion(string quest, string optA, string optB, string optC, string optD, string ans)
        {
            _question = quest;
            _optionA = optA;
            _optionB = optB;
            _optionC = optC;
            _optionD = optD;
            _answer = ans;
        }

        //Default constructor that is used when no parameter is set
        public QuizQuestion()
        {

        }

    }
}
