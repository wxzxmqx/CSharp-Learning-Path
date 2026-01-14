using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Logic
{
    internal class QuizApp
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("========================================\r\n          ██████╗ ██╗   ██╗██╗███████╗\r\n         ██╔═══██╗██║   ██║██║╚══███╔╝\r\n         ██║   ██║██║   ██║██║  ███╔╝ \r\n         ██║▄▄ ██║██║   ██║██║ ███╔╝  \r\n         ╚██████╔╝╚██████╔╝██║███████╗\r\n          ╚══▀▀═╝  ╚═════╝ ╚═╝╚══════╝\r\n========================================\r\n        Welcome to the QUIZ GAME\r\n========================================\r\n");
        //    Console.WriteLine("Select the option:");
        //    Console.WriteLine("\t1. Start the quiz");
        //    Console.WriteLine("\t2. Add the question");

        //    int op = int.Parse(Console.ReadLine());

        //    switch (op)
        //    {
        //        case 1: Quiz(); break;
        //        case 2: AddQuestion(); break;
        //        default: Console.WriteLine("Bye-bye!"); break;
        //    }
            
        //}

        static void Quiz()
        {
            string[] questions = new string[]
            {
                "What is the capital of France?",
                "What is 5 + 7?",
                "What keyword is used to declare a variable in C#?",
                "What does CPU stand for?",
                "What is the result of 10 / 2?",
                "Which data type stores true or false?",
                "What symbol is used for AND logical operator in C#?",
                "What is the file extension for C# source files?",
                "How many bits are in a byte?",
                "What keyword stops a loop immediately?"
            };
            string[] questionsAnswers = new string[]
            {
                "Paris",
                "12",
                "int",
                "Central Processing Unit",
                "5",
                "bool",
                "&&",
                ".cs",
                "8",
                "break"
            };

            int userScore = 0;
            int userAttempts = 3;

            for (int i = 0; i < questions.Length; i++)
            {
                userAttempts = 3;

                while (userAttempts > 0)
                {
                    Console.WriteLine(questions[i]);
                    Console.Write("Your answer: ");
                    string userAnswer = Console.ReadLine();

                    if (userAnswer.ToLower().Trim() == questionsAnswers[i].ToLower())
                    {
                        userScore += 1;
                        Console.WriteLine("\nYou are right!\n");
                        break;
                    }

                    userAttempts--;
                    Console.WriteLine("\nWrong. Attempts left: {0}\n", userAttempts);
                }
            }

            Console.WriteLine("Game over. You got {0}/{1} points.", userScore, questions.Length);
        }

        static void AddQuestion()
        {
            Console.WriteLine("Under development...");
        }
    }
}
