namespace _06_OOP;

class Program
{
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
    }
}