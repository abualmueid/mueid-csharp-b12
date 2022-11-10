using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class11
{
    internal interface IUSBDevice
    {
        // bool Connect();

        // Default Implementation
        bool Connect()
        {
            return true;
        }
        string GetData();
    }
}
