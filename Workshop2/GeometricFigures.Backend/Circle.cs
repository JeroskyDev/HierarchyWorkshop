using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend;

public class Circle : GeometricFigure
{
    //fields
    private double _r;

    //constructors
    public Circle(string? name, int r)
    {
        Name = name;
        R = r;
    }

    //properties
    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    //methods
    //public methods

    public override double GetArea() => Math.PI * Math.Pow(R, 2);

    public override double GetPerimeter() => 2 * Math.PI * R;

    //private methods
    private double ValidateR(double r)
    {
        if (r < 0)
        {
            throw new ArgumentException("Radius CANNOT be negative. Try Again.");
        }
        return r;
    }
}
