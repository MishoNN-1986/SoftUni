using System;
using System.Collections.Generic;

namespace _02CalculateSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Queue<int> members = new Queue<int>();
            Queue<int> outputMembers = new Queue<int>();
            members.Enqueue(num);
            outputMembers.Enqueue(num);
            while (outputMembers.Count < 50)
            {
                int currentNum = members.Dequeue();
                int secondMember = currentNum + 1;
                members.Enqueue(secondMember);
                outputMembers.Enqueue(secondMember);

                if (outputMembers.Count == 50)
                {
                    PrintMembers(outputMembers);
                    return;
                }
                int thirdMember = 2 * currentNum + 1;
                members.Enqueue(thirdMember);
                outputMembers.Enqueue(thirdMember);

                if (outputMembers.Count == 50)
                {
                    PrintMembers(outputMembers);
                    return;
                }

                int fourthMember = currentNum + 2;
                members.Enqueue(fourthMember);
                outputMembers.Enqueue(fourthMember);

                if (outputMembers.Count == 50)
                {
                    PrintMembers(outputMembers);
                    return;
                }
            }
        }

        private static void PrintMembers(Queue<int> members)
        {
            Console.WriteLine(string.Join(", ", members));
        }
    }
}
