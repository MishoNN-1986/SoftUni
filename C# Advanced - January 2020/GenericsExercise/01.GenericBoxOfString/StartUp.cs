using System;

namespace _01.GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int quantityStrings = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantityStrings; i++)
            {
                string inputString = Console.ReadLine();
                Box<string> box = new Box<string>(inputString);
                Console.WriteLine(box);
            }
        }
    }
}
