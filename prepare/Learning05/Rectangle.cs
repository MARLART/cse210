using System;

public class Rectangle : Shape
{
    private double _length, _width;

    public Rectangle(string colour, double length, double width)
    {
        SetColour(colour);
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}