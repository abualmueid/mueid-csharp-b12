using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Member
    {
        private string membershipId;
        internal string Name { get; set; }
        internal DateTime MembershipExpirationDate { get; set; }

        internal Member()
        {
            membershipId = Guid.NewGuid().ToString();
        }
    }
}
