using _05._BirthdayCelebrations.Interfaces;
using _05._BirthdayCelebrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._BirthdayCelebrations
{
    public class Engine
    {
        private List<IBirthable> birthdates;

        public Engine()
        {
            this.birthdates = new List<IBirthable>();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArguments = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command.StartsWith("Citizen"))
                {
                    AddCitizen(commandArguments);
                }
                else if (command.StartsWith("Pet"))
                {
                    AddPet(commandArguments);
                }

                command = Console.ReadLine();
            }

            PrintOutput();
        }

        private void PrintOutput()
        {
            int year = int.Parse(Console.ReadLine());

            List<DateTime> yaers = this.birthdates.Where(x => x.Birthdate.Year == year).Select(x => x.Birthdate).ToList();

            if (yaers.Any())
            {
                foreach (var date in yaers)
                {
                    Console.WriteLine($"{date:dd/mm/yyyy}");
                }
            }
        }

        private void AddPet(string[] commandArguments)
        {
            string name = commandArguments[1];
            string birthdate = commandArguments[2];

            Pet pet = new Pet(name, birthdate);

            this.birthdates.Add(pet);
        }

        private void AddCitizen(string[] commandArguments)
        {
            string name = commandArguments[1];
            int age = int.Parse(commandArguments[2]);
            string id = commandArguments[3];
            string birthdate = commandArguments[4];

            Citizen citizen = new Citizen(name, age, id, birthdate);

            this.birthdates.Add(citizen);
        }
    }
}
