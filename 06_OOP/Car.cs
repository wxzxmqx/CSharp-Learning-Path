namespace _06_OOP;

internal class Car
{
    // Member Variable
    // >!< Private hides the variable from other classes >!<
    public static int NumberOfCars = 0;
    
    private string _model;
    private string _brand;
    private bool _isLuxury;
    
    // Property (protector)
    public string Model { get => _model; set => _model = value; } // get = read; set = write;
    public string Brand {
        get
        {
            if (_isLuxury)
            {
                return _brand + " - Luxury Edition";
            }
            else
            {
                return _brand;
            }
        }
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

    public bool isLuxury { get => _isLuxury; set => _isLuxury = value; }
    
    // Constructor 
    public Car(string model, string brand, bool isLuxury)
    {
        NumberOfCars++;
        
        Model = model; 
        Brand = brand;
        _isLuxury = isLuxury;
        
        Console.WriteLine("A car {1} of the model {0} has been created.", _model, _brand);
    }

    public Car() => NumberOfCars++;

    public void Drive()
    {
        Console.WriteLine("I'm a {0} and I'm driving...", Brand);
    }
}