using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPeople = int.Parse(Console.ReadLine());
            string typePeople = Console.ReadLine();
            string day = Console.ReadLine();
            double priceForSinglePerson = 0;
            double allPrice = 0;
            switch (typePeople)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            priceForSinglePerson = 8.45;
                            break;
                        case "Saturday":
                            priceForSinglePerson = 9.8;
                            break;
                        case "Sunday":
                            priceForSinglePerson = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            priceForSinglePerson = 10.9;
                            break;
                        case "Saturday":
                            priceForSinglePerson = 15.6;
                            break;
                        case "Sunday":
                            priceForSinglePerson = 16.0;
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            priceForSinglePerson = 15.0;
                            break;
                        case "Saturday":
                            priceForSinglePerson = 20.0;
                            break;
                        case "Sunday":
                            priceForSinglePerson = 22.5;
                            break;
                    }
                    break;
            }
            if (sumPeople >= 30 && typePeople == "Students")
            {
                priceForSinglePerson *= 0.85;
            }
            else if (sumPeople >= 100 && typePeople == "Business")
            {
                sumPeople -= 10;
            }
            else if (sumPeople >= 10 && sumPeople <= 20 && typePeople == "Regular")
            {
                priceForSinglePerson *= 0.95;
            }
            allPrice = sumPeople * priceForSinglePerson;
            Console.WriteLine($"Total price: {allPrice:F2}");
        }
    }
}
