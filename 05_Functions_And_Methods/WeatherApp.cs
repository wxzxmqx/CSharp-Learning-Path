namespace _05_Functions_And_Methods;

public class WeatherApp
{
    public void Run()
    {
        Console.WriteLine("Enter the number of days to simulate: ");
        int days = int.Parse(Console.ReadLine());

        int[] temperature = new int[days];
        string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
        string[] weatherConditions = new string[days];

        Random gen = new Random();

        for (int i = 0; i < days; i++)
        {
            temperature[i] = gen.Next(-10, 40); 
            weatherConditions[i] = conditions[gen.Next(conditions.Length)];
        }

        Console.WriteLine($"Average Temperature is: {CalculateAverage(temperature)}");
        Console.WriteLine($"Maximum Value: {MaxValue(temperature)}");
        Console.WriteLine($"Minimum Value: {MinValue(temperature)}");
        Console.WriteLine($"Most Common Condition: {MostCommonCondition(conditions)}");
    }

    static double CalculateAverage(int[] temperature)
    {
        int sum = 0;

        foreach (int item in temperature)
        {
            sum += item;
        }
        
        double average = sum / temperature.Length;
        
        return average;
    }
    static double MaxValue(int[] temperature)
    {
        int max = temperature[0];

        foreach (int temp in temperature)
        {
            if (temp > max)
            {
                max = temp;
            }
        }

        return max;
    }
    static double MinValue(int[] temperature)
    {
        int min = temperature[0];

        foreach (int temp in temperature)
        {
            if (temp < min)
            {
                min = temp;
            }
        }

        return min;
    }
    static string MostCommonCondition(string[] conditions)
    {
        int count = 0;
        string mostCommon = conditions[0];

        for (int i = 0; i < conditions.Length; i++)
        {
            int tempCount = 0;
            
            for (int j = 0; j < conditions.Length; j++)
            {
                if (conditions[j] == conditions[i])
                {
                    tempCount++;
                }
            }

            if (tempCount > count)
            {
                count = tempCount;
                mostCommon = conditions[i];
            }
        }

        return mostCommon;
    }
}