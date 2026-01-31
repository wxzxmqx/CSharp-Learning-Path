namespace _06_OOP;

public class Employees
{
    // List for storing all employees
    public List<Employee> AllEmployees { get; set; } = new List<Employee>();
    
    private string[] jobTitles = {
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
        AllEmployees.Add(emp);
        Console.WriteLine("{0} has been added successfully!", emp.FirstName);
    }
}