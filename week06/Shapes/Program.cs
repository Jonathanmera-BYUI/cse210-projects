using System;
using System.Collections.Generic;

class Program
{
static void Main(string[] args)
{
   Square square = new Square("Red", 5);

   Console.WriteLine(square.GetColor());
   Console.WriteLine(square.GetArea());

   List<Shape> shapes = new List<Shape>();

  shapes.Add(new Square("Blue", 4));
  shapes.Add(new Rectangle("Green", 5, 3));
  shapes.Add(new Circle("Yellow", 2));

  foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.GetColor());
    Console.WriteLine(shape.GetArea());
}
    }
}