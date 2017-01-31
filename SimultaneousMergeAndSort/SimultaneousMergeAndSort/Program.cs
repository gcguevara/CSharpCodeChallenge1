using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimultaneousMergeAndSort
{
    class Program
    {
        /* *****CODING CHALLENGES*****
         * 
         * 18. Write a function that merges two sorted lists into a new sorted list. [1,4,6],[2,3,5] → [1,2,3,4,5,6].
         *     You can do this quicker than concatenating them followed by a sort.
         * 
         */

        public static List<int> simultaneousMergeAndSort(List<int> first, List<int> second)
        {
            int firstIndex = 0;
            int secondIndex = 0;
            int lengthOfList = first.Count() + second.Count();
            List<int> newList = new List<int>(lengthOfList);

            while (firstIndex < first.Count() || secondIndex < second.Count())
            {
                if (firstIndex != first.Count() && secondIndex != second.Count())
                {
                    if (first[firstIndex] <= second[secondIndex])
                    {
                        newList.Add(first[firstIndex]);
                        firstIndex++;
                    }
                    else
                    {
                        newList.Add(second[secondIndex]);
                        secondIndex++;
                    }
                }
                else if (secondIndex == second.Count())
                {
                    newList.Add(first[firstIndex]);
                    firstIndex++;
                }
                else
                {
                    newList.Add(second[secondIndex]);
                    secondIndex++;
                }
            }

            return newList;
        }

        static void Main(string[] args)
        {
            List<int> first = new List<int>() { 1, 4, 6 };
            List<int> second = new List<int>() { 2, 3, 5 };

            foreach (var num in simultaneousMergeAndSort(first, second))
            {
                Console.WriteLine(num); // { 1, 2, 3, 4, 5, 6 }
            }
        }
    }
}
