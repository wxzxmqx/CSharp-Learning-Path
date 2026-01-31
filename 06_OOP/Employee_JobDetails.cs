namespace _06_OOP;

public partial class Employee 
{
    public string JobTitle { get; set; }
    public double Salary { get; set; }
    public bool SickLeave { get; set; }
    public bool Vacation { get; set; }
    public DateTime WorkingSince { get; set; }

    public void SetJobDetails(string jobTitle = "Employee", double salary = 0, bool sickLeave = false, bool vacation = false, DateTime? workingSince = null)
    {
        JobTitle = jobTitle;
        Salary = salary;
        SickLeave = sickLeave;
        Vacation = vacation;
        if (workingSince == null) workingSince = DateTime.Now;
        
        Console.WriteLine("Job details saved successfully.");
    }
}