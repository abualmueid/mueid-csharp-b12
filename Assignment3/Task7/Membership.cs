using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Membership
    {
        public const string usernameErrorMsg = "Username must be provided";
        public const string emailErrorMsg = "Email must be provided";
        public const string passwordErrorMsg = "Password must be provided";
        public static string Validate(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return usernameErrorMsg;
            if (string.IsNullOrWhiteSpace(email))
                return emailErrorMsg;
            if (string.IsNullOrWhiteSpace(password))
                return passwordErrorMsg;

            return string.Empty;
        }
    }
}
