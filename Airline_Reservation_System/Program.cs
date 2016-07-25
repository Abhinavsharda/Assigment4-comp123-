using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* Author: abhinav sharda
 * StudentNumber: 300868625
 * Description:Program for Airline_Reservation_System
 */
namespace Airline_Reservation_System
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
            int selection = 0;
            Random random = new Random();
            Flight british = new Flight();

            //While loop for making selections
            while (selection != 3)
            {
                // Tickets Menu
                Console.WriteLine("|=====British Airways=====");
                Console.WriteLine("|1. Business Class         |");
                Console.WriteLine("|2. Economy Class       |");
                Console.WriteLine("|3. Exit                    |");
                Console.WriteLine("|===========================| \n");
                Console.Write("Select a class You wold like to book: ");
                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    selection = 0;
                }
                switch (selection)
                {
                    case 1:
                        british.BusinessClass();
                        break;

                    case 2:
                        british.EconomicClass();
                        break;
                    case 3:
                        british.Exit();
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }
            }


        }
    }// End of namespace
}// end of program
