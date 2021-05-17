using System;
using System.Text;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(StringExplosion(input));
        }

        static string StringExplosion(string input)
        {
            StringBuilder output = new StringBuilder();
            int strengthOfExplosion = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                if (strengthOfExplosion > 0 && symbol != '>')
                {
                    strengthOfExplosion--;
                    continue;
                }
                if (symbol == '>')
                {
                    strengthOfExplosion += int.Parse(input[i + 1].ToString());
                }
                output.Append(symbol);
            }
            return output.ToString();
        }
    }
}
