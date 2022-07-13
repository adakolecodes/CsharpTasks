
namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Daughter daughter1 = new Daughter();
            daughter1.Height();

            Son son1 = new Son();
            son1.Height();
            son1.Weight();
        }
    }

    //Interfaces
    interface IFather
    {
        void Height();
    }

    interface IMother
    {
        void Weight();
    }

    //Classes
    class Daughter : IFather
    {
        public void Height()
        {
            Console.WriteLine("Daughter inherited height from father");
        }
    }

    class Son : IFather, IMother
    {
        public void Height()
        {
            Console.WriteLine("Son inherited height from father");
        }
        public void Weight()
        {
            Console.WriteLine("Son also inherited weight from mother");
        }
    }
}