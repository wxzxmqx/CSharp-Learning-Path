namespace _06_OOP;

class Program
{
    /*
    \-> STATIC Class

     EXAMPLE:
     static void Utilities()

     \-> cannot be instantiated (can't do new Utilities());
      \-> all its member must be static;
     */
    static void Main(string[] args) // entry point
    {
        // Creating an instance of the class Car
        Car ford = new Car("A3", "Ford", true);
        Car bmw = new Car("i7", "BMW", true);

        Console.WriteLine("Enter the Brand name.");
        
        // set property (setter)
        ford.Brand = "Ford";
        bmw.Brand = "BMW";
        
        // get property (getter)
        Console.WriteLine("Brand is: {0}. ", ford.Brand);
        Console.WriteLine("Brand is: {0}. ", bmw.Brand);
        
        // METHODS IN CLASSES
        ford.Drive(); // ford - class, Drive() - method
        
        // STUDENT DATABASE
        // bool isRunning = true;
        //
        // while (isRunning)
        // {
        //     Console.Write("Enter student's name: ");
        //     string studentName = Console.ReadLine();
        //     
        //     Console.Write("Enter student's surname: ");
        //     string studentSurname = Console.ReadLine();
        //     
        //     if (studentName == "" || studentSurname == "")
        //     {
        //         isRunning = false;
        //     }
        //     
        //     Person newStudent = new Person(studentName, studentSurname);
        //     
        //     Console.WriteLine("\n[i] Click any button to add a new student");
        //     
        //     Console.ReadKey();
        //     Console.Clear();
        // }
        
        // Creating an instance of the class Customer
        Customer earl = new Customer("Earl");

        Customer customer = new Customer("Frank", "Dunkelstr. 188", "4915739039275");
        Console.WriteLine();
        
        // Default Customer without arguments given
        Customer myCustomer = new Customer();
        // Console.Write("Enter the customer's Name: ");
        // myCustomer.Name = Console.ReadLine();
        
        // Method that changes variables inside the created Object
        myCustomer.SetDetails("Erika", "Main Street 149B", "85039583911");
        Console.WriteLine("Details about customer: \n" + myCustomer.Name + "\n" + myCustomer.Address + "\n" + myCustomer.ContactNumber);
        
          // // // // //
         // COMPANY //
        // //  //  // 
        Console.Clear();
        // Create an instance of the class Employees (company)
        Employees company = new Employees();

        // Create an instance of the class Employee (employee #1)
        Employee emp1 = new Employee();
        
        // Setting details about a new employee
        emp1.SetPersonalDetails("John", "Doe", new DateTime(1990, 01, 01), "Cologne");
        emp1.SetJobDetails(Employees.jobTitles[2], 2500);

        // Add a new employee to created list
        company.AddEmployee(emp1);

        Employee emp2 = new Employee();

        // USING NAMED PARAMETERS
        emp2.SetPersonalDetails(firstname: "Mark", lastname: "Joe", birthdate: new DateTime(1996 - 03 - 05),
            location: "New York");
        emp2.SetJobDetails(Employees.jobTitles[6], 9500);
        
        // Add a new employee to created list
        company.AddEmployee(emp2);

        emp1.SubmitVacation(DateTime.Now.AddDays(30));
        emp2.SubmitSickLeave(DateTime.Now.AddDays(14));

        company.DisplayAllEmployees();
        
        Skip();

        // COMPUTED PROPERTY
        // without constructor
        Rectangle r1 = new Rectangle();
        r1.Width = 5;
        r1.Height = 6;
        
        // r1.Area = 5; <= read-only property (no setter)
        Console.WriteLine("The area of r1 is: {0}", r1.Area);
        
        Skip();

        /*
        \-> STATIC Method

         EXAMPLE:
         public static void DisplayNumberOfCars()

         \-> can be called without creating an object;
          \-> instance-specific fields (Model, Brand) aren't visible inside it;
         */
        
        Customer person = new Customer();
        person.SetDetails("Denis", "Main Street");
        Customer.MakeADiscount();
        
        /*
        \-> STATIC Field

         EXAMPLE:
         public static int NumberOfCars = 0;

         \-> belongs to the class itself, not any single instance;
          \-> shared among all s of the class;
         */
        
        Car car = new Car("A3","Audi", false);
        Car car2 = new Car();
        Car car3 = new Car();
        
        // accessing the public static variable "NumberOfCars" of the Car Class
        Console.WriteLine("Number of cars produced: " + Car.NumberOfCars);

        Skip();
        
        Customer c1 = new Customer("Joe");
        Customer c2 = new Customer("Maria");
        Customer c3 = new Customer();

        c1.ReadDetails();
        c2.ReadDetails();

        Console.WriteLine($"Id of {c2.Name} is: " + c2.Id);

        c3.Password = "12EKol0&*$#";
        // Console.WriteLine(c3.Password); <- lacks get accessor, cannot read the password

        Skip();

        Rectangle rect = new Rectangle("Pink");
        rect.SetWidth(4);
        rect.SetHeight(8);
        rect.DisplayDetails();

        Console.WriteLine($"WIDTH - {rect.Width} cm, HEIGHT - {rect.Height} cm");
        Console.WriteLine($"Area: {rect.Area}");
        
    }

    static void Skip()
    {
        Console.ReadKey();
        Console.Clear();
    }
}