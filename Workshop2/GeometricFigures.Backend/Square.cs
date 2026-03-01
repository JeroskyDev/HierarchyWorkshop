using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend;

public class Square : GeometricFigure
{
    //fields
    private double _a;

    //constructors
    public Square(string? name, double a)
    {
        Name = name;
        A = a;
    }

    //properties
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    //methods
    //public methods
    public override double GetArea() => Math.Pow(A, 2);

    public override double GetPerimeter() => A * 4;

    //private methods
    private double ValidateA(double a)
    {
        if (a < 0)
        {
            throw new ArgumentException("Side CANNOT be negative. Try Again.");
        }
        return a;
    }
}
