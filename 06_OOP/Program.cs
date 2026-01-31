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
        bool isRunning = true;

        while (isRunning)
        {
            Console.Write("Enter student's name: ");
            string studentName = Console.ReadLine();
            
            Console.Write("Enter student's surname: ");
            string studentSurname = Console.ReadLine();
            
            if (studentName == "" && studentSurname == "")
            {
                isRunning = false;
            }
            
            Person newStudent = new Person(studentName, studentSurname);
            
            Console.WriteLine("\n[i] Click any button to add a new student");
            
            Console.ReadKey();
            Console.Clear();
            

            
        }
        
        
    }
}