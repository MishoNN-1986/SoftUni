using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbers = int.Parse(Console.ReadLine());
            for (int i = 2; i <= numbers; i++)
            {
                string takovalie = "true";
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        takovalie = "false";
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {takovalie}");
                takovalie = "true";
            }
        }
    }
}
