using System;

public class Rectangle : Shapes
{
    double _length;
    double _width;

    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }
    
    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }







}