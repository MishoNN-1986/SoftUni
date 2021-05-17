using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); //aquarium lenght
            int b = int.Parse(Console.ReadLine()); // aquarium wight
            int height = int.Parse(Console.ReadLine()); // aquarium height
            double percent = double.Parse(Console.ReadLine()); 

            int volume = a * b * height;
            double aquariumLiters = volume * 0.001;
            double waterLiters = aquariumLiters * (1 - (percent * 0.01));
            Console.WriteLine("{0:F3}", waterLiters);



        }
    }
}
