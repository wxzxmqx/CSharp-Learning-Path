namespace _06_OOP;

public class Employees
{
    // List for storing all employees
    public List<Employee> AllEmployees { get; set; } = new List<Employee>();
    public static int EmployeesCount = 0; // access outside the class
    
    public static string[] jobTitles = {
        "Internship Student",
        "Quality Assurance Manager",
        "Junior Software Developer",
        "Middle Software Developer",
        "Senior Software Developer",
        "HR Manager",
        "Project Manager",
        "CEO"
    };

    // Add a new employee to company
    public void AddEmployee(Employee emp)
    {
        EmployeesCount++;
        AllEmployees.Add(emp);
        Console.WriteLine("{0} has been added successfully!", emp.FirstName);
    }

    public void DisplayAllEmployees()
    {
        int i = 0;
            
            foreach (var emp in AllEmployees)
            {
                i++;
                if (emp.GetWorkStatus() != "Working")
                {
                    Console.WriteLine($"{i}. {emp.FirstName} | {emp.JobTitle} | ${emp.Salary} | {emp.GetWorkStatus()}");
                    continue;
                }
                
                Console.WriteLine($"{i}. {emp.FirstName} | {emp.JobTitle} | ${emp.Salary}");
                
            }

    }

}