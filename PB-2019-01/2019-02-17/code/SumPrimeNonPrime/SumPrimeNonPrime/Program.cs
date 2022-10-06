using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string stop = string.Empty;

            int prime_sum = 0;

            int nonprime_sum = 0;

            while (stop != "stop")
            {
                stop = Console.ReadLine();

                int theNum;
                bool parsed = Int32.TryParse(stop, out theNum);

                if (parsed)
                {
                    if (theNum < 3)  // special case check, less than 3
                    {
                        if (theNum == 2)
                        {
                            // The only positive number that is a prime

                            prime_sum = prime_sum + theNum;
                        }
                        else
                        {
                            // All others, including 1 and all negative numbers,
                            // are not primes
                            if (theNum < 0)
                            {
                                Console.WriteLine("Number is negative.");
                            }
                            else if (theNum == 1)
                            {
                                nonprime_sum = nonprime_sum + theNum;
                            }

                        }
                    }
                    else
                    {
                        if (theNum % 2 == 0)
                        {
                            // Is the number even?  If yes it cannot be a prime
                            //Console.WriteLine("{0} is not a prime", theNum);
                            nonprime_sum = nonprime_sum + theNum;
                        }
                        else
                        {
                            // If number is odd, it could be a prime
                            int div;

                            // This loop starts and 3 and does a modulo operation on all
                            // numbers.  As soon as there is no remainder, the loop stops.
                            // This can be true under only two circumstances:  The value of
                            // div becomes equal to theNum, or theNum is divided evenly by
                            // another value.
                            for (div = 3; theNum % div != 0; div += 2)
                                ;  // do nothing

                            if (div == theNum)
                            {
                                // if theNum and div are equal it must be a prime

                                prime_sum = prime_sum + theNum;
                            }
                            else
                            {
                                // some other number divided evenly into theNum, and it is not
                                // itself, so it is not a prime

                                nonprime_sum = nonprime_sum + theNum;
                            }
                        }
                    }
                }
                else if (stop == "stop")
                {
                    break;
                }
            }
            Console.WriteLine("Sum of all prime numbers is: {0}", prime_sum);
            Console.WriteLine("Sum of all non prime numbers is: {0}", nonprime_sum);
        }
    }
}
        
    

