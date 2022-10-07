using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityNylon = int.Parse(Console.ReadLine());
            int litersPaint = int.Parse(Console.ReadLine());
            int quantityDiluent = int.Parse(Console.ReadLine());
            int hoursWork = int.Parse(Console.ReadLine());
            double allSum = ((quantityNylon + 2.0) * 1.5) + (litersPaint * 1.1 * 14.5) + (quantityDiluent * 5.0) + 0.4;
            allSum += (allSum * 0.3 * hoursWork * 1.0);
            Console.WriteLine($"Total expenses: {allSum:F2} lv.");
        }
    }
}
