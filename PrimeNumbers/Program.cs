using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ***** CODING CHALLENGE #8 *****
             * 
             * Write a function that prints only prime numbers up to 100.
             * 
             */

            for(int possiblePrime = 2; possiblePrime <= 100; possiblePrime++)
            {
                bool isPrime = true;
                for(int divisor = 2; divisor < possiblePrime; divisor++)
                {
                    if(possiblePrime % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    Console.WriteLine(possiblePrime);
                }
            }
        }
    }
}
