using ShapeArea.Shapes;
using ShapeAreaDLL.Factory;

namespace ShapeArea.Tests.Factory;
public class ShapeFactoryTests
{
    [Fact]
    public void CreateShape_Circle_ReturnsCircle()
    {
        // Arrange
        double radius = 5;

        // Act
        Shape shape = ShapeFactory.CreateShape(radius);

        // Assert
        Assert.IsType<Circle>(shape);
    }

    [Fact]
    public void CreateShape_Triangle_ReturnsTriangle()
    {
        // Arrange
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;

        // Act
        Shape shape = ShapeFactory.CreateShape(side1, side2, side3);

        // Assert
        Assert.IsType<Triangle>(shape);
    }

    [Fact]
    public void CreateShape_InvalidArgumentCount_ThrowsArgumentException()
    {
        // Arrange
        double[] invalidArgs = new double[] { 1, 2, 3, 4 };

        // Act and Assert
        Assert.Throws<ArgumentException>(() => ShapeFactory.CreateShape(invalidArgs));
    }
}
