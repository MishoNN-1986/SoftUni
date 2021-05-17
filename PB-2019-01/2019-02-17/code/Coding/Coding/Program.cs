using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string numberAsString = "" + n;            // правим числото на string
            int rows = numberAsString.Length;          // броя на редовете е равен на колкото е цифрено числото ни (length връща колко са цифрите)

            for (int i = 0; i < rows; i++)
            {
                int number = int.Parse(numberAsString[numberAsString.Length - 1 - i] + ""); // от числото да ми вземе последното число( от последната позиция)
                                                                                            // слагаме -i, за да взима на всяко завъртане - i 
                                                                                            // трябва да превърнем стойността на number, която е в char, в string,  а след  това в int
                                                                                            // (слагаме int.parse пред скобите и "" на края)
                if (number == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }
                char symbolToRepeat = (char)(number + 33);  // слагаме (char),  за да видим кой символ стои на (number + 33)
                for (int j = 0; j < number; j++)  // с вътрешния for  цикъл ще отпечатим символа толкова пъти колкото е числото
                {
                    Console.Write(symbolToRepeat);
                }
                Console.WriteLine();
            }
        }
    }
}
