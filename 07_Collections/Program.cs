namespace _07_Collections;

class Program
{
    static void Main(string[] args)
    {
        // List Implementation
        // List<T> name = new List<T>();
        List<string> purchasedGames = new List<string>();

        // .Add(T item)
        // Adds an item to the end of the list
        purchasedGames.Add("Minecraft: Pocket Edition");
        purchasedGames.Add("GTA 5");
        purchasedGames.Add("War Thunder");
        purchasedGames.Add("The Sims 4");
        purchasedGames.Add("Minecraft: Pocket Edition");

        // .Remove(T item)
        // Removes the first occurrence of a specific object from the list
        var minecraftPE = "Minecraft: Pocket Edition";
        purchasedGames.Remove(minecraftPE);

        // Output: Minecraft: Pocket Edition at the last index
        // Since .Remove(T item) removes only the first occurrence.
        Console.WriteLine("List after removing the first occurrence of {0}:", minecraftPE);
        foreach (var game in purchasedGames)
        {
            if (game == minecraftPE) // if it's still in the list
                Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"{game}, ");
            Console.ResetColor();
        }

        // .Insert(int index, T item)
        // Inserts an element at the specific index
        var newGame = "CS:GO";
        purchasedGames.Insert(0, newGame);
        Console.WriteLine("\n\nList with new items:");

        // Output: CS:GO at the index 0
        //  vvvv
        // [CS:GO, GTA 5, War Thunder, ...]
        foreach (var game in purchasedGames)
        {
            if (game == newGame)
                Console.ForegroundColor = ConsoleColor.Green;

            Console.Write(game + ", ");
            Console.ResetColor();
        }

        Console.WriteLine();

        // .Find(Predicate<T> match)
        // Search for an element that matches the conditions defined
        // by a specific predicate


