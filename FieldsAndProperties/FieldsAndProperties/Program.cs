using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsAndProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(200);
            car.SpeedProperty = 6000;

            Console.WriteLine(car.SpeedProperty);

            Console.ReadKey();
        }
    }
}
