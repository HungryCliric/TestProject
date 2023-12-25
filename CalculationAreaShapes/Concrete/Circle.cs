using CalculationAreaShapes.Abstract;

namespace CalculationAreaShapes.Concrete;

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
        => Math.PI * Math.Pow(Radius, 2);
}