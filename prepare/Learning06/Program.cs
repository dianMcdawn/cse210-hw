using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning06 World!");
        Console.WriteLine("");

        //List of shapes
        List<Shape> shapes = new List<Shape>();

        //Creating a squeare
        Square square = new Square("black", 2);
        /*Console.WriteLine(square.Getcolor());
        Console.WriteLine(square.GetArea());*/

        //Creating a circle
        Circle circle = new Circle("white", 2);
        /*Console.WriteLine(circle.Getcolor());
        Console.WriteLine(circle.GetArea());*/

        //Creating a Rectangle
        Rectangle rectangle = new Rectangle("red", 3, 2);
        /*Console.WriteLine(rectangle.Getcolor());
        Console.WriteLine(rectangle.GetArea());*/

        //Adding to the list
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        //Loop to show everything
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.Getcolor());
            Console.WriteLine(shape.GetArea());
        }

    }
}