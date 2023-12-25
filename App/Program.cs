using CalculationAreaShapes.Abstract;
using CalculationAreaShapes.Concrete;

// пример для пункта: Вычисление площади фигуры без знания типа фигуры в compile-time

var shapes = new List<Shape>
{
    new Circle(5),
    new Triangle(3, 4, 5)
};

foreach (var shape in shapes)
    Console.WriteLine($"Площадь фигуры: {shape.CalculateArea()}");


/*
 SELECT Products.ProductName, ISNULL(Categories.CategoryName, 'Без категории') AS CategoryName
 FROM Products
 LEFT JOIN ProductCategory ON Products.ProductID = ProductCategory.ProductID
LEFT JOIN 
    Categories ON ProductCategory.CategoryID = Categories.CategoryID;
 
 
 */