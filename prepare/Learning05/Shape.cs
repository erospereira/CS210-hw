// Shape.cs
public class Shape
{
    // This is a member variable for color
    private string _color;

    // This is a constructor
    public Shape(string color)
    {
        _color = color;
    }

    // This is a setter and setter for color
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // Virtual method for GetArea
    public virtual double GetArea()
    {
        return 0; // Default implementation for base class
    }
}
