using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([a-zA-Z0-9]+)(@)([a-zA-Z]+([\.\-][a-zA-Z]+)+))(\b|(?=\s))";
            Regex regex = new Regex(pattern);
            MatchCollection emails = Regex.Matches(text, pattern);
            foreach (Match email in emails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
