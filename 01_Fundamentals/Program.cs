using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImplicitlyTypedVariables();
            Operators(4,4);
            Console.WriteLine(CharDataType());
            StringFormatting();
            StringWithSymbols();
        }

        static void ImplicitlyTypedVariables()
        {
            // var means implicitly typed variable
            var userAge = 30;
            var userThemePreference = "dark";
            var isSignedUp = false;

            Console.WriteLine(userAge);
            Console.WriteLine(userThemePreference);
            Console.WriteLine(isSignedUp);
            
        }

        static void Operators(decimal x = 0, decimal y = 0)
        {
            decimal num1 = x;
            decimal num2 = y;

            // Example of Concatination
            Console.WriteLine("First number is " + x);
            Console.WriteLine("Second number is " + y);

            Console.WriteLine("Addition: " + Addition());
            Console.WriteLine("Subtraction: " + Subtraction());
            Console.WriteLine("Multiplication: " + Multiplication());
            Console.WriteLine("Division: " + Division());

            decimal Addition() => x + y;
            decimal Subtraction() => x - y;
            decimal Multiplication() => x * y;
            decimal Division()
            {
                if (y == 0)
                {
                    throw new DivideByZeroException("ERROR: Division by zero is not allowed");
                }

                return x / y;
            }
        }

        static string CharDataType()
        {
            char dollarSign = '$';

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            while (password.Length < 8 
                || string.IsNullOrWhiteSpace(password) 
                || !password.Any(char.IsUpper))
            {
                Console.WriteLine("Password must be at least 8 characters and contain an uppercase letter.");
                Console.Write("Enter your password: ");
                password = Console.ReadLine();
            }

            string maskedPassword = new string(dollarSign, password.Length);
            return maskedPassword;
        }

        static void StringFormatting()
        {
            int num = 10;
            double price = 19.99;
            string name = "Frank";
            double discount = Math.Round(price - (price * 0.2), 2);

            string[] groceriesList = { "potato", "fish", "meat", "eggs" };

            // String Interpolation
            Console.WriteLine($"The number is {num}");

            // String Concatination
            Console.WriteLine("The number is " + num);

            // String Formatting
            Console.WriteLine("{0}. the actual price of the product {1} is {2}", name, groceriesList[1], discount);
        }

        static void StringWithSymbols()
        {
            string s1 = "This is a string with\n a slash (/) and a colon (\")";
            Console.WriteLine(s1);
        }
    }
}
