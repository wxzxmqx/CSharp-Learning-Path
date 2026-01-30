namespace _06_OOP;

internal class Person
{
    /// <summary>
    /// Field (private): Outside code must not touch raw data
    /// and forces controlled access
    /// </summary>
    
    private string _name;
    private string _surname;
    
    /// <summary>
    /// Property: A controlled gateway to a field. Runs code.
    /// </summary>
    public string Name
    {
        get => _name; // returns stored value
        set // contains what caller passed (value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentException("Invalid name");
            _name = value;
        }
    } 
    public string Surname
    {
        get => _surname; // returns stored value
        set // contains what caller passed
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentException("Invalid surname");
            _surname = value;
        }
        
    }
    
    /// <summary>
    /// A constructor creates and initializes an object.
    /// </summary>
    public Person(string name, string surname)
    {
        Name = name;
        Surname = surname;
        Console.WriteLine("The student {0} {1} has been added to database.", name, surname);
    }

    /// <summary>
    /// Renames the student's name and surname if mistake is made
    /// </summary>
    public void Rename(string newName, string newSurname)
    {
        Name = newName;
        Surname = newSurname;
    }

    /// <summary>
    /// The method returns the full name of a student
    /// </summary>
    public string GetFullName()
    {
        return $"{Name} {Surname}";
    }
}