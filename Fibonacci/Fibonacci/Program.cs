using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        /* *****CODE CHALLENGE #20*****
         * 
         *  20. Write a function that computes the list of the first 100 Fibonacci numbers.
         * 
         */

        /// <summary>
        /// Iterative approach
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static List<int> fibonacci(int num)
        {
            int first = 0;
            int second = 1;
            int result = 0;

            List<int> fibList = new List<int>(100) { 0, 1 };

            // run checks for if num is equal to 0 or 1
            if (num == 0)
            {
                Console.WriteLine("You must pass in a value two or greater.");
                return fibList;
            }

            if (num == 1)
            {
                Console.WriteLine("You must pass in a value two or greater.");
                return fibList;
            }

            // for i is at least two and less than num
            for (int i = 2; i < num; i++)
            {
                // add first and second
                result = first + second;
                fibList.Add(result);

                // assign the value of second to first
                first = second;

                // assign the sum to second
                second = result;
            }

            return fibList;
        }

        static void Main(string[] args)
        {
            foreach (var num in fibonacci(100))
            {
                Console.WriteLine(num);
            }
        }
    }
}
