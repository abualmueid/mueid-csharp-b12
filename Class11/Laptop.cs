using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class11
{
    internal class Laptop
    {
        IUSBDevice uSBPort1;
        IUSBDevice uSBPort2;

        public void AddUsbDeviceInPort1(IUSBDevice usbDevice)
        {
            uSBPort1 = usbDevice;
        }

        public void AddUsbDeviceInPort2(IUSBDevice uSBDevice)
        {
            uSBPort2 = uSBDevice;
        }

        public string TransferDataFromPort1()
        {
            uSBPort1.Connect();
            var bytes = uSBPort1.GetData();
            return bytes;
        }

        public string TransferDataFromPort2()
        {
            uSBPort2.Connect();
            var bytes = uSBPort2.GetData();
            return bytes;
        }


    }
}
