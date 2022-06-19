using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsAndProperties
{
    internal class Car
    {
        //FIELDS
        private int speed;
        private int wheels;


        //PROPERTIES
        //speed property
        public int SpeedProperty
        {
            get { return speed; } //Read
            set { speed = value; }//Writable
        }


        //wheels property with a condition
        public int WheelsProperty
        {
            get { return wheels; }
            set
            {
                if (value > 4)
                {
                    wheels = 4;
                }
                else
                {
                    wheels = value;
                }
            }
        }


        //AutoProperty
        public string carType { get; set; }
    }
}
