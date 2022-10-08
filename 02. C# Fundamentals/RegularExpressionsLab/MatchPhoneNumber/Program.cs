using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+[359]{3}(\s|\-)2\1[0-9]{3}\1[0-9]{4}\b"; // (\s|\-)- низова група, след това я ползваме с /1(групите без име) , ако е с [] можем да сложим поредица вътре
            string phones = Console.ReadLine();
            MatchCollection phoneMatches = Regex.Matches(phones, regex);
            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
