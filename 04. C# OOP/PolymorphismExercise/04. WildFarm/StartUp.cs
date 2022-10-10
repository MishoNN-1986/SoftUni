using _04._WildFarm.Animals;
using _04._WildFarm.Factories;
using _04._WildFarm.Food;
using System;
using System.Collections.Generic;

namespace WildFarm
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                Animal animal = AnimalFactory.Create(command.Split(' ', StringSplitOptions.RemoveEmptyEntries));
                animals.Add(animal);
                Console.WriteLine(animal.ProduceSound());
                Food food = FoodFactory.Create(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));

                try
                {
                    animal.EatFood(food);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            animals.ForEach(Console.WriteLine);
        }
    }
}
