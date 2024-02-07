// Rectangle.cs
public class Rectangle : Shape
{
    // This is a member variables for width and height
    private double _width;
    private double _height;

    // This is a constructor
    public Rectangle(string color, double width, double height) : base(color)
    {
        _width = width;
        _height = height;
    }

    // This is to override GetArea method
    public override double GetArea()
    {
        return _width * _height; // Area of a rectangle
    }
}
