using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForWhileRecursive
{
    class Program
    {
        /* ***** CODE CHALLENGE #15 *****
         * 
         * Write three functions that sum the numbers in a list using a for loop, while loop, and recursion.
         * 
         */

        public static int sumFor(List<int> nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Count(); i++)
            {
                sum += nums[i];
            }

            return sum;
        }

        public static int sumWhile(List<int> nums)
        {
            int sum = 0;
            int i = 0;
            while (i < nums.Count())
            {
                sum += nums[i];
                i++;
            }

            return sum;
        }

        public static int sumRecursion(List<int> nums)
        {
            if (nums.Count() == 0)
            {
                return 0;
            }

            if (nums.Count() == 1)
            {
                return nums[0];
            }

            if (nums.Count > 1)
            {
                // add values at position [0] and [1] and assign the sum to [0]
                nums[0] = nums[0] + nums[1];
                // remove the number at index 1
                nums.RemoveAt(1);
            }

            return sumRecursion(nums);
        }

        static void Main(string[] args)
        {
            // Write three functions that sum the numbers in a list using a for loop, while loop, and recursion.

            List<int> example = new List<int>() { 2, 5, 17, 132, 65 }; // sum = 221

            Console.WriteLine(sumFor(example)); // returns 221
            Console.WriteLine(sumWhile(example)); // returns 221
            Console.WriteLine(sumRecursion(example)); // returns 221
        }
    }
}
