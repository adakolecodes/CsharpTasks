using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTestProject1
{
    class Experiments
    {
        [Test]
        public void LambdaTest()
        {
            // lamda expression

            var list = new List<int>() { 10, 20, 30, 40 };
            Func<int, int> sq = x => x * x;

            var nwList = new List<int>();
            foreach (var item in list)
            {
                var it = sq(item);
                nwList.Add(it);
            }

            list.ForEach(x => Console.WriteLine(x));
        }

        public int Square(int x)
        {
            return x * x;
        }
    }
}
