using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Student : User
    {
        public Student(string firstName, string lastName, string email)
            : base(firstName, lastName, email)
        {
        }

        public override void GenerateId()
        {
            Id = "ST-" + DateTime.Now.Ticks.ToString();
        }
    }
}
