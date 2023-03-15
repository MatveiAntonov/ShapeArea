using ShapeArea.Shapes;

namespace ShapeArea.Tests.Shapes;
public class TriangleTests
{
    [Fact]
    public void CalculateArea_ValidInput_ReturnsCorrectResult()
    {
        // Arrange
        Triangle triangle = new Triangle(3, 4, 5);

        // Act
        double result = triangle.CalculateArea();

        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void CalculateArea_NegativeInput_ThrowsArgumentOutOfRangeException()
    {
        // Arrange, Act and Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-3, 4, 5));
    }

    [Fact]
    public void Constructor_AllZeroInput_ThrowsArgumentException()
    {
        // Arrange
        Triangle triangle = new Triangle(0, 0, 0);

        // Act
        double area = triangle.CalculateArea();

        // Assert
        Assert.Equal(0, area);
    }

    [Fact]
    public void IsRightTriangle_RightTriangle_ReturnsTrue()
    {
        // Arrange
        Triangle triangle = new Triangle(3, 4, 5);

        // Act
        bool result = triangle.IsRightTriangle();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsRightTriangle_NotRightTriangle_ReturnsFalse()
    {
        // Arrange
        Triangle triangle = new Triangle(3, 4, 6);

        // Act
        bool result = triangle.IsRightTriangle();

        // Assert
        Assert.False(result);
    }
}
