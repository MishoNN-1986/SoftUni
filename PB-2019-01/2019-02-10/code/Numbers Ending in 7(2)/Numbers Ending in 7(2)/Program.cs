using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_Ending_in_7_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i <= 997; i += 10) //от 7 до 997, всички числа, които завършват на 7 
            {
                Console.WriteLine(i);
            }
        }
    }
}
