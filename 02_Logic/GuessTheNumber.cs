using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Logic
{
    internal class GuessTheNumber
    {
        static void Main(string[] args)
        {
            // Creating an instance of the random class
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            Console.WriteLine("Guess the number");
            string input = Console.ReadLine();
            int number = 0;

            bool isNumber = int.TryParse(input, out number);

            if (isNumber)
            {
                if (number == randomNumber)
                {
                    Console.WriteLine("Congratulations! You've guessed the number!");
                } else
                {
                    Console.WriteLine("Try again!");
                }
            } else
            {
                Console.WriteLine("Please enter the valid number.");
            }
        }
    }
}
