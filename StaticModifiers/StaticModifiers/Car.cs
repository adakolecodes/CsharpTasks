using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticModifiers
{
    internal class Car
    {
        string _model;
        public static int numberOfCars;

        public Car(string model)
        {
            _model = model;

            //To increment number of cars by 1 each time a car is instantiated
            numberOfCars ++;
        }

        public static void startRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}
