using System;

namespace BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            byte binaryDigit = byte.Parse(Console.ReadLine());
            string binary = Convert.ToString(num, 16);
            Console.WriteLine(binary);
            int count = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (byte.Parse(binary[i].ToString()) == binaryDigit)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
