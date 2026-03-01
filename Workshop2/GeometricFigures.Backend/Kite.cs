using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend;

public class Kite : Rhombus
{
    //fields
    private double _b;

    //constructors
    public Kite(string? name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
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
    public override double GetArea() => (D1 * D2) / 2;
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
