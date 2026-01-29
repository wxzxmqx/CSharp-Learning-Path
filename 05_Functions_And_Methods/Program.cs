namespace _05_Functions_And_Methods
{
    public class Program
    {
        static void Main()
        {
            // calling a method
            WriteSomething();
            Console.WriteLine("It's outside the method!");
            
            // declaring a variable
            string githubUsername = "@wxzxmqx";
            
            // calling the method with an argument
            WriteSomethingSpecific(githubUsername);

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int myResult = Add(num1, num2);

            Console.WriteLine(myResult);
            
            // SCOPE OF VARIABLES & PARAMETERS
            int currentYear = 2026;
            int myYear = 2007;
            ScopeExample(currentYear, myYear);
            
            // but we cannot access myCurrentAge out of the method!!!
            // myCurrentAge = 18;         <== ERROR
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
            return value1 + value2;
        }
        
        // SHOWCASE OF SCOPE
        static void ScopeExample(int currentYear, int myYear)
        {
            int myCurrentAge = currentYear - myYear;
            Console.WriteLine(myCurrentAge);
        }
    }
}