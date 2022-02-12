using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp1
{
    internal class Vehicles
    {
        public string vehiclename;
        public int numoftyers;

        //Function inside a class
        public void GetDetails()
        {
            Console.WriteLine("Vehicle name: " + vehiclename);
            Console.WriteLine("Num of tyres: " + numoftyers);
        }

        //Constructor
        public Vehicles()
        {
            numoftyers = 4;
        }
    }
}
