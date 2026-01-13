using System;
using System.Globalization;

namespace _01_Fundamentals
{
    internal class Tasks
    {
        static void Main(string[] args)
        {
            Task1();
            Console.WriteLine("");
            Task2();
            Console.WriteLine("");
            Task3();
            Console.WriteLine("");
            Task4();
            Console.WriteLine("");
            Task5();
        }

        static void Task1()
        {
            // Read from console: name(string), age(int), height(double).
            // Output everything in one line using string interpolation.

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double height = double.Parse(
                Console.ReadLine().Replace(',', '.'), 
                CultureInfo.InvariantCulture);

            Console.WriteLine($"{name}, {age}, {height}");
        }

        static void Task2()
        {
            // Read two numbers(string → int).
            // Calculate + - * /.
            // Print all results.
            // Prevent division by zero ⚠️
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Addition: {num1 + num2}");
            Console.WriteLine($"Subtraction: {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1 * num2}");
            if (num2 != 0)
                {
                    Console.WriteLine($"Division: {num1 / num2}");
                } else
            {
                throw new DivideByZeroException();
            }

            }

        static void Task3()
        {
            int num = 3;

            double num1 = 3.14;
            double num2 = num1;
            int num3 = (int)num2;

            string userName = "wxzxmqx";
            char sign = '$';

            Console.WriteLine(num.GetType());
            Console.WriteLine(num1.GetType());
            Console.WriteLine(userName.GetType());
            Console.WriteLine(sign.GetType());
        }

        static void Task4()
        {
            string greeting = "Hello \n\t\tWorld! \"_\"";

            Console.WriteLine("Output: ");
            Console.WriteLine(greeting);
            Console.WriteLine("The length of the string is {0}. The first character is {1}", greeting.Length, greeting[0]);
        }

        static void Task5()
        {
            // ======= COMPILE-TIME ERROR =======
            // int x = "5"; - compile-time error (won't compile)

            int x = int.Parse("5");

            // ======= RUNTIME ERROR =======
            // int a = 5, b = 0;
            // int result = x / y; - runtime error (during execution)

            int a = 5, b = 1;
            if (b != 0)
            {
                int result = a / b;
            }

            // ======= WARNING =======
            bool isDelivered = false; // the variable is assigned but its value is never used


        }
    }
}
