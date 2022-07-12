using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class Message
    {
        public static string ShowMessage(string lang)
        {
            if(lang == "english")
            {
                return "Come";
            }
            else if (lang == "yoruba")
            {
                return "Wa";
            }
            else if (lang == "hausa")
            {
                return "Zo";
            }
            else if (lang == "igbo")
            {
                return "Bia";
            }
            else
            {
                return "";
            }
        }
    }
}
