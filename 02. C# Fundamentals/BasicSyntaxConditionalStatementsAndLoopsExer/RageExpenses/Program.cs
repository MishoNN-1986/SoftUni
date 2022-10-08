using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double allPrice = 0;
            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;
            for (int i = 2; i <= lostGameCount; i += 2)
            {
                headsetCount++;
            }
            for (int j = 3; j <= lostGameCount; j += 3)
            {
                mouseCount++;
            }
            for (int k = 6; k <= lostGameCount; k += 6)
            {
                keyboardCount++;
            }
            for (int l = 12; l <= lostGameCount; l += 12)
            {
                displayCount++;
            }
            allPrice = headsetCount * headsetPrice + mouseCount * mousePrice + keyboardCount * keyboardPrice + displayCount * displayPrice;
            Console.WriteLine($"Rage expenses: {allPrice:F2} lv.");
        }
    }
}
