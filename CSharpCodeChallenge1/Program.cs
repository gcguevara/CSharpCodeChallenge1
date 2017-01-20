using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge1
{
    class Program
    {
        /******* CODING CHALLENGE 1 *****
         * 
         * 1. Write a function that prints "Hello World!"
         * 2. Ask the user for their name and greet them by name
         * 3. Ask the user for their name but only greet them if their name is Alice or Bob
         * 4. Sum all the numbers from 1 to the user's input number
         * 5. Sum only numbers that are multiples of 3 and 5 from 1 to the user's input number
         * 6. Give the user the option to either multiply or add all the numbers from 1 to their number
         * 
         *******************************/

        /// <summary>
        /// Write a function to print "Hello World!"
        /// </summary>
        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Ask the user for their name and greet them.
        /// </summary>
        static void Greeting()
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            name = name.Trim();
            Console.WriteLine("Hello " + name + "!");
        }
        
        /// <summary>
        /// Ask the user for their name but only greet them if their name is Alice or Bob.
        /// </summary>
        static void HelloAliceOrBob()
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            name = name.Trim();

            if (name == "Alice")
            {
                Console.WriteLine("Hello Alice!");
            }
            else if (name == "Bob")
            {
                Console.WriteLine("Hello Bob!");
            }
            else
            {
                Console.WriteLine("Sorry, we only like the names Alice and Bob.");
            }
        }

        /// <summary>
        /// Add all the numbers from 1 to the user input.
        /// </summary>
        static void SumFromOneToInput()
        {
            Console.WriteLine("\nLet's get the sum of the numbers from 1 to your number. \nEnter a number.");
            string input = Console.ReadLine();
            input = input.Trim();
            int num;

            while (int.TryParse(input, out num) == false)
            {
                Console.WriteLine("\nI'm sorry, you must enter a number. Try again.");
                input = Console.ReadLine();
            }

            int sum = 0;
            for (int i = 0; i <= num; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        /// <summary>
        /// Change the SumFromOneToInput function to only use numbers that are multiples of 3 and 5.
        /// </summary>
        static void OnlySumMultiplesOfThreeAndFive()
        {
            Console.WriteLine("\nThis time we will only add numbers divisible by 3 or 5. \nEnter a number.");
            string input = Console.ReadLine();
            input = input.Trim();
            int numTwo;

            while (int.TryParse(input, out numTwo) == false)
            {
                Console.WriteLine("\nI'm sorry, you must enter a number. Try again.");
                input = Console.ReadLine();
            }

            int sum = 0;
            for (int i = 3; i <= numTwo; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

        /// <summary>
        /// Give the user the option to either multiply or add the numbers from 1 to their input.
        /// </summary>
        static void MultiplyOrAdd()
        {
            Console.WriteLine("\nPlease enter a new number.");
            string input = Console.ReadLine();
            input = input.Trim();
            int numThree;

            while (int.TryParse(input, out numThree) == false)
            {
                Console.WriteLine("\nI'm sorry, you must enter a number. Try again.");
                input = Console.ReadLine();
            }

            Console.WriteLine("Would you like to add or multiply all the numbers from 1 to your number?");
            input = Console.ReadLine();
            input = input.Trim();
            input = input.ToLower();
            List<string> multiplyOrAdd = new List<string> { "multiply", "add" };

            while (!multiplyOrAdd.Contains(input))
            {
                Console.WriteLine("\nI'm sorry, that is not a valid response.\nType 'multiply' or 'add'.");
                input = Console.ReadLine();
            }

            if (input == "multiply")
            {
                int product = 1;
                for (int i = 1; i < numThree; i++)
                {
                    product *= i;
                }
                Console.WriteLine(product);
            }
            else
            {
                int sum = 0;
                for (int i = 1; i < numThree; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }
        }

        static void Main(string[] args)
        {
            HelloWorld();
            Greeting();
            SumFromOneToInput();
            OnlySumMultiplesOfThreeAndFive();
            MultiplyOrAdd();
        }
    }
}
