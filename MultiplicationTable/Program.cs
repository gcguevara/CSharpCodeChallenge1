using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            /* *****CODE CHALLENGE #7*****
             * 
             * Use only code to create a multiplication table from one to twelve.
             * 
             */

            Console.WriteLine("Multiplication Table 1-12");
            Console.WriteLine("");

            Console.Write("\t\t");
            for (int header = 1; header <= 12; header++)
            {
                Console.Write(header + "\t");
            }

            Console.WriteLine("");

            Console.Write("\t  ");
            for (int row = 1; row <= 12; row++)
            {
                Console.Write("________");
            }

            for (int row = 1; row <= 12; row++)
            {
                Console.Write("\n" + row + "\t|\t");
                for(int col = 1; col <= 12; col++)
                {
                    Console.Write(row * col + "\t");
                }
            }
        }
    }
}
