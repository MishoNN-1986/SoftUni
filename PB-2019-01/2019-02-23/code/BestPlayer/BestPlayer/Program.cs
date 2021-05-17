using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int mostGoals = 0;
            string nameWithMostGoals = "";
            string nameWithHatTrick = "";
            int hattrickGoals = 0;
            int goals = 0;
            while (true)
            {

                string name = Console.ReadLine();

                if (name == "END")
                {
                    if (goals >= 3)
                    {
                        Console.WriteLine($"{nameWithHatTrick} is the best player!");
                        Console.WriteLine($"He has scored {hattrickGoals} goals and made a hat-trick !!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{nameWithMostGoals} is the best player!");
                        Console.WriteLine($"He has scored {mostGoals} goals.");
                        break;
                    }

                }
                else
                {
                    goals = int.Parse(Console.ReadLine());
                    if (goals >= 10)
                    {
                        Console.WriteLine($"{name} is the best player!");
                        Console.WriteLine($"He has scored {goals} goals and made a hat-trick !!!");
                        break;
                    }
                    else
                    {
                        if (goals > mostGoals)
                        {
                            mostGoals = goals;
                            nameWithMostGoals = name;
                            if (goals >= 3)
                            {
                                nameWithHatTrick = name;
                                hattrickGoals = goals;
                            }
                        }

                    }


                }

            }

        }
    }
}
