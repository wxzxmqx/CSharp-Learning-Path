namespace _06_OOP;

    internal class Customer
    {
        // Properties (w/ getters and setters)
        public string Name { get; set; } 
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Default Constructor
        public Customer()
        {
            Name = "New Customer";
            Address = "No address entered";
            ContactNumber = "No contact number entered";
        }
        
        // Custom Constructor (create new customer object)
        // Default Parameters (N/A) if not written
        public Customer(string name, string address = "N/A", string contactNumber = "N/A")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;

            Console.WriteLine($"The customer {name} has been added. \nAddress: {address}.\nContact Number: {contactNumber}.\n");
        }

        // METHOD (sets name, address and contact number)
        public void SetDetails(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }