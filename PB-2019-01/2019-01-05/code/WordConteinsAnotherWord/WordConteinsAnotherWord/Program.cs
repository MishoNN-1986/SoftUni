using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordConteinsAnotherWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string anotherword = Console.ReadLine();
            Console.WriteLine(word.Contains(anotherword));
        }
    }
}
