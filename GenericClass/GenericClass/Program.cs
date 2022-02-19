using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class DanielGeneric<DKey, DValue>
    {
        public DKey keyinput;

        public void MyAddMethod(DKey dkey, DValue dvalue)
        {
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var genericclass = new DanielGeneric<int, string>();
            genericclass.MyAddMethod(1, "January");
            genericclass.MyAddMethod(2, "February");
            genericclass.MyAddMethod(3, "March");
            genericclass.MyAddMethod(4, "April");
        }
    }
}
