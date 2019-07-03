using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    class Validation
    {
        public string ValidatePass(string password, string password2, string email)
        {
            if (password.Length == 0)
            {
                return "Password feild empty please fill in Password box";
                
            }
            else if (password2.Length == 0)
            {
                return "Confirm Password feild empty please fill in Password box";
            }
            else if (password != password2)
            {
                return "Passwords entered dont match";
            }
            else if (email.Length == 0)
            {
                return "Email box empty, Please enter your email address";

            }
            else if (!Regex.IsMatch(email, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                return "Email address not valid please enter a valid email address";


            }
           
            else
            {
                return "Thankyou registration successful";
            }
        }
    }
}
