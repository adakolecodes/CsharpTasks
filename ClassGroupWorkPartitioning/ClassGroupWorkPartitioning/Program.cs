using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGroupWorkPartitioning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 10,33,6,7,8,9,10,3, 4, 5, };

            var MethodSyntax = numbers.Take(4).ToList();

            var ms = numbers.TakeWhile(num=>num<33).ToList();

 

            Console.ReadLine();
        }
    }
}
