using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{

    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split().ToList();
            Random rnd = new Random();
            int randomNumber = 0;
            for (int i = 0; i < text.Count; i++)
            {
                randomNumber = rnd.Next(0, text.Count - 1);
                Console.WriteLine(text[randomNumber]);
                text.RemoveAt(randomNumber);
                i--;
            }
        }
    }
}
