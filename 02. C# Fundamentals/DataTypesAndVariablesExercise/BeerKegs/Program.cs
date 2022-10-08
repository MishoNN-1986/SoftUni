using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityKegs = int.Parse(Console.ReadLine());
            float maxVolume = 0;
            float volume = 0;
            string theBiggestKeg = "";
            for (int i = 0; i < quantityKegs; i++)
            {
                string modelKeg = Console.ReadLine();
                float radiusOfKeg = float.Parse(Console.ReadLine());
                int heightOfKeg = int.Parse(Console.ReadLine());
                volume = (float)Math.PI * radiusOfKeg * radiusOfKeg * heightOfKeg;
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    theBiggestKeg = modelKeg;
                }
            }
            Console.WriteLine(theBiggestKeg);
        }
    }
}
