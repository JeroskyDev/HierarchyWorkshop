using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend;

public class Parallelogram : Rectangle
{
    //fields
    private double _h;

    //constructors
    public Parallelogram(string? name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }

    //properties
    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    //methods
    //public methods
    public override double GetArea() => (B * H);

    public override double GetPerimeter() => 2 * (A + B);

    //private methods
    private double ValidateH(double h)
    {
        if (h < 0)
        {
            throw new ArgumentException("Height CANNOT be negative. Try Again.");
        }
        return h;
    }
}
