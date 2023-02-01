using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square square = new Square("Vermillion", 4);
        Rectangle rectangle = new Rectangle("Vitellary", 8 , 2);
        Circle circle = new Circle("Victoria", 3.191538);

        Console.WriteLine(square.GetArea());
        Console.WriteLine(rectangle.GetArea());
        Console.WriteLine(circle.GetArea());
    }
}