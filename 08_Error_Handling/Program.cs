namespace _08_Error_Handling;

class Program
{
    static void Main(string[] args)
    {
        int result = 0;

        // try-catch

        try // the code that might throw an exception
        {
            Console.WriteLine("Please enter a number");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            result = num1 / num2;
        }
        catch (Exception ex) // any exceptions inside catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n[ERROR]");
            Console.ResetColor();
            Console.WriteLine(ex.Message);
        } // finally keyword ("else")
        finally
        {
            Console.WriteLine("[!] The division attempted successfully.");
        }

        GetUserAge(Console.ReadLine());
    }

    static int GetUserAge(string input)
    {
        int age;
        
        if (!int.TryParse(input, out age))
        {
            throw new Exception("You didn't enter a valid age.");
        }

        if (age < 0 || age > 120)
        {
            // throw exception
            throw new Exception("Your age must be between 0 and 120.");
        }

        return age;
    }
}