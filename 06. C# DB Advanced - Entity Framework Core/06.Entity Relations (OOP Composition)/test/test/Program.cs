using System;
using System.Collections;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<int>{ 1, 2 , 3};

            var arr = new[] { 1, 2, 3 };

            void Method(ref int refArgument)
            {
                refArgument = refArgument + 44;
            }

            int number = 1;
            Method(ref number);
            Console.WriteLine(number);
            // Output: 45

            var array = new string[] { "foo", "bar" };

            var queque = new Queue<int>(new[] { 1, 2, 3 });

            int i = 0;
            for (; i < 10; i++)
            {
                if (i % 4 == 1)
                {
                    continue;
                }
                Console.WriteLine(i);
                if (i % 6 == 0 && i > 0)
                {
                    break;
                }
            }
        }
    }

}
