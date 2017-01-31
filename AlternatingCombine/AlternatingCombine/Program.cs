using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternatingCombine
{
    class Program
    {
        /* *****CODING CHALLENGE #19******
         * 
         * 19. Write a function that combines two lists by alternatingly taking elements,
         *     e.g. [a,b,c], [1,2,3] → [a,1,b,2,c,3].
         *     
         */     

        public static List<object> alternateCombine(List<object> first, List<object> second)
        {
            int firstIndex = 0;
            int secondIndex = 0;
            int listLength = first.Count() + second.Count();
            List<object> newList = new List<object>(listLength);

            while (firstIndex < first.Count() || secondIndex < second.Count())
            {
                if (firstIndex != first.Count() && secondIndex != second.Count())
                {
                    if (firstIndex <= secondIndex)
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
            List<object> first = new List<object>() { "a", "b", "c" };
            List<object> second = new List<object>() { 1, 2, 3 };

            foreach (var num in alternateCombine(first, second))
            {
                Console.WriteLine(num); // { "a", 1, "b", 2, "c", 3 }
            }
        }
    }
}
