using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                bool intTryParseIsSuccess = int.TryParse(input, out int intValue);
                bool doubleTryParseIsSuccess = double.TryParse(input, out double doubleValue);
                bool charTryParseIsSuccess = char.TryParse(input, out char charValue);
                bool boolTryParseIsSuccess = bool.TryParse(input, out bool boolValue);
                if (intTryParseIsSuccess)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (doubleTryParseIsSuccess)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (charTryParseIsSuccess)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (boolTryParseIsSuccess)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}
