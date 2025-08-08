using System;

abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    double radius;
    public Circle(double r) => radius = r;
    public override double GetArea() => Math.PI * radius * radius;
}

class Rectangle : Shape
{
    double width, height;
    public Rectangle(double w, double h) { width = w; height = h; }
    public override double GetArea() => width * height;
}

class Program
{
    static void Main()
    {
        Shape c = new Circle(5);
        Shape r = new Rectangle(4, 6);
        Console.WriteLine($"Circle Area: {c.GetArea()}");
        Console.WriteLine($"Rectangle Area: {r.GetArea()}");
    }
}
