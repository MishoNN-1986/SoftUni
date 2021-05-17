using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double totalPrice = 0.0;
            double leftMoney = 0.0;
            double needMoney = 0.0;
            if (typeFlowers == "Roses")
            {
                totalPrice = numberOfFlowers * 5;


                if (numberOfFlowers > 80)
                {
                    totalPrice *= 0.9;




                    if (budget >= totalPrice)
                    {
                        leftMoney = budget * 1.0 - totalPrice;


                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlowers} and {leftMoney:F2} leva left.");
                    }
                    else
                    {
                        needMoney = totalPrice * 1.0 - budget;

                        Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
                    }

                }

                else
                {
                    if (budget >= totalPrice)
                    {
                        leftMoney = budget * 1.0 - totalPrice;


                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlowers} and {leftMoney:F2} leva left.");
                    }
                    else
                    {
                        needMoney = totalPrice * 1.0 - budget;

                        Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
                    }

                }

            }
            else if (typeFlowers == "Dahlias")
            {
                totalPrice = numberOfFlowers * 3.8;


                if (numberOfFlowers > 90)
                {
                    totalPrice *= 0.85;




                    if (budget >= totalPrice)
                    {
                        leftMoney = budget * 1.0 - totalPrice;


                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlowers} and {leftMoney:F2} leva left.");
                    }
                    else
                    {
                        needMoney = totalPrice * 1.0 - budget;

                        Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
                    }

                }

                else
                {
                    if (budget >= totalPrice)
                    {
                        leftMoney = budget * 1.0 - totalPrice;


                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlowers} and {leftMoney:F2} leva left.");
                    }
                    else
                    {
                        needMoney = totalPrice * 1.0 - budget;

                        Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
                    }

                }
            }
            else if (typeFlowers == "Tulips")
            {
                totalPrice = numberOfFlowers * 2.8;


                if (numberOfFlowers > 80)
                {
                    totalPrice *= 0.85;




                    if (budget >= totalPrice)
                    {
                        leftMoney = budget * 1.0 - totalPrice;


                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlowers} and {leftMoney:F2} leva left.");
                    }
                    else
                    {
                        needMoney = totalPrice * 1.0 - budget;

                        Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
                    }

                }

                else
                {
                    if (budget >= totalPrice)
                    {
                        leftMoney = budget * 1.0 - totalPrice;


                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlowers} and {leftMoney:F2} leva left.");
                    }
                    else
                    {
                        needMoney = totalPrice * 1.0 - budget;

                        Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
                    }
                }
            }
            else if (typeFlowers == "Narcissus")
            {
                totalPrice = numberOfFlowers * 3.0;


                if (numberOfFlowers < 120)
                {
                    totalPrice *= 1.15;




                    if (budget >= totalPrice)
                    {
                        leftMoney = budget * 1.0 - totalPrice;


                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlowers} and {leftMoney:F2} leva left.");
                    }
                    else
                    {
                        needMoney = totalPrice * 1.0 - budget;

                        Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
                    }

                }

                else
                {
                    if (budget >= totalPrice)
                    {
                        leftMoney = budget * 1.0 - totalPrice;


                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlowers} and {leftMoney:F2} leva left.");
                    }
                    else
                    {
                        needMoney = totalPrice * 1.0 - budget;

                        Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
                    }
                }
            }
            else if (typeFlowers == "Gladiolus")
            {
                totalPrice = numberOfFlowers * 2.50;


                if (numberOfFlowers < 80)
                {
                    totalPrice *= 1.20;




                    if (budget >= totalPrice)
                    {
                        leftMoney = budget * 1.0 - totalPrice;


                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlowers} and {leftMoney:F2} leva left.");
                    }
                    else
                    {
                        needMoney = totalPrice * 1.0 - budget;

                        Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
                    }

                }

                else
                {
                    if (budget >= totalPrice)
                    {
                        leftMoney = budget * 1.0 - totalPrice;


                        Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlowers} and {leftMoney:F2} leva left.");
                    }
                    else
                    {
                        needMoney = totalPrice * 1.0 - budget;

                        Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
                    }
                }
            }
        }

    }
}


