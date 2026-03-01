//frontend for all of our geometric figure calculation showing.
using GeometricFigures.Backend;

var circle = new Circle(name: nameof(Circle), r: 5);
var square = new Square(name: nameof(Square), a: 10);
var rhombus = new Rhombus(name: nameof(Rhombus), a: 5, d1: 7, d2: 10);
var kite = new Kite(name: nameof(Kite), a: 7, b: 8, d1: 6, d2: 5);
var rectangle = new Rectangle(name: nameof(Rectangle), a: 4.568, b: 67.790);
var parallelogram = new Parallelogram(name: nameof(Parallelogram), a: 14.65, b: 54.67, h: 23.09);
var triangle = new Triangle(name: nameof(Triangle), a: 45.56, b: 12.34, c: 27.09, h: 15);
var trapeze = new Trapeze(name: nameof(Trapeze), a: 10, b: 20, c: 30, d: 40, h: 20);

var figures = new List<GeometricFigure>
{
    circle, square, rhombus, kite, rectangle, parallelogram, triangle, trapeze
};

foreach (var figure in figures)
{
    Console.WriteLine(figure);
}