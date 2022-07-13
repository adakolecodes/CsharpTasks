
namespace Interfaces2
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
        }
    }

    //Interfaces
    interface IFather
    {
        class
    }

    interface IMother
    {
        void FuelPowered();
    }

    //Classes
    class Daughter : IFather
    {
        
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
}