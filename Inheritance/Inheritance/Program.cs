// See https://aka.ms/new-console-template for more information
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine(car.maxspeed);
            Console.WriteLine(car.wheels);

            Console.WriteLine(bicycle.maxspeed);
            Console.WriteLine(bicycle.wheels);

            Console.WriteLine(boat.maxspeed);
            Console.WriteLine(boat.wheels);

            //Error: Inability to create an object from the Vehicle class because it uses an abstract modifier
            //Vehicle vehicle = new Vehicle();
        }
    }

    //Parent class
    //The abstract modifier here prevents someone from creating an object from the Vehicle class hence it is incomplete
    abstract class Vehicle
    {
        public int maxspeed = 400;
        public bool movement = true;
    }

    //Children classes inheriting from the parent class
    class Car : Vehicle
    {
        public int wheels = 4;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}