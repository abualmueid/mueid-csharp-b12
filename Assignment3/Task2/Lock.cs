using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Lock
    {
        


        //public string LockStatus { get; set; } // Correct lock status are: Open & Close

        public string LockStatus
        {
            get 
            { 
                return LockStatus; 
            }

            set 
            {
                if(value == "Open" || value == "Close")
                    LockStatus = value; 
            }
        }
    }
}
