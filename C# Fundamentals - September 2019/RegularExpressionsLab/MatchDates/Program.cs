using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?<day>\d{2})(\.|\-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b"; //сменяме 2 на 1 "\1"(?<year>\d{4})\b", защото в c# не се броят низовите групи
            var datesString = Console.ReadLine();
            var dates = Regex.Matches(datesString, regex);
            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
