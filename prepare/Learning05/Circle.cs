// Circle.cs
public class Circle : Shape
{
    // This is a member variable for radius
    private double _radius;

    // This is a constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // This is to override GetArea method
    public override double GetArea()
    {
        return Math.PI * _radius * _radius; // Area of a circle
    }
}
