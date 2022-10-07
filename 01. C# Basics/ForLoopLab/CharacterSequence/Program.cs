using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int sum = text.Length;
            for (int i = 0; i < sum; i++)  // може и i < text.Length
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
