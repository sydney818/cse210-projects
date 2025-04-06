using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        Circle s3 = new Circle("Pink", 6);
        shapes.Add(s3);

        Square s1 = new Square("Purple", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);



        foreach (Shape s in shapes)
        {

            string color = s.GetColor();


            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}