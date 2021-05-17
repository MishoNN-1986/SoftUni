using System;

namespace FirstBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(num, 2);
            byte firstByte = byte.Parse(binary[binary.Length-2].ToString());
            Console.WriteLine(firstByte);
            var shiftedNumber = num >> 1;  // същото е като горе но с побитова операция !!!!!
            var result = shiftedNumber & 1;
            Console.WriteLine(result);
        }
    }
}
