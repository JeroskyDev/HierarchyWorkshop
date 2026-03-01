using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend;

public class Rectangle : Square
{
    //fields
    private double _b;

    //constructors
    public Rectangle(string? name, double a, double b) : base(name, a)
    {
        B = b;
    }

    //properties
    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

    //methods
    //public methods
    public override double GetArea() => A * B;

    public override double GetPerimeter() => 2 * (A + B);

    //private methods
    private double ValidateB(double b)
    {
        if (b < 0)
        {
            throw new ArgumentException("Side CANNOT be negative. Try Again.");
        }
        return b;
    }
}
