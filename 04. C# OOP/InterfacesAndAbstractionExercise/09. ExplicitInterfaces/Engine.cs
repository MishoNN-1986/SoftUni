using _09._ExplicitInterfaces.Interfaces;
using _09._ExplicitInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._ExplicitInterfaces
{
    public class Engine
    {
        public Engine()
        {

        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "End")
            {

                string[] commandArguments = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                this.PrintOutput(commandArguments);

                command = Console.ReadLine();
            }
        }

        private void PrintOutput(string[] commandArguments)
        {
            string name = commandArguments[0];
            string country = commandArguments[1];
            int age = int.Parse(commandArguments[2]);

            Citizen citizen = new Citizen(name, age, country);

            Type type = citizen.GetType();

            IResident iResidentCitizen = (IResident)Convert.ChangeType(citizen, type);

            Console.WriteLine(citizen.GetName());
            Console.WriteLine(iResidentCitizen.GetName());
        }
    }
}
