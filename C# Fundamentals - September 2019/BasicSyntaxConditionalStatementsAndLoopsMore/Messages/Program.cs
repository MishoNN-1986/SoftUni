using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            string message = "";
            for (int i = 0; i < quantity; i++)
            {
                string num = Console.ReadLine();
                //for (int j = 97; j < num.Length; j+=3)
                //{
                if (int.Parse(num[0].ToString()) == 2)
                {
                    message += $"{(char)(97 + num.Length - 1)}";
                    //Console.Write($"{(char)(97 + num.Length - 1)}");
                }
                else if (int.Parse(num[0].ToString()) == 3)
                {
                    message += $"{(char)(100 + num.Length - 1)}";
                    //Console.Write($"{(char)(100 + num.Length - 1)}");
                }
                else if (int.Parse(num[0].ToString()) == 4)
                {
                    message += $"{(char)(103 + num.Length - 1)}";
                    //Console.Write($"{(char)(103 + num.Length - 1)}");
                }
                else if (int.Parse(num[0].ToString()) == 5)
                {
                    message += $"{(char)(106 + num.Length - 1)}";
                    //Console.Write($"{(char)(106 + num.Length - 1)}");
                }
                else if (int.Parse(num[0].ToString()) == 6)
                {
                    message += $"{(char)(109 + num.Length - 1)}";
                    //Console.Write($"{(char)(109 + num.Length - 1)}");
                }
                else if (int.Parse(num[0].ToString()) == 7)
                {
                    message += $"{(char)(112 + num.Length - 1)}";
                    //Console.Write($"{(char)(112 + num.Length - 1)}");
                }
                else if (int.Parse(num[0].ToString()) == 8)
                {
                    message += $"{(char)(116 + num.Length - 1)}";
                    //Console.Write($"{(char)(116 + num.Length - 1)}");
                }
                else if (int.Parse(num[0].ToString()) == 9)
                {
                    message += $"{(char)(119 + num.Length - 1)}";
                    //Console.Write($"{(char)(119 + num.Length - 1)}");
                }
                else if (int.Parse(num[0].ToString()) == 0)
                {
                    message += $"{(char)(32)}";
                    //Console.Write($"{(char)(32)}");
                }
                //}
            }
            Console.WriteLine(message);
        }
    }
}
