namespace _05_Functions_And_Methods
{
    public class Program
    {
        static int myResult;
        
        static void Main()
        {
            // calling a method
            WriteSomething();
            Console.WriteLine("It's outside the method!");
            
            // declaring a variable
            string githubUsername = "@wxzxmqx";
            
            // calling the method with an argument
            WriteSomethingSpecific(githubUsername);

            if (int.TryParse(Console.ReadLine(), out int num1))
            {
                if (int.TryParse(Console.ReadLine(), out int num2))
                {
                    myResult = Add(num1, num2);
                    Console.WriteLine(myResult);
                    
                    myResult = Subtract(num1, num2);
                    Console.WriteLine(myResult);
                }
            }
            
            // SCOPE OF VARIABLES & PARAMETERS
            int currentYear = 2026;
            int myYear = 2007;
            ScopeExample(currentYear, myYear);
            
            // but we cannot access myCurrentAge out of the method!!!
            // myCurrentAge = 18;         <== ERROR

            Next();
            
            // Weather App Execution
            WeatherApp app = new WeatherApp();
            app.Run();
        }

        static void Next()
        {
            Console.ReadKey();
            Console.Clear();
        }
        
        // void method (returns nothing)
        static void WriteSomething()
        {
            Console.WriteLine("I'm writing something!");
        }
        
        // method declaration with parameter
        static void WriteSomethingSpecific(string message)
        {
            Console.WriteLine("You've sent the message: {0}", message);
        }

        // method declaration with return value
        static int Add(int value1, int value2)
        {
            myResult = value1 + value2;
            return myResult;
        }

        static int Subtract(int value1, int value2)
        {
            myResult = value1 - value2;
            return myResult;
        }
        
        // SHOWCASE OF SCOPE
        static void ScopeExample(int currentYear, int myYear)
        {
            int myCurrentAge = currentYear - myYear;
            Console.WriteLine(myCurrentAge);
        }
    }
}