using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCombinations
{
    class Program
    {
        /* *****CODING CHALLENGES*****
         * 
         * 16. Write a function on_all that applies a function to every element of a list and use
         *     it to print the first twenty perfect squares.
         * 17. Write a function that concatenates two lists. [a,b,c], [1,2,3] → [a,b,c,1,2,3]
         * 
         */

        /// <summary>
        /// Squares the parameter and returns it.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int squareFunc(int num)
        {
            return num * num;
        }

        // Create a delegate for the OnAll function
        public delegate int myDelegate(int num);

        /// <summary>
        /// 16. Write a function on_all that applies a function to every element of a list
        /// and use it to print the first twenty perfect squares.
        /// </summary>
        /// <param name="nums">List of integers</param>
        /// <param name="myFunction">Function to perform on each integer</param>
        /// <returns></returns>
        public static List<int> OnAll(List<int> nums, myDelegate myFunction)
        {
            List<int> results = new List<int>();
            for (int i = 0; i < nums.Count(); i++)
            {
                results.Add(myFunction(nums[i]));
            }

            return results;
        }

        /// <summary>
        /// Write a function that concatenates two lists. [a,b,c], [1,2,3] → [a,b,c,1,2,3]
        /// </summary>
        /// <param name="first">List of objects</param>
        /// <param name="second">List of objects</param>
        /// <returns></returns>
        public static List<object> listConcatenator(List<object> first, List<object> second)
        {
            List<object> sum = new List<object>();
            sum = first.Concat(second).ToList();
            return sum;
        }

        static void Main(string[] args)
        {
            List<int> example = Enumerable.Range(1, 20).ToList();

            foreach (var value in OnAll(example, squareFunc))
            {
                Console.WriteLine(value); // returns list of values squared
            }

            List<object> abc = new List<object>() { "a", "b", "c" };
            List<object> onetwothree = new List<object>() { 1, 2, 3 };

            foreach (var result in listConcatenator(abc, onetwothree))
            {
                Console.WriteLine(result); // { "a","b", "c", 1, 2, 3 }
            }  
        }
    }
}
