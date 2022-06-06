using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first number");
                string num1 = Console.ReadLine();
                Console.WriteLine("Enter second number");
                string num2 = Console.ReadLine();
                Console.WriteLine((decimal)int.Parse(num1) / int.Parse(num2));
            }
            catch(FormatException err)
            {
                Console.WriteLine("Enter only numbers please");
            }
            catch(DivideByZeroException err)
            {
                Console.WriteLine("You can't divide by zero");
            }
            catch(Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {
                Console.WriteLine("Thank you!!");
            }



            //The parameter "FormatException" handles errors relating to formatting (text formatting)
            //The parameter "DivideByZeroException" handles errors when someone divides by zero
            //You can add a catch block that catches anything by using the parameter of "Exception"
            //The finally block is optional, it always execute regardless if an exception is caught or not
            //You can have more than one catch block



            Console.ReadKey();
        }
    }
}
