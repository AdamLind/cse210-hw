using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Square s1 = new Square("green", 5);
        Console.WriteLine(s1.GetColor());
        Console.WriteLine(s1.GetArea());
        Rectangle r1 = new Rectangle("blue", 5, 7);
        Console.WriteLine(r1.GetColor());
        Console.WriteLine(r1.GetArea());
        Circle c1 = new Circle("yellow", 5);
        Console.WriteLine(c1.GetColor());
        Console.WriteLine(c1.GetArea());

        List<Shape> l1 = new List<Shape>();
        l1.Add(r1);
        l1.Add(c1);
        l1.Add(s1);
        
        foreach (Shape s in l1)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
    }
}