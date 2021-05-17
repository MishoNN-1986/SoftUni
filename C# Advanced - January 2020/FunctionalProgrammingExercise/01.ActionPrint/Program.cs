using System;
using System.Linq;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = new Action<string>((name) =>
            {
                Console.WriteLine(name);
            });

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(print); //може вместо print, (n => Console.WriteLine(n));, и да се махне action
        }
    }
}
