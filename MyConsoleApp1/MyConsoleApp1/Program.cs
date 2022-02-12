using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicles car = new Vehicles();
            car.vehiclename = "BMW 3 Series";
            car.numoftyers = 4;

            Vehicles bike = new Vehicles();
            bike.vehiclename = "Jinchen";
            bike.numoftyers = 2;
            car.GetDetails();
            bike.GetDetails();

            Console.ReadKey();
        }
    }
}
