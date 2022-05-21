using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericComputting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var genericClass2 = new DanielAndTochiGenric<int>(1,2);
            int res2 = genericClass2.GetInput();

            Console.WriteLine(res2);

            Console.ReadLine();
        }

        public class DanielAndTochiGenric<TInput>
        {
            private TInput _input;
            private TInput _input2;

            public DanielAndTochiGenric(TInput input, TInput input2)
            {
                _input = input;
                _input = input2;
            }

            public TInput GetInput()
            {
                return _input + _input2;
            }
        }
    }
}
