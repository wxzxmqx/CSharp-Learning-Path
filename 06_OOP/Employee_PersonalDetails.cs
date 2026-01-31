namespace _06_OOP;

// partial = allow a class to be split across multiple files.
public partial class Employee
{
        private DateTime _birthDate;
        
        // employee properties 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("BirthDate cannot be in the future");
                _birthDate = value;
            } 
        }
        public string Location { get; set; }
        public DateTime? VacationUntil { get; private set; }
        public DateTime? SickLeaveUntil { get; private set; }

        public Employee()
        {
            FirstName = "Unknown";
            LastName = "Unknown";
            BirthDate = new DateTime(1970,01,01);
            Location = "Worldwide";
        }

        public void SetPersonalDetails(string firstname, string lastname, DateTime birthdate, string location)
        {
            FirstName = firstname;
            LastName = lastname;
            BirthDate = birthdate;
            Location = location;
        }
        
        public void EmployeeRelocate(string newLocation) => Location = newLocation;
        public void ChangeFirstName(string newFirstName) => FirstName = newFirstName;
        public void ChangeLastName(string newLastName) => LastName = newLastName;
        
}