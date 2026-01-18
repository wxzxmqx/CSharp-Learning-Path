using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // from 10 to 0
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--- --- ---");

            // the loop goes until i is less than 10,
            // if i is 10 or more, the loop stops

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // \n stands for "new line"
            // \r - carriage return

            string myString = "Hi \r\nThere!";

            const int milliseconds = 1000;
            int seconds = 3 * milliseconds;

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(myString);

                // Thread.Sleep method
                // can be used to pause the execution for a specified time.
                // Thread.Sleep(seconds);
            }

            // Rocket Landing Simulation

            Console.Clear();

            string rocket = @"
                            /\
                           /  \
                          /    \
                         /______\
                        |        |
                        |        |
                        |        |
                        |        |
                        |        |
                        |        |
                       /|   ||   |\
                      / |   ||   | \
                     /  |   ||   |  \
                    /___|   ||   |___\
                        |        |
                         \      /
                          ||  ||
                    ";

            string space = "";

            for (int i = 0; i <= 1; i++)
            {
                Thread.Sleep(400);
                Console.Clear();

                space += "\n";

                Console.WriteLine(space);
                Console.WriteLine(rocket);
            }

            Console.WriteLine("The Rocket is landed. Woohoo!");

            //while loop
            int k = 0;

            // while loop WORKS UNTIL the condition is TRUE, otherwise FALSE
            while (k < 10)
            {
                k++;
                Console.WriteLine(k);
            }

            Console.Write("Go or Stay?: ");
            string userChoice = Console.ReadLine().ToLower();

            while (userChoice == "go")
            {
                Console.WriteLine("Go for a mile");
                Console.WriteLine("Wanna keep going? Enter go.");
                userChoice = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Finally you are staying!");

            // Guess the Number implementation
            Random gen = new Random();
            int secretNumber = gen.Next(0, 51);
            int userGuess = 0;
            int attempts = 0;

            Console.WriteLine("Guess the number between 0 and 50");

            while (userGuess != secretNumber)
            {
                Console.Write("Type number: ");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess < secretNumber)
                {
                    Console.WriteLine("The number is greater than you've typed. Try again");
                    attempts++;
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("The number is less than you've typed. Try again.");
                    attempts++;
                }
                else
                {
                    Console.WriteLine("||==============================||");
                    Console.WriteLine("|| Finally! The number was {0}.  ||", secretNumber);
                    Console.WriteLine("|| Attempts: {0}                  ||", attempts);
                    Console.WriteLine("||==============================||");
                }
            }

            Console.Clear();

            //----------------//
            // ADVENTURE GAME //
            //----------------//

            Console.WriteLine("Welcome to the Adventure's Game!");
            Console.Write("Enter your character's name: ");
            string playerName = Console.ReadLine();

            Console.Write("Choose your character type (Warrior, Wizard, Archer): ");
            string characterType = Console.ReadLine();

            Console.WriteLine($"You, {playerName} the {characterType} find yourself at the edge of a dark forest..");
            Console.Write("Do you enter the forest or camp outside? (Enter/Camp): ");

            string choice1 = Console.ReadLine();

            if (choice1.ToLower() == "enter")
            {
                Console.WriteLine("You bravely enter the forest..");
            } else
            {
                Console.WriteLine("You decide to camp out and wait for daylight.");
            }

            bool gameContinues = true;

            while (gameContinues)
            {
                Console.WriteLine("You come to a fork in the road. Go left or right?: ");
                string direction = Console.ReadLine();

                if (direction.ToLower() == "left")
                {
                    Console.WriteLine("You found a treasure chest!");
                }
                else
                {
                    Console.WriteLine("You encountered a wild beast!");
                    Console.WriteLine("Fight or flee? (fight/flee)");

                    string fightChoice = Console.ReadLine();
                    if (fightChoice.ToLower() == "fight")
                    {
                        Random random = new Random();

                        int luck = random.Next(1, 11);

                        if (luck > 5)
                        {
                            Console.WriteLine("You beat the wild beast!");
                            if (luck > 8)
                            {
                                Console.WriteLine("The wild beast dropped a treasure!");

                            }
                        }
                        else
                        {
                            Console.WriteLine("The beast attacked you!");
                            Console.WriteLine("It rammed it's tusks into your chest and you bleed out.");
                            gameContinues = false;
                        }
                    }
                }
            }
        }
    }
}
