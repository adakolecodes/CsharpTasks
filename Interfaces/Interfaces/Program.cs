
namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            HondaAccord2015 honda1 = new HondaAccord2015();
            honda1.FuelPowered();

            ToyotaCamryMuscle toyota1 = new ToyotaCamryMuscle();
            toyota1.ElectricPowered();
            toyota1.FuelPowered();

            EstherCar car1 = new EstherCar();
            car1.ElectricPowered();
            car1.FuelPowered();
            car1.WaterPowered();
        }
    }

    //Interfaces
    interface IElectric
    {
        void ElectricPowered();
    }

    interface IGas
    {
        void FuelPowered();
    }

    interface IWater
    {
        void WaterPowered();
    }

    //Classes
    class HondaAccord2015 : IGas
    {
        public void FuelPowered()
        {
            Console.WriteLine("This car is powered by Fuel");
        }
    }

    class ToyotaCamryMuscle : IElectric, IGas
    {
        public void ElectricPowered()
        {
            Console.WriteLine("This car is powered by Electricity");
        }
        public void FuelPowered()
        {
            Console.WriteLine("This car is powered by Fuel");
        }
    }

    class EstherCar : IElectric, IGas, IWater
    {
        public void ElectricPowered()
        {
            Console.WriteLine("This car is powered by Electricity");
        }
        public void FuelPowered()
        {
            Console.WriteLine("This car is powered by Fuel");
        }

        public void WaterPowered()
        {
            Console.WriteLine("This car is powered by Fuel");
        }
    }
}