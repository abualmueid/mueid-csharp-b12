using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class11
{
    internal class Pendrive : IUSBDevice
    {
        /*
        public bool Connect()
        {
            return true;
        }
        */
        public string GetData()
        {
            return "Pendrive Connected!";
        }
    }
}
