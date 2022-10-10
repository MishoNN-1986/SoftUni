using System;
using System.Linq;

namespace _04._PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInput = InputSplit();

                string[] doughInput = InputSplit();

                string pizzaName = pizzaInput[1];
                string doughFlourType = doughInput[1];
                string doughBakingTechnique = doughInput[2];
                decimal flourWeight = decimal.Parse(doughInput[3]);

                Dough dough = new Dough(doughFlourType, doughBakingTechnique, flourWeight);
                Pizza pizza = new Pizza(pizzaName,dough);

                string command = Console.ReadLine();
                while (command != "END")
                {
                    string[] toppingInput = command
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string toppingType = toppingInput[1];
                    decimal toppingGrams = decimal.Parse(toppingInput[2]);

                    Topping topping = new Topping(toppingType, toppingGrams);

                    pizza.AddTopping(topping);

                    command = Console.ReadLine();
                }
                Console.WriteLine(pizza);
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        private static string[] InputSplit()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
        }
    }
}
