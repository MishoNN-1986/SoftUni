using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            int countAttackedPlanets = 0;
            int countDestroyedPlanets = 0;
            for (int i = 0; i < num; i++)
            {
                string newCommand = string.Empty;
                string input = Console.ReadLine();
                string patternLetters = @"[starSTAR]";
                MatchCollection matchLetters = Regex.Matches(input, patternLetters);
                int count = matchLetters.Count;
                for (int j = 0; j < input.Length; j++)
                {
                    char newSymbol = (char)(input[j] - count);
                    newCommand = newCommand + newSymbol.ToString();
                }
                string pattern = @"[^\@\-\!\:\>]*@([A-Za-z]+)[^\@\-\!\:\>]*:(\d+)[^\@\-\!\:\>]*!(A|D)![^\@\-\!\:\>]*->(\d+)[^\@\-\!\:\>]*";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(newCommand);
                if (match.Success)
                {
                    char attackOrDestruction = char.Parse(match.Groups[3].Value);
                    string name = match.Groups[1].Value;
                    if (attackOrDestruction == 'D')
                    {
                        destroyedPlanets.Add(name);
                        countDestroyedPlanets++;
                    }
                    else
                    {
                        attackedPlanets.Add(name);
                        countAttackedPlanets++;
                    }
                }
            }
            StringBuilder output = new StringBuilder();
            output.Append($"Attacked planets: {countAttackedPlanets} {Environment.NewLine}");
            if (attackedPlanets.Count > 0)
            {
                attackedPlanets.Sort();
                foreach (var planet in attackedPlanets)
                {
                    output.Append($"-> {planet} {Environment.NewLine}");
                }
            }
            output.Append($"Destroyed planets: {countDestroyedPlanets} {Environment.NewLine}");
            if (destroyedPlanets.Count > 0)
            {
                destroyedPlanets.Sort();
                foreach (var planet in destroyedPlanets)
                {
                    output.Append($"-> {planet} {Environment.NewLine}");
                }
            }
            Console.WriteLine(output.ToString().TrimEnd());
        }
    }
}
