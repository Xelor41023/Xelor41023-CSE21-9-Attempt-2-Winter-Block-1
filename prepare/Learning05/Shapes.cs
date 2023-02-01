using System.Drawing;
using System;

public class Shapes
{

    private string _color;
    private double _area;
    
    public Shapes(string color)
    {
        _color = color;
    }
    
    public void set_Color(string color)
    {
        _color = color;
    }

    public string get_color()
    {
        return _color;
    }

    public virtual double GetArea()
    {
        return _area;
    }
}