using System;

class Rectangle
{
    // Auto-properties
    public double Length { get; set; }
    public double Width { get; set; }

    // Expression-bodied read-only properties
    public double Area => Length * Width;
    public double Perimeter => 2 * (Length + Width);

    // Expression-bodied constructor
    public Rectangle(double length, double width) =>
        (Length, Width) = (length, width);

    // Expression-bodied methods
    public void PrintArea() => Console.WriteLine($"Area: {Area}");
    public void PrintPerimeter() => Console.WriteLine($"Perimeter: {Perimeter}");
}

class Program
{
    static void Main()
    {
        var rect = new Rectangle(5, 3);
        rect.PrintArea();
        rect.PrintPerimeter();
    }
}