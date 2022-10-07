using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            string typeAnimal = "";
            switch (animal)
            {
                case "dog":
                    typeAnimal = "mammal";
                    break;
                case "snake":
                case "crocodile":
                case "tortoise":
                    typeAnimal = "reptile";
                    break;
                default:
                    typeAnimal = "unknown";
                    
                    break;
            }
            Console.WriteLine(typeAnimal);
        }
    }
}
