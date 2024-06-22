using Paragon;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int areaRadius = 1;
AreaOnSides areaOnSides = new AreaOnSides();
Triangle90 triangle90 = new Triangle90();
Console.WriteLine("Площадь круга (радиус=" + areaRadius.ToString() + ") " + areaOnSides.GetArea(areaRadius).ToString());
Console.WriteLine("Площадь треугольника по трем сторонам (10x10x10) = " + areaOnSides.AreaOnSidesCalc().ToString());
Console.WriteLine("Является ли прямоугольным треугольником (1, 1, 1)?: " + Triangle90.IsTriangle90(1, 1, 1));
Console.WriteLine("Является ли прямоугольным треугольником (3, 4, 5)?: " + Triangle90.IsTriangle90(3, 4, 5));
Console.ReadLine();