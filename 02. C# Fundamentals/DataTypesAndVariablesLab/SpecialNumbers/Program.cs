using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityNumber = int.Parse(Console.ReadLine());
            bool specialNumber = false;
            double sum = 0;
            for (int i = 1; i <= quantityNumber; i++)
            {
                string iToString = i.ToString();
                for (int j = 0; j < iToString.Length; j++)
                {
                    sum += int.Parse(iToString[j].ToString());
                }
                if(sum == 5 || sum == 7 || sum == 11)
                {
                    specialNumber = true;
                }
                Console.WriteLine($"{i} -> {specialNumber}");
                sum = 0;
                specialNumber = false;
            }
        }
    }
}
