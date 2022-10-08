using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine().
                Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> sortedDemons = new List<string>();
            foreach (var demon in demons)
            {
                sortedDemons.Add(demon);
            }
            sortedDemons.Sort();
            string patternHealth = @"([^\d\+\-\*\/\.])";
            string patternDamage = @"(\-?\d+\.?\d*)";
            string patternMultiply = @"(\*)";
            string patternDivide = @"(\/)";
            Regex healthRegex = new Regex(patternHealth);
            Regex damageRegex = new Regex(patternDamage);
            Regex multiplyRegex = new Regex(patternMultiply);
            Regex divideRegex = new Regex(patternDivide);
            for (int i = 0; i < sortedDemons.Count; i++)
            {
                string demon = sortedDemons[i];
                MatchCollection matchHealth = Regex.Matches(demon, patternHealth);
                MatchCollection matchDamage = Regex.Matches(demon, patternDamage);
                MatchCollection matchMultiply = Regex.Matches(demon, patternMultiply);
                MatchCollection matchDivide = Regex.Matches(demon, patternDivide);
                int health = 0;
                double damage = 0;
                foreach (Match letter in matchHealth)
                {
                    health += char.Parse(letter.Value);
                }
                foreach (Match num in matchDamage)
                {
                    damage += double.Parse(num.Value);
                }
                int multiplyCount = matchMultiply.Count;
                int divideCount = matchDivide.Count;
                damage *= Math.Pow(2, multiplyCount);
                damage /= Math.Pow(2, divideCount);
                Console.WriteLine($"{demon} - {health} health, {damage:F2} damage");
            }
        }
    }
}
