using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota");
            Car car2 = new Car("Honda");
            Car car3 = new Car("Nissan");

            Console.WriteLine(Car.numberOfCars);
            Car.startRace();

            /**
            Here we no longer access the numberOfCars field in a non-static way (ie. car1.numberOfCars) but in a static way
            by using the name of the class followed by the name of the field (ie. Car.numberOfCars).
            numberOfCars field now belong to the Car class and no one object has complete ownership of it - it's just
            like all the objects are all sharing the same variable. 
            The value of numberOfCars would increment to the tune of the number of Car objects we create - if we have 3
            car object, our numberOfCar value would be 3
            **/


            Console.ReadKey();
        }
    }
}
