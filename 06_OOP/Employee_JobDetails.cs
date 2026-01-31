namespace _06_OOP;

public partial class Employee 
{
    public string JobTitle { get; set; }
    public double Salary { get; set; }

    public void SetJobDetails(string jobTitle = "Employee", double salary = 0)
    {
        JobTitle = jobTitle;
        Salary = salary;
    }

    public void SubmitSickLeave(DateTime? until)
    {
        if (SickLeaveUntil.HasValue && DateTime.Now <= SickLeaveUntil)
        {
            Console.WriteLine($"The employee {FirstName} {LastName} is ALREADY on sick leave.");
            return;
        } else if (VacationUntil.HasValue && DateTime.Now <= VacationUntil)
        {
            Console.WriteLine($"The employee {FirstName} {LastName} is ALREADY on vacation. The sick leave cannot be taken during the outgoing vacation.");
            return;
        }
        
        Console.WriteLine($"The employee {FirstName} {LastName} is on sick leave.");
        SickLeaveUntil = until;
    }
    public void SubmitVacation(DateTime? until)
    {
        if (VacationUntil.HasValue && DateTime.Now <= VacationUntil)
        {
            Console.WriteLine($"The employee {FirstName} {LastName} is ALREADY on vacation.");
            return;
        } else if (SickLeaveUntil.HasValue && DateTime.Now <= SickLeaveUntil)
        {
            Console.WriteLine($"The employee {FirstName} {LastName} is ALREADY on sick leave. The vacation cannot be taken during the outgoing sick leave.");
            return;
        }
        
        Console.WriteLine($"The employee {FirstName} {LastName} is on the vacation.");
        VacationUntil = until;
    }
    public string GetWorkStatus()
    {
        if (SickLeaveUntil.HasValue && DateTime.Now <= SickLeaveUntil) return $"On sick leave until {SickLeaveUntil}";
        if (VacationUntil.HasValue && DateTime.Now <= VacationUntil) return $"On vacation until {VacationUntil}";
        return "Working";
    }
    
}