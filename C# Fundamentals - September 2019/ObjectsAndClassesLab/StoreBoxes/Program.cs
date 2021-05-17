using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxList = new List<Box>();
            string[] input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                Box box = new Box()  // box е обект в класа Box, а с new Box() извикваме конструктора
                {
                    SerialNumber = input[0],  // може и Box box = new Box(input[0],.....);
                    Item = new Item(input[1], double.Parse(input[3])),
                    ItemQuantity = int.Parse(input[2])
                };

                boxList.Add(box);
                //if (boxList.Count == 0)
                //{
                //    boxList.Add(box);
                //}
                //else
                //{
                //    for (int i = 0; i < boxList.Count; i++)
                //    {
                //        if (box.TotalPrice > boxList[i].TotalPrice)
                //        {
                //            boxList.Insert(i, box); //???
                //            break;
                //        }
                //        else if (i == boxList.Count - 1)
                //        {
                //            boxList.Add(box);
                //            break;
                //        }
                //    }
                //}

                input = Console.ReadLine().Split();
            }
            
            boxList.Sort(
                (a, b) =>
                    a.TotalPrice > b.TotalPrice ? -1 :
                    a.TotalPrice < b.TotalPrice ? 1 : 0);

            foreach (Box box in boxList)
            {
                Console.WriteLine(box);
            }
        }
    }
}
