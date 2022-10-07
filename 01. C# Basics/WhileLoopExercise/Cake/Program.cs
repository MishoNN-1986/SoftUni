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
            int length = int.Parse(Console.ReadLine());
            int wigth = int.Parse(Console.ReadLine());
            int numberOfPieces = length * wigth;
            int counOfPices = 0;
            while (counOfPices < numberOfPieces)
            {
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    int piecesRemaining = numberOfPieces - counOfPices;
                    Console.WriteLine($"{piecesRemaining} pieces are left.");
                    break;
                }
                int pieces = int.Parse(command);
                counOfPices += pieces;
            }
            if (counOfPices >= numberOfPieces)
            {
                int neededPices = counOfPices - numberOfPieces;
                Console.WriteLine($"No more cake left! You need {neededPices} pieces more.");
            }
        }
    }
}
