using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 5);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 6);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 3);
        shapes.Add(s3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an Area of {area}.");
        }
    }
}