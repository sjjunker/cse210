using System;

class Program
{
    static void Main(string[] args)
    {
        //New Shapes
        Rectangle newRectangle = new Rectangle("blue", 5, 3);
        Circle newCircle = new Circle("yellow", 7);
        Square newSquare = new Square("red", 3);

        //List of shapes
        List<Shape> shapes = new List<Shape>();
        shapes.Add(newSquare);
        shapes.Add(newCircle);
        shapes.Add(newRectangle);

        //Get the color and area of each
        foreach(Shape shape in shapes) 
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}