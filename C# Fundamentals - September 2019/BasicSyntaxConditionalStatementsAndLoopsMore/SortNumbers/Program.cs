using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int maxNum = 0;
            int minNum = 0;
            int secondNum = 0;
            if (num1 >= num2 && num1 >= num3)
            {
                maxNum = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                maxNum = num2;
            }
            else
            {
                maxNum = num3;
            }
            if (num1 <= num2 && num1 <= num3)
            {
                minNum = num1;
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                minNum = num2;
            }
            else
            {
                minNum = num3;
            }
            if (num1 > minNum && num1 < maxNum)   // secondNum = (num1 + num2 + num3 -(maxNum + minNum)); 
            {
                secondNum = num1;
            }
            else if (num2 > minNum && num2 < maxNum)
            {
                secondNum = num2;
            }
            else if (num1 == num2 && num3 > num1)
            {
                secondNum = num1;
            }
            else
            {
                secondNum = num3;
            }
            Console.WriteLine(maxNum);
            Console.WriteLine(secondNum);
            Console.WriteLine(minNum);
            //for (int i = 0; i < 3; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    if (num > maxNum)
            //    {
            //        secondNum = maxNum;
            //        maxNum = num;
            //    }
            //    if (num < minNum)
            //    {
            //        secondNum = minNum;
            //        minNum = num;
            //    }
            //    //else if (num < maxNum && num > minNum)
            //    //{
            //    //    secondNum = num;
            //    //}
            //}
            //Console.WriteLine(maxNum);
            //Console.WriteLine(secondNum);
            //Console.WriteLine(minNum);
        }
    }
}
