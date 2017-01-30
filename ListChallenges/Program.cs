using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListChallenges
{
    /* ***** CODING CHALLENGES 9-14 *****
     * 
     * 9. Write a function that returns the largest element in a list without using .Max().
     * 10. Reverse a list without using .Reverse().
     * 11. Write a function that checks if an element occurs within a list without using .Contain().
     * 12. Write a function that returns only the elements at odd indexes in a list.
     * 13. Write a function that keeps a running total of a list.
     * 14. Write a function that checks if a string is a palindrome
     * 
     */ 

    public class Program
    {
        /// <summary>
        /// Write a function that returns the largest element in a list without using .Max()
        /// </summary>
        /// <param name="nums">Takes a list of integers</param>
        /// <returns></returns>
        public static int maxFinder(List<int> nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Count(); i++)
            {
                if(nums[i] > max)
                {
                    max = nums[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Reverse a list without using .Reverse()
        /// </summary>
        /// <param name="nums">List of integers</param>
        /// <returns></returns>
        public static List<int> reverser(List<int> nums)
        {
            List<int> newList = new List<int>();

            for (int i = nums.Count() - 1; i >= 0; i--)
            {
                newList.Add(nums[i]);
            }

            return newList;
        }

        /// <summary>
        /// Write a function that checks whether an element occurs in a list without using .Contains()
        /// </summary>
        /// <param name="list">List of strings</param>
        /// <param name="value">String to check</param>
        /// <returns></returns>
        public static bool occursInList(List<string> list, string value)
        {
            value = value.Trim();

            foreach (var item in list)
            {
                if(item == value)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Write a function that returns only the elements at odd indexes in a list.
        /// </summary>
        /// <param name="list">List of ints</param>
        /// <returns></returns>
        public static List<int> oddIndexes(List<int> list)
        {
            List<int> newList = new List<int>();
            for (int i = 1; i < list.Count; i += 2)
            {
                newList.Add(list[i]);
            }

            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }

            return newList;
        }

        /// <summary>
        /// Write a function that keeps a running total of a list.
        /// </summary>
        /// <param name="list">List of ints</param>
        /// <returns></returns>
        public static int counter(List<int> list)
        {
            int count = 0;
            foreach (var num in list)
            {
                count++;
            }

            return count;
        }

        /// <summary>
        /// Write a function that checks if a string is a palindrome.
        /// </summary>
        /// <param name="word">Takes a string</param>
        /// <returns></returns>
        public static bool isPalindrome(string word)
        {
            // still need to strip with regex for whitespace, punctuation etc.
            word = word.ToLower();
            word = word.Trim();
            char[] arr = word.ToCharArray();

            for (double forwards = 0; forwards < Math.Floor((double)arr.Count() / 2); forwards++)
            {
                if (arr[Convert.ToInt32(forwards)] != arr[Convert.ToInt32(arr.Count() - (forwards + 1))])
                {
                    return false;
                }
            }
            return true;
        }



        static void Main(string[] args)
        {
            List<int> testNums = new List<int> { 2, 7, 11, 13, 6, 20, 18 };
            Console.WriteLine(maxFinder(testNums)); // 20
            Console.WriteLine(reverser(testNums)); // { 18, 20, 6, 13, 11, 7, 2 }

            List<string> testStrings = new List<string> { "red", "blue", "green", "yellow" };
            Console.WriteLine(occursInList(testStrings, "green")); // true
            Console.WriteLine(occursInList(testStrings, "indigo")); // false

            Console.WriteLine(oddIndexes(testNums)); // { 7, 13, 20 }

            Console.WriteLine(counter(testNums)); // 7

            Console.WriteLine(isPalindrome("kayak")); // returning false but should be true ***

            Console.WriteLine(isPalindrome("false")); // false
        }
    }
}
