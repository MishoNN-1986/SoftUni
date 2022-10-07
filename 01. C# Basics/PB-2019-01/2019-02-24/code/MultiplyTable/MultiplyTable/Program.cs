using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int firstResidue = num % 10;
            int secondResidue = ((num % 100) - firstResidue) / 10;
            int thirdResidue = ((num % 1000) - (firstResidue + secondResidue * 10)) / 100;

            for (int first = 1; first <= firstResidue; first++)
            {
                for (int second = 1; second <= secondResidue; second++)
                {
                    for (int third = 1; third <= thirdResidue; third++)
                    {
                        int result = first * second * third;
                        Console.WriteLine($"{first} * {second} * {third} = {result};");
                    }
                }
            }
        }
    }
}
