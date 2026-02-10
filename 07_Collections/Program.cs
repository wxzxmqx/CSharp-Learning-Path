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
    }
}