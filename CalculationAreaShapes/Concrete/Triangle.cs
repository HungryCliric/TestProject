using CalculationAreaShapes.Abstract;

namespace CalculationAreaShapes.Concrete;

public class Triangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    // Формула Герона
    public override double CalculateArea()
    {
        double semiperimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));
    }

    // Пифагорова теорема
    public bool IsRightAngled()
    {
        var sides = new [] { SideA, SideB, SideC };
        Array.Sort(sides);

        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }
}