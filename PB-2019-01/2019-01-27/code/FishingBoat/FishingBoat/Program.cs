using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int buget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberFisherman = int.Parse(Console.ReadLine());
            double priceForShip = 0.0;
            double needMouney = 0.0;
            double leftMoney = 0.0;
            if (season == "Spring")
            {
                priceForShip = 3000;
                if (numberFisherman % 2 == 0)
                {
                    priceForShip *= 0.95;
                    if (numberFisherman <= 6)
                    {
                        priceForShip *= 0.90;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }
                    }
                    else if (numberFisherman > 6 && numberFisherman <= 11)
                    {
                        priceForShip *= 0.85;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }

                    }
                    else if (numberFisherman > 12)
                    {
                        priceForShip *= 0.75;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }
                    }
                }
                else
                {
                    if (numberFisherman <= 6)
                    {
                        priceForShip *= 0.90;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }
                    }
                    else if (numberFisherman > 6 && numberFisherman <= 11)
                    {
                        priceForShip *= 0.85;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }

                    }
                    else if (numberFisherman > 12)
                    {
                        priceForShip *= 0.75;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }
                    }
                }
            }
            else if (season == "Summer")
            {
                priceForShip = 4200;
                if (numberFisherman % 2 == 0)
                {
                    priceForShip *= 0.95;
                    if (numberFisherman <= 6)
                    {
                        priceForShip *= 0.90;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }
                    }
                    else if (numberFisherman > 6 && numberFisherman <= 11)
                    {
                        priceForShip *= 0.85;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }

                    }
                    else if (numberFisherman > 12)
                    {
                        priceForShip *= 0.75;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }
                    }
                }
                else
                {
                    if (numberFisherman <= 6)
                    {
                        priceForShip *= 0.90;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }
                    }
                    else if (numberFisherman > 6 && numberFisherman <= 11)
                    {
                        priceForShip *= 0.85;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }

                    }
                    else if (numberFisherman > 12)
                    {
                        priceForShip *= 0.75;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }
                    }
                }
            }
            else if (season == "Autumn")
            {
                priceForShip = 4200;

                if (numberFisherman <= 6)
                {
                    priceForShip *= 0.90;

                    if (buget >= priceForShip)
                    {
                        leftMoney = buget - priceForShip;
                        Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                    }
                    else
                    {
                        needMouney = priceForShip - buget;
                        Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                    }
                }
                else if (numberFisherman > 6 && numberFisherman <= 11)
                {
                    priceForShip *= 0.85;

                    if (buget >= priceForShip)
                    {
                        leftMoney = buget - priceForShip;
                        Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                    }
                    else
                    {
                        needMouney = priceForShip - buget;
                        Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                    }

                }
                else if (numberFisherman > 12)
                {
                    priceForShip *= 0.75;

                    if (buget >= priceForShip)
                    {
                        leftMoney = buget - priceForShip;
                        Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                    }
                    else
                    {
                        needMouney = priceForShip - buget;
                        Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                    }
                }



                else if (numberFisherman <= 6)
                {
                    priceForShip *= 0.90;

                    if (buget >= priceForShip)
                    {
                        leftMoney = buget - priceForShip;
                        Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                    }
                    else
                    {
                        needMouney = priceForShip - buget;
                        Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                    }
                }
                else if (numberFisherman > 6 && numberFisherman <= 11)
                {
                    priceForShip *= 0.85;

                    if (buget >= priceForShip)
                    {
                        leftMoney = buget - priceForShip;
                        Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                    }
                    else
                    {
                        needMouney = priceForShip - buget;
                        Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                    }

                }
                else if (numberFisherman > 12)
                {
                    priceForShip *= 0.75;

                    if (buget >= priceForShip)
                    {
                        leftMoney = buget - priceForShip;
                        Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                    }
                    else
                    {
                        needMouney = priceForShip - buget;
                        Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                    }
                }
            }
            else if (season == "Winter")
            {
                priceForShip = 2600;
                if (numberFisherman % 2 == 0)
                {
                    priceForShip *= 0.95;
                    if (numberFisherman <= 6)
                    {
                        priceForShip *= 0.90;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }
                    }
                    else if (numberFisherman > 6 && numberFisherman <= 11)
                    {
                        priceForShip *= 0.85;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }

                    }
                    else if (numberFisherman > 12)
                    {
                        priceForShip *= 0.75;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }
                    }
                }
                else
                {
                    if (numberFisherman <= 6)
                    {
                        priceForShip *= 0.90;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }
                    }
                    else if (numberFisherman > 6 && numberFisherman <= 11)
                    {
                        priceForShip *= 0.85;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }

                    }
                    else if (numberFisherman > 12)
                    {
                        priceForShip *= 0.75;

                        if (buget >= priceForShip)
                        {
                            leftMoney = buget - priceForShip;
                            Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
                        }
                        else
                        {
                            needMouney = priceForShip - buget;
                            Console.WriteLine($"Not enough money! You need {needMouney:F2} leva.");
                        }
                    }
                }
            }
        }
    }
}

