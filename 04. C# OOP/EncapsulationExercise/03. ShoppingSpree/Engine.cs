using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._ShoppingSpree
{
    public class Engine
    {
        private List<Person> people;
        private List<Product> products;

        public Engine()
        {
            this.people = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {
            AddPeople();
            AddProducts();

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commandArguments = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string personName = commandArguments[0];
                string productName = commandArguments[1];

                try
                {
                    Person currentPerson = this.people.FirstOrDefault(p => p.Name == personName);
                    Product currentProduct = this.products.FirstOrDefault(p => p.Name == productName);

                    currentPerson.BuyProduct(currentProduct);

                    Console.WriteLine($"{currentPerson.Name} bought {currentProduct}");
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }

                command = Console.ReadLine();
            }

            PrintOutput();
        }

        private void PrintOutput()
        {
            foreach (var person in this.people)
            {
                Console.WriteLine(person);
            }
        }

        private void AddProducts()
        {
            string[] inputProducts = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < inputProducts.Length; i++)
            {
                string[] productsArguments = inputProducts[i]
                    .Split("=", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = productsArguments[0];
                decimal cost = decimal.Parse(productsArguments[1]);

                Product product = new Product(name, cost);
                products.Add(product);
            }
        }

        private void AddPeople()
        {
            string[] inputPeople = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < inputPeople.Length; i++)
            {
                string[] peopleArguments = inputPeople[i]
                    .Split("=", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = peopleArguments[0];
                decimal money = decimal.Parse(peopleArguments[1]);

                Person person = new Person(name, money);
                this.people.Add(person);
            }
        }
    }
}
