using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGuessGame
{
    internal class Word
    {
        public string scrambledWord { get; set; }
        public string unscrambledWord { get; set; }

        public Word(string sw, string uw)
        {
            scrambledWord = sw;
            unscrambledWord = uw;
        }

        public Word()
        {

        }
    }
}
