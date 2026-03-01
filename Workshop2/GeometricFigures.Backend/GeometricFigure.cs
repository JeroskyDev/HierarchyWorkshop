namespace GeometricFigures.Backend;

public abstract class GeometricFigure
{
    //properties
    public string? Name { get; set; }

    //methods
    public override string ToString() => $"{Name,-15} => Area.....:\t{GetArea(),11:N5}\t Perimeter:\t {GetPerimeter(),10:N5}";
    
    public abstract double GetArea();
    public abstract double GetPerimeter();
}
