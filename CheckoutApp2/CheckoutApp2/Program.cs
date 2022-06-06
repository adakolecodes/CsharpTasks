using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<char, int>
            {
                {'A', 50},
                {'B', 30},
                {'C', 20},
                {'D', 5}
            };

            var result = Checkout("ABCA");


            int Checkout(string input)
            {
                var items = input.ToCharArray();
                var totalCost = 0;

                foreach (var item in items)
                {
                    totalCost += products[item];
                }

                if (items.Length > 10)
                {
                    totalCost -= (totalCost / 100 * 10);
                }

                //Count occurance of 'B'
                var allB = items.Count(x => x == 'B');

                //for each pair - cost of 'B'
                if (allB >= 2)
                {
                    var bCount = 0;
                    for (var i = 0; i < allB; i++)
                    {
                        bCount += 1;

                        if (bCount == 2)
                        {
                            totalCost -= products['B'];
                            bCount = 0;
                        }
                    }
                }


                return totalCost;
            }
            //Console.ReadLine();
        }
    }
}
