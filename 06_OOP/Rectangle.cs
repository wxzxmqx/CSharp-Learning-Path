namespace _06_OOP;

internal class Rectangle
{
    // declaration of field (const)
    public const int Corners = 4;
    
    // declaration of field (readonly) - during runtime
    public readonly string Color;

    public Rectangle(string color = "Transparent")
    {
        Color = color; // modifying is possible
        // Corners = 8; // impossible due to const keyword
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Color: {Color}, width: {Width}, height: {Height}, corners: {Corners}");
    }

    public int SetWidth(int width)
    {
        Width = width;
        return width;
    }

    public int SetHeight(int height)
    {
        Height = height;
        return height;
    }
    
    public double Width { get; set; }
    public double Height { get; set; }

    // Computed Property
    
    // Getter property (READ-ONLY PROPERTY)
    public double Area { get => Width * Height; }
}