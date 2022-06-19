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
            Car car1 = new Car();

            //Our speed and wheels are private fields therefore we cannot access them
            //Hence, we can only access them via the property defined for them
            car1.SpeedProperty = 6000;
            Console.WriteLine(car1.SpeedProperty);

            //Here we try to set number of our car wheels to 8, but 4 gets returned because
            //of the condition we set in our WheelsProperty - advantage of a property
            car1.WheelsProperty = 8;
            Console.WriteLine(car1.WheelsProperty);

            Console.ReadKey();
        }
    }
}
