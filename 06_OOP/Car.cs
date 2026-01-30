namespace _06_OOP;

internal class Car
{
    // Member Variable
    // >!< Private hides the variable from other classes >!<
    private string _model;
    private string _brand;

    // Property (protector)
    public string Model { get => _model; set => _model = value; } // get = read; set = write;
    public string Brand { get => _brand;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("You entered NOTHING!");
                _brand = "DEFAULT_VALUE";
            }
            else
            {
            _brand = value;
            }
            
        }
    }
    
    // Constructor 
    public Car(string model, string brand)
    {
        Model = model; 
        Brand = brand;
        Console.WriteLine("A car {1} of the model {0} has been created.", _model, _brand);
    }
}