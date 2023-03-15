using ShapeArea.Shapes;

namespace ShapeArea.Tests.Shapes;

public class CircleTests
{
    [Fact]
    public void CalculateArea_WithPositiveRadius_ReturnsCorrectArea()
    {
        // Arrange
        double radius = 5;
        Circle circle = new Circle(radius);

        // Act
        double area = circle.CalculateArea();

        // Assert
        Assert.Equal(Math.PI * radius * radius, area);
    }

    [Fact]
    public void CalculateArea_WithZeroRadius_ReturnsZero()
    {
        // Arrange
        double radius = 0;
        Circle circle = new Circle(radius);

        // Act
        double area = circle.CalculateArea();

        // Assert
        Assert.Equal(0, area);
    }

    [Fact]
    public void CalculateArea_WithNegativeRadius_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        double radius = -1;

        // Act and Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
    }
}
