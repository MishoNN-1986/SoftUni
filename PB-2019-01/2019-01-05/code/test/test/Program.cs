using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string word = Console.ReadLine();
            Console.WriteLine(name.Contains(word));
        }
    }
}