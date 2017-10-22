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

        static void Main(string[] args)
        {
            var first = new List<string>() { "a", "b", "c" };
            var second = new List<string>() { "1", "2", "3" };
            var combiner = new AlternateCombiner();
            var result = combiner.AlternateCombine(first, second);


            foreach (var num in result)
            {
                Console.WriteLine(num); // { "a", 1, "b", 2, "c", 3 }
            }
        }
    }
}
