using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Lock
    {
        private string _status;

        public string LockStatus 
        { 
            get
            {
                return _status;
            }
            set
            {
                if (value == "Open" || value == "Close")
                    _status = value;
            }
        } 
    }
}
