using System;

namespace p_thBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(num, 2);
            if (position > binary.Length)
            {
                Console.WriteLine(0);
            }
            else
            {
                byte positionByte = byte.Parse(binary[binary.Length - 1 - position].ToString());
                Console.WriteLine(positionByte);
            }
            var mask = 1 << position;  // същото като горе, но с побитови операции
            var result = num & mask;
            Console.WriteLine(result >> position);
        }
    }
}
