using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Membership
    {
        const string _usernameError = "Username must be provided";
        const string _emailError = "Email must be provided";
        const string _passwordError = "Password must be provided";

        public static string Validate(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return _usernameError;
            if (string.IsNullOrWhiteSpace(email))
                return _emailError;
            if (string.IsNullOrWhiteSpace(password))
                return _passwordError;

            return string.Empty;
        }
    }
}
