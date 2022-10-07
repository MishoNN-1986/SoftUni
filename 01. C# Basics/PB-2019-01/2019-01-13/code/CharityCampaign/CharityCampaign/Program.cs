using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gofreti = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            double sumCakes = cakes * 45.0; // sumata izkarana ot 1 sladkar za 1 den
            double sumGofreti = gofreti * 5.80; //--//--
            double sumPancakes = pancakes * 3.2; //--//--
            double allSum = (sumCakes + sumGofreti + sumPancakes) * days * confectioners;
            double finallySum = allSum * 7 / 8;
            Console.WriteLine($"{finallySum:F2}");
        }
    }
}
