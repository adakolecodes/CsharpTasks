using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();

            //Accessing the various modifiers

            //We can access eyes because the field is declared public
            human1.eyes = 2;

            //We cannot access legs because the field is declared private
            human1.legs = 2;

            //We can access color as an internal field because both the
            //Program class and Human class belong to the same assembly
            human1.color = "Chocolate";
        }
    }
}
