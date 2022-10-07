using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double allVolume = length * width * height;
            double allLitersWater = (allVolume * (1 - percent/100))/1000; // Делим на 1000, за да превърнем обема от кубични см. в куб. дм.(10*10*10=1000!)
            Console.WriteLine($"{allLitersWater:F3}");
        }
    }
}
