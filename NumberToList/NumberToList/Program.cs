using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToList
{
    class Program
    {
        /* *****CODING CHALLENGE #22*****
         * 
         * 22. Write a function that takes a number and returns a list of its digits.
         * 
         */

        public static List<double> numberToList(string num)
        {
            List<double> newList = new List<double>();
            char[] tempArr;
            
            tempArr = num.ToCharArray();
            foreach (var value in tempArr)
            {
                double digit = char.GetNumericValue(value);
                newList.Add(digit);
            }

            return newList;
        }

        static void Main(string[] args)
        {
            foreach (var value in numberToList("12345"))
            {
                Console.WriteLine(value); // { 1, 2, 3, 4, 5 }
            }
        }
    }
}
