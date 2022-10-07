using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int numberOfAllAnimals = int.Parse(Console.ReadLine());
            double allMoneyForTheDogs = numberOfDogs * 2.50;
            int allMoneyForTheAnimals = numberOfAllAnimals * 4;
            double allMoneyForTheDogsAndTheAnimals = allMoneyForTheDogs + allMoneyForTheAnimals;
            Console.WriteLine($"{allMoneyForTheDogsAndTheAnimals:F2} lv.");
        }
    }
}
