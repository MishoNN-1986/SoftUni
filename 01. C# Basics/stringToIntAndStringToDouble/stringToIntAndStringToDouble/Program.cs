using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringToIntAndStringToDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string input = Console.ReadLine();  // Въвеждаме число
            int num = int.Parse(input);
            Console.WriteLine(num);

            string k = "123";
            int m = int.Parse(k);
            Console.WriteLine(m);  // Отпечатва числото (123)
               

            string a = Console.ReadLine();  // Въвеждаме число
            double b = double.Parse(a);
            Console.WriteLine(b);

            string g = Console.ReadLine();
            int sum = 0;
            sum += int.Parse(g);  // събира сумата с числото

            int n = int.Parse(Console.ReadLine());
            string numberAsString = "" + n; // правим числото на стринг
            
        }
    }
}
