using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Booleans(true, true);
            Booleans(true, false);
            Booleans(false, false);
            Booleans(false, true);
            Console.WriteLine("");

            RelationalOperators(2, 7);
            RelationalOperators(14, 0);
            RelationalOperators(4, 0);
            RelationalOperators(4, 4);

            Decisions("Serhii", 18);
            Decisions("Kate", 24);
            Decisions("Makar", 10);
            Decisions("Andrew", 19);
            Decisions("Nadya", 60);
            Decisions("Rachiel", 660);
            Decisions("Denis", -1);
            Console.WriteLine("");

            Equality();

        }

        /* 
        === LOGICAL OPERATORS ===
            AND &&
            OR ||
            NOT !
        */
        static void Booleans(bool isRainy, bool hasUmbrella)
        {
            // Variants of OR statements
            // true || true -> true
            // true || false -> true
            // false || true -> true
            // false || false -> false        <<<

            // Variants of the AND statements
            // true && true -> true           <<<
            // true && false -> false
            // false && true -> false
            // false && false -> false

            if (!isRainy) {
                Console.WriteLine("You can go outside.");
            } else if (isRainy && hasUmbrella) {
                Console.WriteLine("You can go outside.");
            } else
            {
                Console.WriteLine("You would rather stay indoors.");
            }
        }

        // RELATIONAL OPERATORS
        // < less than
        // <= less than or equal
        // > greater than
        // >= greater than or equal
        static void RelationalOperators(decimal num1, decimal num2)
        {
            bool isGreater = num1 > num2;
            bool isLess = num1 < num2;

            if (isGreater || isLess)
            {
                Console.WriteLine($"{num1} > or < {num2}. \nGreater than? - {isGreater}. \nLess than? - {isLess}.\n");
            } else
            {
                Console.WriteLine($"{num1} == {num2}\n");
            }
        }

        // if (condition) {
        //   // code
        // }
        static void Decisions(string name, int age)
        {
            if (age > 0 && age <= 100)
            {
                if (age >= 60)
                {
                    Console.WriteLine("[x] {0}, {1} y.o., too old to visit the club.", name, age);
                }
                else if (age >= 18)
                {
                    Console.WriteLine("[v] {0}, {1} y.o., allowed to visit the club.", name, age);
                }
                else
                {
                    Console.WriteLine("[x] {0}, {1} y.o., not allowed to visit the club.", name, age);
                }
            } else
            {
                Console.WriteLine("[i] Invalid output. The data is out of range.");
            }

                
        }

        static void Equality()
        {
            Console.Write("Enter a number: ");
            decimal num1 = decimal.Parse(Console.ReadLine());

            Console.Write("Enter a number again: ");
            decimal num2 = decimal.Parse(Console.ReadLine());

            bool isEqual = num1 == num2;
            bool isNotEqual = num1 != num2;

            if (isEqual)
            {
                Console.WriteLine("Numbers are equal!");
            } else
            {
                Console.WriteLine("Numbers are not equal!");
            }
        }
    }
}
