using ShapeArea.Shapes;
using ShapeAreaDLL.Factory;

var triangle = new Triangle(84, 13, 85);
var circle = new Circle(5);


var isTriangleRight = triangle.IsRightTriangle();
var triangleArea = triangle.CalculateArea();
var circleArea = circle.CalculateArea();

var figureArea = ShapeFactory.CreateShape(3).CalculateArea();

Console.WriteLine(isTriangleRight);
Console.WriteLine(triangleArea);
Console.WriteLine(circleArea);

Console.WriteLine(figureArea);