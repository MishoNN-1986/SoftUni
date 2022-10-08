using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string output = GetRepeatString(input, count);
            Console.WriteLine(output);
        }
        static string GetRepeatString(string input, int count)
        {
            string output = string.Empty;
            for (int i = 0; i < count; i++)
            {
                output += input;
            }
            return output;
        }
    }
}
