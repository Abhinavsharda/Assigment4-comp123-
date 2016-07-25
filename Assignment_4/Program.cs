using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Author: abhinav sharda
 * StudentNumber: 300868625
 * Description: Program for simulating dice rolls 36,000 times
 */
namespace Assignment_4
{
    /**
     * this class is the "driver" class for my program
     * @class Program
     */
    class Program
    {
        /**Main method of driver class
         * 
         * @method Main
         * param {string} args
         */
        static void Main(string[] args)
        {
            int[] tally = new int[13];

            Random random = new Random();

            int presentNumber = 0;

            // loop calculates the sum two dice no
            for (int rolls = 1; rolls < 36000; rolls++)
            {
                presentNumber = random.Next(1, 7) + random.Next(1, 7);

                ++tally[presentNumber];
            }
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Dice No.   |    Times Rolled");
            //This loop outputs the sum of the two no and the number 
            // of repeated  sum
            for (int Index = 2; Index < 13; ++Index)
            {
                Console.WriteLine("{0,4}     | {1,17}", Index, tally[Index]);
            }
            Console.WriteLine("<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>");
            Console.ReadLine();
        }
    } // End of namespace
}// End of program
