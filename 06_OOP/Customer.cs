namespace _06_OOP;

    internal class Customer
    {
        // Static field to hold the next ID available
        private static int nextId = 0;

        private readonly int _id; // readonly (unique identifier)

        private string _password;
        
        // write-only property (no getter)
        public string Password { set => _password = value; }
        
        // Properties (w/ getters and setters)
        public string Name { get; set; } 
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        
        // read-only property (no setter)
        public int Id { get => _id; }

        // Default Constructor
        public Customer()
        {
            _id = nextId++;
            Name = "New Customer";
            Address = "No address entered";
            ContactNumber = "No contact number entered";
        }
        
        // Custom Constructor (create new customer object)
        // Default Parameters (N/A) if not written
        public Customer(string name, string address = "N/A", string contactNumber = "N/A")
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;

            Console.WriteLine($"The customer {name} has been added. \nAddress: {address}.\nContact Number: {contactNumber}.\n");
        }

        // METHOD (sets name, address and contact number)
        public void SetDetails(string name, string address, string contactNumber = "N/A")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void ReadDetails()
        {
            Console.WriteLine($"{Name}, id: {Id}");
        }
        
        // call it without creating an object
        public static void MakeADiscount()
        {
            Console.WriteLine("-20% discount for ALL products has been activated.");
        }
    }