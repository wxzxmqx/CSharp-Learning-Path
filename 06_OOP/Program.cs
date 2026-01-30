namespace _06_OOP;

class Program
{
    static void Main(string[] args) // entry point
    {
        // Creating an instance of the class Car
        Car ford = new Car("A3", "Ford");
        Car bmw = new Car("i7", "BMW");

        Console.WriteLine("Enter the Brand name.");
        
        // set property (setter)
        ford.Brand = "Ford";
        
        // get property (getter)
        Console.WriteLine("Brand is: {0}. ", ford.Brand);
        
        // STUDENT DATABASE
        Person a = new Person("Mark", "Borysov");
        Person b = new Person("Katja", "Esenina");
        Person c = new Person(Console.ReadLine(), Console.ReadLine());
        
        
    }
}