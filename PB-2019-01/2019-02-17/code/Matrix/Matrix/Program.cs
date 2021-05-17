using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. първа и втора клетка да са от a  до b
            // 2.  трета и четвърта клетка да са от c  до d
            //3. първа + четвърта = втора + трета
            //4. първа ! втора
            // 5. трета ! четвърта
            // взимаме го като четирицифрено число 

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            for (int thousands = a; thousands <= b; thousands++)
            {
                for (int hundreds = a; hundreds <= b; hundreds++)
                {
                    for (int tens = c; tens <= d; tens++)
                    {
                        for (int units = c; units <= d; units++)
                        {
                            bool equalSum = thousands + units == hundreds + tens;   // връща true  за вярно и false  за грешно (може и с if-ве)
                            bool thNotEqualToHun = thousands != hundreds;
                            bool tensNotEqualToUnits = tens != units;
                            // ако трите условия са изпълнени ще изпринтираме числото
                            if (equalSum && thNotEqualToHun && tensNotEqualToUnits)
                            {
                                Console.WriteLine("" + thousands + hundreds);   // слагаме кавички, за да ги залепим( за да са string, иначе са int)
                                Console.WriteLine("" + tens + units);
                                Console.WriteLine();    // нов ред 
                            }
                        }
                    }
                }
            }
        }
    }
}
