using ShapeArea;
using ShapeArea.Shapes;

namespace ShapeAreaDLL.Factory;

public static class ShapeFactory
{
    public static Shape CreateShape(params double[] args)
    {
        switch (args.Length)
        {
            case 1:
                return new Circle(args[0]);
            case 3:
                return new Triangle(args[0], args[1], args[2]);
            default:
                throw new ArgumentException("Неверное количество аргументов");
        }
    }
}
