using CalculationAreaShapes.Concrete;

namespace CalculationTests;

public class ShapeTests
{
    [Test]
    public void CircleAreaCalculation()
    {
        var circle = new Circle(5);
        var area = circle.CalculateArea();
        Assert.AreEqual(Math.PI * 25, area);
    }

    [Test]
    public void TriangleAreaCalculation()
    {
        var triangle = new Triangle(3, 4, 5);
        var area = triangle.CalculateArea();
        Assert.AreEqual(6, area);
    }

    [Test]
    public void RightAngledTriangleCheck()
    {
        var rightAngledTriangle = new Triangle(3, 4, 5);
        Assert.IsTrue(rightAngledTriangle.IsRightAngled());

        var nonRightAngledTriangle = new Triangle(2, 3, 4);
        Assert.IsFalse(nonRightAngledTriangle.IsRightAngled());
    }
}