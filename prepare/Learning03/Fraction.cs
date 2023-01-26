using System;
using System.IO;

public  class Fraction
{
     private int _denominator;
     private int _numerator;

    public int set_denominator(int bottemNumber)
    {
        bottemNumber = _denominator;
        return _denominator;

    }

    public int get_denominator()
    {
        return _denominator;
    }

    public int set_numerator(int topNumber)
    {
        topNumber = _numerator;
        return _numerator;
    }

    public int get_numerator()
    {
        return _numerator;
    }

     public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

     public Fraction ( int topNumber)
    {
        _numerator = topNumber;
        _denominator = 1;

    }
    public Fraction (int topNumber, int bottemNumber)
    {
        _numerator = topNumber;
        _denominator = bottemNumber;
        
    }

    public string GetFractionsString()
    {
     string writtenFraction = (@$"{_numerator}/{_denominator}");
     return writtenFraction;
    }

    public double GetDecimalValue()
    {
        double writtenDecimal = (double)_numerator/(double)_denominator;
        return writtenDecimal;
    }









}