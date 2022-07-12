using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string call = Message.ShowMessage("english");
            string call2 = Message.ShowMessage("igbo");
            Console.WriteLine(call);
            Console.WriteLine(call2);

            Console.ReadLine();
        }
    }
}
