using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();
            while (true)
            {
                string newPassword = Console.ReadLine();
                if (newPassword == password)
                {
                    break;
                }
            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
