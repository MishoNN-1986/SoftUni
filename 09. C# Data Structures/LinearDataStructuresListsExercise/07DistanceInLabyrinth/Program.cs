using System;

namespace _07DistanceInLabyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var labyrint = new string[length, length];
            for (int col = 0; col < length; col++)
            {
                string line = Console.ReadLine();
                for (int row = 0; row < length; row++)
                {
                    string symbol = line[row].ToString();
                    labyrint[col, row] = symbol;
                }
            }
            bool isHaveAnyCommonWall = true;
            while (isHaveAnyCommonWall)
            {
                isHaveAnyCommonWall = false;
                for (int col = 0; col < length; col++)
                {
                    for (int row = 0; row < length; row++)
                    {
                        string currentElement = labyrint[col, row].ToString();
                        if (currentElement == "*")
                        {
                            if (col > 0 && labyrint[col - 1, row] == "0")
                            {
                                labyrint[col - 1, row] = "1";
                                isHaveAnyCommonWall = true;
                            }
                            if (col < length - 1 && labyrint[col + 1, row] == "0")
                            {
                                labyrint[col + 1, row] = "1";
                                isHaveAnyCommonWall = true;
                            }
                            if (row > 0 && labyrint[col, row - 1] == "0")
                            {
                                labyrint[col, row - 1] = "1";
                                isHaveAnyCommonWall = true;
                            }
                            if (row < length - 1 && labyrint[col, row + 1] == "0")
                            {
                                labyrint[col, row + 1] = "1";
                                isHaveAnyCommonWall = true;
                            }
                        }
                        int number;
                        bool isCurrentElementInt = int.TryParse(currentElement, out number);
                        if (isCurrentElementInt && currentElement != "0")
                        {
                            int newElement = number + 1;

                            if (col > 0 && labyrint[col - 1, row] == "0")
                            {
                                labyrint[col - 1, row] = newElement.ToString();
                                isHaveAnyCommonWall = true;
                            }
                            if (col < length - 1 && labyrint[col + 1, row] == "0")
                            {
                                labyrint[col + 1, row] = newElement.ToString();
                                isHaveAnyCommonWall = true;
                            }
                            if (row > 0 && labyrint[col, row - 1] == "0")
                            {
                                labyrint[col, row - 1] = newElement.ToString();
                                isHaveAnyCommonWall = true;
                            }
                            if (row < length - 1 && labyrint[col, row + 1] == "0")
                            {
                                labyrint[col, row + 1] = newElement.ToString();
                                isHaveAnyCommonWall = true;
                            }
                        }
                    }
                }
            }
            PrintLabyrint(labyrint);
        }

        private static void PrintLabyrint(string[,] labyrint)
        {
            for (int col = 0; col < labyrint.GetLength(1); col++)
            {
                for (int row = 0; row < labyrint.GetLength(0); row++)
                {
                    string element = labyrint[col, row].ToString();
                    if (element == "0")
                    {
                        element = "u";
                    }
                    Console.Write(element);
                }
                Console.WriteLine();
            }
        }
    }
}
