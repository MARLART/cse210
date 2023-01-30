using System;

public abstract class Shape
{
    public string _colour;

    public  Shape()
    {

    }
    public string GetColour()
    {
        return _colour;
    }

    public void SetColour(string colour)
    {
        _colour = colour;
    }

    public abstract double GetArea();

}