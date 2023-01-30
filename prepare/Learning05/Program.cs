using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square squareRed = new Square("Red", 5);        
        Console.WriteLine(string.Format("The {0} Square has an area of {1}", squareRed.GetColour(), squareRed.GetArea()));
        shapes.Add(squareRed);

        Rectangle rectangleBlue = new Rectangle("Blue", 5, 4);    
        Console.WriteLine(string.Format("The {0} Rectangle has an area of {1}", rectangleBlue.GetColour(), rectangleBlue.GetArea()));
        shapes.Add(rectangleBlue);

        Circle circleYellow = new Circle("Yellow", 5);    
        Console.WriteLine(string.Format("The {0} Circle has an area of {1}", circleYellow.GetColour(), circleYellow.GetArea()));
        shapes.Add(circleYellow);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(string.Format("The {0} shape has an area of {1}", shape.GetColour(), shape.GetArea()));
        }
    }
}