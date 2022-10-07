using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringToLowerAndToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine(); //въвеждаме Misho
            string lower = text.ToLower();
            text = text.ToLower();  // текста става с малки букви
            Console.WriteLine(lower); // отпечатва misho
            Console.WriteLine(text.ToLower()); // може и направо в конзолата

            string text2 = Console.ReadLine(); // въвеждаме Misho
            string upper = text2.ToUpper();
            Console.WriteLine(upper); // отпечатва MISHO
            Console.WriteLine(text2.ToUpper()); // може и направо в конзолата

        }
    }
}
