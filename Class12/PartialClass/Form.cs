using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal partial class Form
    {
        private string _name;
        private string _email;
        private string _password;
        private string _address;
        private string _phone;

        public Form()
        {
            _name = "Mueid";
            _email = "abualmueid24@gmail.com";
            _password = "123abcd";
            _address = "Narayanganj";
            _phone = "01631221109";
        }

        public void Reset()
        {
            _name = string.Empty; 
            _email = string.Empty; 
            _password = string.Empty;
            _address= string.Empty;
            _phone = string.Empty;
        }
    }
}
