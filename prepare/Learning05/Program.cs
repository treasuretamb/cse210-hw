using System;

class Program
{
    static void Main(string[] args)
    {     
        //A list holds the different shapes.
        List<Shape> shapes = new List<Shape>(); 

        // Creating instances for the shapes
        Square square = new Square("Red", 5.0);
        Rectangle rectangle = new Rectangle("Blue", 3.0, 4.0);
        Circle circle = new Circle("Green", 2.0);

        // Adding instances to the 'Shapes' list
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        // Iterating through each shape in the 'Shapes' list
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Color: " + shape.Color);
            Console.WriteLine("Area: " + shape.GetArea().ToString("F2")); // The .ToString method shortens up the number and only shows two digits after the decimal.
            Console.WriteLine();
        }    
    }

}