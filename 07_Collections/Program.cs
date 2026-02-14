namespace _07_Collections;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }
}

class Program
{
    static void Main(string[] args)
    {

        var codes = new Dictionary<string, string>
        {
            // key      value
            //  vvv       vvv  
            ["NY"] = "New York",
            ["CA"] = "California",
            ["TX"] = "Texas",
        };

        if (codes.TryGetValue("NY", out string state))
        {
            Console.WriteLine(state);
        }

        Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
        employees.Add(1, new Employee("Jay Sean", 25, 46000.00));        
        employees.Add(2, new Employee("Maria Sean", 19, 25000.00));
        employees.Add(3, new Employee("Sarah Will", 28, 80000.00));
        
        // Iteration through all employees
        foreach (var item in employees)
        {
            Console.WriteLine($"ID: {item.Key} named {item.Value.Name} " +
                              $"earns {item.Value.Salary} " +
                              $"and is {item.Value.Age}.");
        }

        Console.ReadKey();
        Console.Clear();
        
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
        
        while (prices.Count != 1_000_000)
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
        
        //
        // ------------------------------------------
        //
        // REAL-WORLD USAGE (Database Implementation)
        //
        // ------------------------------------------
        //

        List<PlayerDatabase> db = new List<PlayerDatabase>(); 

        Random gen = new Random();

        for (int i = 0; i <= 2; i++)
        {
            string playerNickname = PlayerDatabase.Nicknames[gen.Next(PlayerDatabase.Nicknames.Count)];
            string playerCountry = PlayerDatabase.Countries[gen.Next(PlayerDatabase.Countries.Count)];
            string playerServer = PlayerDatabase.Servers[gen.Next(PlayerDatabase.Servers.Count)];
            string playerIp = PlayerDatabase.GenerateIp();
            
            PlayerDatabase player = new PlayerDatabase(playerNickname, playerIp,playerCountry, playerServer);
            db.Add(player);
        }
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n[Search]");
        Console.ResetColor();
        Console.WriteLine($"Found {db.Count()} player(-s).");

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\n[Database]");
        Console.ResetColor();
        Console.WriteLine("Sensitive data is hidden.\n");
        
        foreach (var player in db)
        {
            string ip = player.Ip!;
            string maskedIp = ip.Substring(0, ip.Length - 6) + "******";
            
            Console.Write($"{player.Nickname,-18} | {player.Location,-16} |");
            Console.Write(" IP: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{maskedIp,-16}");
            Console.ResetColor();
            Console.Write($"| Server: {player.Server}\n");
        }
        
        string? desiredLocation = Console.ReadLine();
        
            bool searchLocation = 
                db.Any(p => p.Location == desiredLocation); // 1 occurrence
        
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
            
            //
            // NEW SESSION
            //

            List<Product> products = new List<Product>()
            {
                new Product { Name = "Banana", Price = 0.30},
                new Product { Name = "Kiwi", Price = 0.69},
                new Product { Name = "Apple", Price = 0.80},
                new Product { Name = "Strawberry", Price = 2.19},
            };

            products.Add(new Product { Name = "Berries", Price = 2.99 });

            Console.WriteLine($"Available Products: ");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name,-10} | ${product.Price}");
            }
            
            // List.Where() using case

            List<Product> cheapProducts = 
                products.Where(prod => prod.Price < 1.0).ToList();
            // Returns IEnumerable (more flexible, more generic)

            Console.WriteLine("------------------------");
            Console.WriteLine("Cheap Products (<$1): ");
            foreach (var product in cheapProducts)
            {
                Console.WriteLine($"{product.Name,-10} | ${product.Price,-5}");
            }
            
            // Dictionary ⇒ key-value pair

            // <int - key, string - value>
            Dictionary<int, string> customers = new Dictionary<int, string>();
            
            // Adding an item to a dictionary
            customers.Add(1, "John Doe");
            customers.Add(2, "Bob Smith");
            customers.Add(3, "Mark Smith");
            customers.Add(4, "Rob Smith");
            customers.Add(5, "Sam Smith");

            Console.ReadKey();
            Console.Clear();

            // Accessing an item to a dictionary
            string name = customers[2];
            Console.WriteLine(name);

            // Updating data in a dictionary
            customers[1] = "Jane Smith";
            
            // Removing an item from a dictionary
            customers.Remove(1);
            
            // Iterating through Dictionary
            foreach (var (id,customerName) in customers)
            {
                Console.WriteLine($"ID: {id,-2} | Name: {customerName,-15}");
            }
            
            // customers.Add(5, "Mike Jike");    <= ERROR
            
            // TODO:
            // Modify the dictionary of possible customers
            // and catch errors while they're trying to modify their values.
            
            do
            {
                Color(ConsoleColor.Yellow);
                Console.WriteLine("[Adding a new customer]");
                ResetColor();

                Console.Write("Enter an ID: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out var index);

                if (!isNumber || index < 0)
                {
                    Color(ConsoleColor.Red);
                    Console.Write("\n[x]");
                    ResetColor();
                    Console.WriteLine($" Error: Please enter a valid number.\n");
                    continue;
                }
                
                if (index == 0) break;

                Console.Write("Enter name: ");
                string newCustomer = Console.ReadLine();

                if (string.IsNullOrEmpty(newCustomer))
                {
                    Color(ConsoleColor.Red);
                    Console.Write("\n[x]");
                    ResetColor();
                    Console.WriteLine($" Error: Invalid Name\n");
                    continue;
                }

                bool success = customers.TryAdd(index, newCustomer);

                if (success)
                {
                    Color(ConsoleColor.Green);
                    Console.Write("\n[+]");
                    ResetColor();
                    Console.WriteLine($" The customer {newCustomer} has been added to the customer's database. Their ID is {index}.\n");
                }
                else
                {
                    Color(ConsoleColor.Red);
                    Console.Write("\n[x]");
                    ResetColor();
                    Console.WriteLine($" Error: That ID already exists!\n");
                }
            } while (true);
    }

    static void Color(ConsoleColor color) => Console.ForegroundColor = color;
    static void ResetColor() => Console.ResetColor();
}