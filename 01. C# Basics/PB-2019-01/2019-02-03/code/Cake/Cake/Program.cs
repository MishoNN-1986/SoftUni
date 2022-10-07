using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sizeOfTheCake = a * b;
            int countOfPiece = 0;        
            while (countOfPiece <= sizeOfTheCake)
            {
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    int leftPieces = sizeOfTheCake - countOfPiece;
                    Console.WriteLine($"{leftPieces} pieces are left.");
                    break;
                }
                else
                {
                    int numberPiece = int.Parse(command);
                    countOfPiece += numberPiece;
                }
            }
            if (countOfPiece>= sizeOfTheCake)
            {
                int needPieces = countOfPiece - sizeOfTheCake;
                Console.WriteLine($"No more cake left! You need {needPieces} pieces more.");
            }
            
        }
    }
}
