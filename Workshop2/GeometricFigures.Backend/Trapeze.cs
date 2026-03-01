using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend;

public class Trapeze : Triangle
{
    //fields
    private double _d;

    //constructors
    public Trapeze(string? name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
    {
        D = d;
    }

    //properties
    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }

    //methods
    //public methods
    public override double GetArea() => (B + D) * H / 2;

    public override double GetPerimeter() => A + B + C + D;

    //private methods
    private double ValidateD(double d)
    {
        if (d < 0)
        {
            throw new ArgumentException("Side D CANNOT be negative. Try Again.");
        }
        return d;
    }
}
