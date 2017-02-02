using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRotator
{
    class Program
    {
        /* *****CODING CHALLENGE #21*****
         * 
         * Write a function that rotates a list by k elements. For example [1,2,3,4,5,6] rotated by two becomes [3,4,5,6,1,2].
         * Try solving this without creating a copy of the list. How many swap or move operations do you need?
         * 
         */

        public static void listRotator(List<int> nums, int k)
        {
            if(k < 0)
            {
                k %= nums.Count();
            }

            if (k == 0)
            {
                Console.WriteLine("Why would you rotate a list by zero?");
            }

            if (k > nums.Count())
            {
                k %= nums.Count();
            }

            int index = k;
            int temp;

            while (index < nums.Count())
            {
                int swapIndex = index - k;
                temp = nums[index];
                nums[index] = nums[swapIndex];
                nums[swapIndex] = temp;
                index++;
            }
        }

        static void Main(string[] args)
        {
            List<int> example = new List<int>() { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("Before rotation:\n");
            foreach (var num in example)
            {
                Console.WriteLine(num);
            }

            listRotator(example, 2);
            Console.WriteLine("\nAfter rotation:\n");
            foreach (var num in example)
            {
                Console.WriteLine(num);
            }
        }
    }
}
