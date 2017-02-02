using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIndexRotator
{
    class Program
    {
        public static List<int> twoIndexRotator(List<int> nums)
        {
            List<int> firstTwo = nums.GetRange(0, 2);
            List<int> theRest = nums.GetRange(2, nums.Count() - 2);

            // because there isn't a built in method to swap in C#, we'll have to manually do it
            nums.RemoveRange(0, nums.Count());
            nums.AddRange(theRest);
            nums.AddRange(firstTwo);

            return nums;
        }

        static void Main(string[] args)
        {
            List<int> example = new List<int>() { 1, 2, 3, 4, 5, 6 };

            foreach (var num in twoIndexRotator(example))
            {
                Console.WriteLine(num);
            }
        }
    }
}