        var found = purchasedGames.Find
            (game => game == "CS:GO");
        if (found != null)
        {
            Console.Write($"\nFound: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(found);
            Console.ResetColor();
        }

        // .Sort(): Sorts the elements in the entire List<T>
        purchasedGames.Sort();
        Console.WriteLine("\nSorted list in alphabetical order:");
        Console.WriteLine(string.Join(", ", purchasedGames));

        // .ToArray(): Copies the elements of the List<T> to a new array
        var gamesArr = purchasedGames.ToArray();  // shallow copy
        Console.WriteLine("\nConvert to Array: \n" 
                          + string.Join(", ", gamesArr));
        
        // .IndexOf(T item): Returns the index of the first occurrence
        Console.WriteLine("\nIndex of specific game: "
            + purchasedGames.IndexOf("The Sims 4"));

        // .Clear(): Removes all elements from the list
        purchasedGames.Clear();
        Console.ReadKey();
        Console.Clear();
        
        // =================================================== //

        List<string> colours = [
            "red", 
            "red",
            "blue",
            "red",
            "yellow",
            "green",
            "black",
            "red",
            "dark red",
            "red"
        ]; // adding items to the list (declared list)

        Console.WriteLine(string.Join(", ", colours));
        
        // Removing ALL occurrences from List
        for (int i = colours.Count - 1; i >= 0; i--)
        {
            if (colours[i].Contains("red".ToLower()))
            {
                colours.RemoveAt(i);
            }
        }

        Console.WriteLine("\nRemoved ALL 'red' occurrences: ");
        Console.WriteLine(string.Join(", ", colours));

        List<int> numbers = new List<int> { 10, 5, 15, 3, 9, 25, 18 };
        
        // This will return a list of number that are 10 and higher
        
        // x ⇒ (becomes) x >= 10;
        List<int> higherEqualTen = numbers.FindAll(x => x >= 10);
        Console.WriteLine($"\nBasic list: {string.Join(", ", numbers)}");
        Console.WriteLine($"Displayed all numbers that are equal or higher than 10: {string.Join(", ", higherEqualTen)}");
        
        // Predicates (bool) and Lambdas (⇒)
        // x => x * x; (=> - goes to/becomes)
        
        // Predicate ⇒ BOOL
        static int Squaring(int num) => num * num;
        Squaring(14);

        List<int> peopleAges = new List<int>();

        for (int i = 0; i < 2200; i++)
        {
            Random rand = new Random();
            peopleAges.Add(rand.Next(1, 100 + 1));
        }
        // Define the predicate to check if the person is adult (>= 18)
        Predicate<int> isAdult = x => x >= 18;
        List<int> adults = peopleAges.FindAll(isAdult);

        Predicate<int> isUnder18 = x => x < 18;
        List<int> notAdults = peopleAges.FindAll(isUnder18);

        double adultsPercentage = ((double)adults.Count / peopleAges.Count) * 100;
        double notAdultsPercentage = ((double)notAdults.Count / peopleAges.Count) * 100;
        
        Console.WriteLine("The percentage of adults: {0}%", Math.Round(adultsPercentage, 2));
        Console.WriteLine("The percentage of people under 18: {0}%", Math.Round(notAdultsPercentage, 2));
        
        // More examples
        List<long> prices = new List<long>();

        Random priceGen = new Random();
        int minPrice = 5;
        int maxPrice = 45000;

        long sum = 0;
        
        while (prices.Count != 150_000)
        {
            prices.Add(priceGen.Next(minPrice, maxPrice));
        }
        
        foreach (var price in prices)
        {
            sum += price;
        }

        Console.WriteLine("\n [!] Total sum of items: ${0}", sum.ToString("N0"));

        prices.Sort();

        Predicate<long> isExpensive = price => price > 25000 && price <= maxPrice;
        Predicate<long> isFavorable = price => price > 5000 && price <= 25000;
        Predicate<long> isInexpensive = price => price > 1000 && price <= 5000;
        Predicate<long> isCheap = price => price <= 1000 && price >= minPrice;
        
        Console.WriteLine("\nDATABASE OF ITEMS ({0} items):", prices.Count);
        Console.WriteLine("Found {0} expensive items (more than $25.000).", prices.FindAll(isExpensive).Count);
        Console.WriteLine("Found {0} favorable items (between $5000 and $25.000.", prices.FindAll(isFavorable).Count);
        Console.WriteLine("Found {0} inexpensive items (between $1000 and $5000).", prices.FindAll(isInexpensive).Count);
        Console.WriteLine("Found {0} cheap items (less than $1000).", prices.FindAll(isCheap).Count);
        
        // ANY Method
        bool hasLargeNumber = numbers.Any(x => x > 20);
        if (hasLargeNumber)
        {
            Console.WriteLine("There are Large numbers in the numbers list");
        }
        
        // REAL-WORLD USAGE (Database Implementation)

        List<PlayerDatabase> db = new List<PlayerDatabase>(); 

        Random gen = new Random();

        for (int i = 0; i <= 14; i++)
        {
            string playerNickname = PlayerDatabase.Nicknames[gen.Next(PlayerDatabase.Nicknames.Count)];
            string playerCountry = PlayerDatabase.Countries[gen.Next(PlayerDatabase.Countries.Count)];
            string playerServer = PlayerDatabase.Servers[gen.Next(PlayerDatabase.Servers.Count)];
            string playerIp = PlayerDatabase.GenerateIp();
            
            PlayerDatabase player = new PlayerDatabase();
            player.InsertData(playerNickname, playerIp, playerCountry,playerServer);
            db.Add(player);
        }

        Console.WriteLine($"Found {db.Count()} player(-s).");

        foreach (var player in db)
        {
            Console.Write($"{player.Nickname,-18} | {player.Location,-16} |");
            Console.Write(" IP: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{player.Ip,-16}");
            Console.ResetColor();
            Console.Write($"| Server: {player.Server}\n");
        }

        string desiredLocation = "France";
        
        bool searchLocation = 
            db.Any(p => p.Location == desiredLocation);

        if (searchLocation)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n[Search]");
            Console.ResetColor();
            Console.WriteLine("Found some players from {0}", desiredLocation);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n[Search]");
            Console.ResetColor();
            Console.WriteLine("Found no players from {0}", desiredLocation);
        }
    }
}