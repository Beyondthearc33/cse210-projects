using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
    
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("Yellow", 5);
        Shape rectangle = new Rectangle("Green", 5, 3);
        Shape circle = new Circle("Purple", 3);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.getArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}