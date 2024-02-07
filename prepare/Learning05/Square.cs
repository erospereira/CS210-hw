// Square.cs
public class Square : Shape
{
    // This ia a member variable for side
    private double _side;

    // This is a  constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // This is to override GetArea method
    public override double GetArea()
    {
        return _side * _side; // Area of a square
    }
}
