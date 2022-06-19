using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsAndProperties
{
    internal class Car
    {
        private int speed;

        public Car(int aSpeed)
        {
            SpeedProperty = aSpeed;
        }

        public int SpeedProperty
        {
            get { return speed; } //Read
            set {                 //Writable
                if(value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}
