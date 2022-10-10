using _03._Telephony.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Telephony
{
    public class Smartphone : IBrowseable, ICallable
    {
        public string Call(string number)
        {
            if (!number.All(char.IsDigit))
            {
                return "Invalid number!";
            }

            return $"Calling... {number}";
        }

        public string Browse(string site)
        {
            if (site.Any(char.IsDigit))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {site}!";
        }
    }
}
